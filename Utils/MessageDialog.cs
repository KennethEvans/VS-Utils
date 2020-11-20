using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KEUtils.Message {
    /// <summary>
    /// This is a class that duplicates much of what MessageBox does. Much of 
    /// the implementation is heavily borrowed from FlexibleMessageBox:
    /// 
    /// Author:         Jörg Reichert(public @jreichert.de)
    /// Contributors:   Thanks to: David Hall, Roink
    /// Version:        1.3
    /// Published at:   http://www.codeproject.com/Articles/601900/FlexibleMessageBox
    /// 
    /// MessageDialog is a different implementation from FlexibleMessageBox. 
    /// The interface is a little more different from MessageBox and there is 
    /// a context menu. Some issues with FlexibleMessageBox have been fixed. 
    /// These include 
    ///  - Not allowing resize beyond the maximum width and height factors
    ///  - Not compensating for wrapped lines in calculating the size
    ///
    /// Features:
    ///  - It can be simply used instead of MessageBox since all important 
    ///        static "Show" methods are supported
    ///  - It can be resized and the content is correctly word-wrapped
    ///  - It tries to auto-size the width to show the longest text row
    ///  - It never exceeds the current desktop working area
    ///  - It displays a vertical scrollbar when needed
    ///  - It supports hyperlinks in text
    ///
    /// Because the interface is identical to MessageBox, you can add 
    /// MessageDialog to your project and use the it almost everywhere you use
    /// a standard MessageBox. It is only necessary to change the class name.
    ///
    /// Usage examples:
    ///
    /// MessageDialog.Show("Just a text");
    ///
    /// MessageDialog.Show("A text", "A caption");
    ///
    /// MessageDialog.Show("Some text with a link: www.google.com",
    ///     "Some caption",
    ///     MessageBoxButtons.AbortRetryIgnore,
    ///     MessageBoxIcon.Information,
    ///     MessageBoxDefaultButton.Button2);
    ///
    /// var dialogResult = MessageDialog.Show(
    ///   "Do you know the answer to life the universe and everything?", 
    ///   "One short question", MessageBoxButtons.YesNo);
    ///
    /// There are static fields for FONT, MAX_WIDTH_FACTOR, and
    /// MAX_HEIGHT_Factor that can be used to override the defaults.
    /// </summary>
    public partial class MessageDialog : Form {
        public static readonly String NL = Environment.NewLine;

        //These are the possible buttons (in a standard MessageBox)
        private enum ButtonID { OK = 0, CANCEL, YES, NO, ABORT, RETRY, IGNORE };

        private static readonly String[] BUTTON_TEXTS =
            { "OK", "Cancel", "&Yes", "&No", "&Abort", "&Retry", "&Ignore" };

        /// <summary>
        /// Defines the font for all MessageDialog instances.
        /// 
        /// Default is: SystemFonts.DefaultFont
        /// An alternative might be SystemFonts.MessageBoxFont.
        /// </summary>
        public static Font FONT = SystemFonts.DefaultFont;

        private MessageBoxDefaultButton defaultButton;
        private int visibleButtonsCount;

        /// <summary>
        /// Defines the maximum width for all MessageDialog instances in percent of the working area.
        /// 
        /// Allowed values are 0.2 - 1.0 where: 
        /// 0.2 means:  The MessageDialog can be at most 20% as wide as the working area.
        /// 1.0 means:  The MessageDialog can be as wide as the working area.
        /// 
        /// Default is: 40% of the working area width.
        /// </summary>
        public static double MAX_WIDTH_FACTOR = 0.4;

        /// <summary>
        /// Defines the maximum height for all MessageDialog instances in percent of the working area.
        /// 
        /// Allowed values are 0.2 - 1.0 where: 
        /// 0.2 means:  The MessageDialog can be at most 20% as high as the working area.
        /// 1.0 means:  The MessageDialog can be as high as the working area.
        /// 
        /// Default is: 50% of the working area height.
        /// </summary>
        public static double MAX_HEIGHT_FACTOR = 0.5;

        /// <summary>
        /// Initializes a new instance of the MessageDialog class.
        /// </summary>
        private MessageDialog() {
            InitializeComponent();
        }

        public MessageDialog(Size size, string text) {
            InitializeComponent();

            this.Text = text;

            // Do this to use as both model and modeless
            this.DialogResult = DialogResult.None;

            // Resize the Form
                this.Size = size;
        }

        public MessageDialog(Size size) : this(size, "") {
        }

        #region Public show method
        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="defaultButton">The default button.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton) {
            //Create a new instance of the MessageDialog form
            var messageBox = new MessageDialog();
            messageBox.ShowInTaskbar = false;

            ////Bind the caption and the message text
            //messageBox.CaptionText = caption;
            //messageBox.MessageText = text;
            //messageBox.FlexibleMessageBoxFormBindingSource.DataSource = messageBoxForm;

            //Set the buttons visibilities and texts. Also set a default button.
            SetDialogButtons(messageBox, buttons, defaultButton);

            //Set the icon. When no icon is used: Correct placement and width of rich text box.
            SetDialogIcon(messageBox, icon);

            //Set the font for all controls
            messageBox.Font = FONT;
            messageBox.richTextBox.Font = FONT;

            // Set the text and caption
            messageBox.Text = caption;
            messageBox.richTextBox.Text = text;

            //Calculate the dialogs start size (Try to auto-size width to show longest text row). Also set the maximum dialog size. 
            SetDialogSizes(messageBox, text, caption);
#if false
            //Set the dialogs start position when given. Otherwise center the dialog on the current screen.
            SetDialogStartPosition(messageBox, owner);
#endif
            //Show the dialog
            return messageBox.ShowDialog(owner);
        }
        #endregion

        #region Public show functions
        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(string text) {
            return MessageDialog.Show(null, text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text) {
            return MessageDialog.Show(owner, text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(string text, string caption) {
            return MessageDialog.Show(null, text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption) {
            return MessageDialog.Show(owner, text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons) {
            return MessageDialog.Show(null, text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons) {
            return MessageDialog.Show(owner, text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <returns></returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) {
            return MessageDialog.Show(null, text, caption, buttons, icon, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) {
            return MessageDialog.Show(owner, text, caption, buttons, icon, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="defaultButton">The default button.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton) {
            return MessageDialog.Show(null, text, caption, buttons, icon, defaultButton);
        }
        #endregion

        #region Helper methods
        /// <summary>
        /// Set the dialogs icon. 
        /// When no icon is used: Correct placement and width of rich text box.
        /// </summary>
        /// <param name="messageBox">The MessageDialog dialog.</param>
        /// <param name="icon">The MessageBoxIcon.</param>
        private static void SetDialogIcon(MessageDialog messageBox, MessageBoxIcon icon) {
            switch (icon) {
                case MessageBoxIcon.Information:
                    messageBox.pictureBox.Image = SystemIcons.Information.ToBitmap();
                    break;
                case MessageBoxIcon.Warning:
                    messageBox.pictureBox.Image = SystemIcons.Warning.ToBitmap();
                    break;
                case MessageBoxIcon.Error:
                    messageBox.pictureBox.Image = SystemIcons.Error.ToBitmap();
                    break;
                case MessageBoxIcon.Question:
                    messageBox.pictureBox.Image = SystemIcons.Question.ToBitmap();
                    break;
                default:
                    //When no icon is used: Correct placement and width of rich text box.
                    messageBox.pictureBox.Visible = false;
                    //messageBox.richTextBoxMessage.Left -= messageBox.pictureBoxForIcon.Width;
                    //messageBox.richTextBoxMessage.Width += messageBox.pictureBoxForIcon.Width;
                    break;
            }
        }

        /// <summary>
        /// Set dialog buttons visibilities and texts. 
        /// Also sets a default button.
        /// </summary>
        /// <param name="messageDialog">The MessageDialog dialog.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="defaultButton">The default button.</param>
        private static void SetDialogButtons(MessageDialog messageDialog,
            MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton) {
            messageDialog.button1.Visible = false;
            messageDialog.button2.Visible = false;
            messageDialog.button3.Visible = false;

            //Set the buttons Visibility and Text's
            switch (buttons) {
                case MessageBoxButtons.AbortRetryIgnore:
                    messageDialog.visibleButtonsCount = 3;

                    messageDialog.button1.Visible = true;
                    messageDialog.button1.Text = messageDialog.GetButtonText(ButtonID.ABORT);
                    messageDialog.button1.DialogResult = DialogResult.Abort;

                    messageDialog.button2.Visible = true;
                    messageDialog.button2.Text = messageDialog.GetButtonText(ButtonID.RETRY);
                    messageDialog.button2.DialogResult = DialogResult.Retry;

                    messageDialog.button3.Visible = true;
                    messageDialog.button3.Text = messageDialog.GetButtonText(ButtonID.IGNORE);
                    messageDialog.button3.DialogResult = DialogResult.Ignore;

                    messageDialog.ControlBox = false;
                    break;

                case MessageBoxButtons.OKCancel:
                    messageDialog.visibleButtonsCount = 2;

                    messageDialog.button2.Visible = true;
                    messageDialog.button2.Text = messageDialog.GetButtonText(ButtonID.OK);
                    messageDialog.button2.DialogResult = DialogResult.OK;

                    messageDialog.button3.Visible = true;
                    messageDialog.button3.Text = messageDialog.GetButtonText(ButtonID.CANCEL);
                    messageDialog.button3.DialogResult = DialogResult.Cancel;

                    messageDialog.CancelButton = messageDialog.button3;
                    break;

                case MessageBoxButtons.RetryCancel:
                    messageDialog.visibleButtonsCount = 2;

                    messageDialog.button2.Visible = true;
                    messageDialog.button2.Text = messageDialog.GetButtonText(ButtonID.RETRY);
                    messageDialog.button2.DialogResult = DialogResult.Retry;

                    messageDialog.button3.Visible = true;
                    messageDialog.button3.Text = messageDialog.GetButtonText(ButtonID.CANCEL);
                    messageDialog.button3.DialogResult = DialogResult.Cancel;

                    messageDialog.CancelButton = messageDialog.button3;
                    break;

                case MessageBoxButtons.YesNo:
                    messageDialog.visibleButtonsCount = 2;

                    messageDialog.button2.Visible = true;
                    messageDialog.button2.Text = messageDialog.GetButtonText(ButtonID.YES);
                    messageDialog.button2.DialogResult = DialogResult.Yes;

                    messageDialog.button3.Visible = true;
                    messageDialog.button3.Text = messageDialog.GetButtonText(ButtonID.NO);
                    messageDialog.button3.DialogResult = DialogResult.No;

                    messageDialog.ControlBox = false;
                    break;

                case MessageBoxButtons.YesNoCancel:
                    messageDialog.visibleButtonsCount = 3;

                    messageDialog.button1.Visible = true;
                    messageDialog.button1.Text = messageDialog.GetButtonText(ButtonID.YES);
                    messageDialog.button1.DialogResult = DialogResult.Yes;

                    messageDialog.button2.Visible = true;
                    messageDialog.button2.Text = messageDialog.GetButtonText(ButtonID.NO);
                    messageDialog.button2.DialogResult = DialogResult.No;

                    messageDialog.button3.Visible = true;
                    messageDialog.button3.Text = messageDialog.GetButtonText(ButtonID.CANCEL);
                    messageDialog.button3.DialogResult = DialogResult.Cancel;

                    messageDialog.CancelButton = messageDialog.button3;
                    break;

                case MessageBoxButtons.OK:
                default:
                    messageDialog.visibleButtonsCount = 1;
                    messageDialog.button3.Visible = true;
                    messageDialog.button3.Text = messageDialog.GetButtonText(ButtonID.OK);
                    messageDialog.button3.DialogResult = DialogResult.OK;

                    messageDialog.CancelButton = messageDialog.button3;
                    break;
            }

            //Set default button (used in MessageDialog_Shown)
            messageDialog.defaultButton = defaultButton;
        }

        /// <summary>
        /// Gets the button text.
        /// </summary>
        /// <param name="buttonID">The ID of the button.</param>
        /// <returns>The button text.</returns>
        private string GetButtonText(ButtonID buttonID) {
            int buttonTextArrayIndex = Convert.ToInt32(buttonID);
            return BUTTON_TEXTS[buttonTextArrayIndex];
        }

        /// <summary>
        /// Calculate the dialogs start size (Try to auto-size width to show longest text row).
        /// Also set the maximum dialog size. 
        /// </summary>
        /// <param name="messageBox">The MessageDialog dialog.</param>
        /// <param name="text">The text (the longest text row is used to calculate the dialog width).</param>
        /// <param name="text">The caption (this can also affect the dialog width).</param>
        private static void SetDialogSizes(MessageDialog messageBox, string text, string caption) {
            //First set the bounds for the maximum dialog size
            messageBox.MaximumSize = new Size(Convert.ToInt32(SystemInformation.WorkingArea.Width * MessageDialog.GetCorrectedWorkingAreaFactor(MAX_WIDTH_FACTOR)),
                                                          Convert.ToInt32(SystemInformation.WorkingArea.Height * MessageDialog.GetCorrectedWorkingAreaFactor(MAX_HEIGHT_FACTOR)));

            //Calculate margins
            int marginWidth = messageBox.Width - messageBox.RichTextBox.Width;
            int marginHeight = messageBox.Height - messageBox.RichTextBox.Height;
            int textMaxWidth = messageBox.MaximumSize.Width - marginWidth;

            //Get rows. Exit if there are no rows to render...
            string[] stringRows = GetStringRows(text);
            if (stringRows == null) return;

            //Calculate whole text height
            int textHeight = TextRenderer.MeasureText(text, FONT).Height;
            int textSingleLineHeight = TextRenderer.MeasureText(
                "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz", FONT).Height;

            //Calculate width for longest text line
            int longestTextRowWidth = stringRows.Max(textForRow => TextRenderer.MeasureText(textForRow, FONT).Width);
            // Make it wide enough to fix both the caption and the test
            const int SCROLLBAR_WIDTH_OFFSET = 15;
            int captionWidth = TextRenderer.MeasureText(caption, SystemFonts.CaptionFont).Width;
            int textWidth = Math.Max(longestTextRowWidth + SCROLLBAR_WIDTH_OFFSET, captionWidth);
            // Adjust textHeight for wrapped lines
            foreach (string row in stringRows) {
                int lineWidth = TextRenderer.MeasureText(row, FONT).Width;
                int nLines = (int)Math.Ceiling((double)lineWidth / textMaxWidth);
                if (nLines > 1) textHeight += (nLines - 1) * textSingleLineHeight;
            }

            //Set calculated dialog size (if the calculated values exceed the maximums,
            // they are cut by windows forms automatically)
            messageBox.Size = new Size(textWidth + marginWidth,
                textHeight + marginHeight);
        }

        /// <summary>
        /// Gets the string rows.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>The string rows as 1-dimensional array</returns>
        private static string[] GetStringRows(string message) {
            if (string.IsNullOrEmpty(message)) return null;

            var messageRows = message.Split(new char[] { '\n' }, StringSplitOptions.None);
            return messageRows;
        }

        /// <summary>
        /// Ensure the given working area factor in the range of  0.2 - 1.0 where: 
        /// 
        /// 0.2 means:  20 percent of the working area height or width.
        /// 1.0 means:  100 percent of the working area height or width.
        /// </summary>
        /// <param name="workingAreaFactor">The given working area factor.</param>
        /// <returns>The corrected given working area factor.</returns>
        private static double GetCorrectedWorkingAreaFactor(double workingAreaFactor) {
            const double MIN_FACTOR = 0.2;
            const double MAX_FACTOR = 1.0;

            if (workingAreaFactor < MIN_FACTOR) return MIN_FACTOR;
            if (workingAreaFactor > MAX_FACTOR) return MAX_FACTOR;

            return workingAreaFactor;
        }
        #endregion

        // Old Methods
#if false
        public void appendText(string text) {
            if (!String.IsNullOrEmpty(text)) {
                this.richTextBox.AppendText(text);
            }
        }

        public void appendTextAndNL(string text) {
            if (!String.IsNullOrEmpty(text)) {
                this.richTextBox.AppendText(text + NL);
            }
        }

        public string getText() {
            return this.richTextBox.Text;
        }

        public void setText(string text) {
            richTextBox.Text = text;
        }

        public void clear() {
            this.richTextBox.Text = "";
        }

        private void OnVisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                this.DialogResult = DialogResult.None;
            }
        }
#endif

        /// <summary>
        /// Handles the LinkClicked event of the richTextBoxMessage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkClickedEventArgs"/> instance containing the event data.</param>
        private void OnRichTextBoxLinkClicked(object sender, LinkClickedEventArgs e) {
            try {
                Cursor.Current = Cursors.WaitCursor;
                Process.Start(e.LinkText);
            } catch (Exception) {
                //Let the caller of FlexibleMessageBoxForm decide what to do with this exception...
                throw;
            } finally {
                Cursor.Current = Cursors.Default;
            }
        }

        private void OnButton1Click(object sender, EventArgs e) {
            this.Visible = false;
        }

        private void OnButton2Click(object sender, EventArgs e) {
            this.Visible = false;
        }

        private void OnButton3Click(object sender, EventArgs e) {
            this.Visible = false;
        }

        public Button Button1 {
            get {
                return button1;
            }
        }

        public Button Button2 {
            get {
                return button2;
            }
        }

        public Button Button3 {
            get {
                return button3;
            }
        }

        public RichTextBox RichTextBox {
            get {
                return richTextBox;
            }
        }

        /// <summary>
        /// Only copies the rich text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCopyClick(object sender, EventArgs e) {
            string textForClipboard = this.richTextBox.Text + NL;
            Clipboard.SetText(textForClipboard);
        }

        /// <summary>
        /// Implements copy like the MessageBox would.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCopyMBClick(object sender, EventArgs e) {
            const string STANDARD_MESSAGEBOX_SEPARATOR_LINES = "---------------------------\n";
            const string STANDARD_MESSAGEBOX_SEPARATOR_SPACES = "   ";
            string buttonsTextLine = (this.button1.Visible ? this.button1.Text
                + STANDARD_MESSAGEBOX_SEPARATOR_SPACES : string.Empty)
                + (this.button2.Visible ? this.button2.Text
                + STANDARD_MESSAGEBOX_SEPARATOR_SPACES : string.Empty)
                + (this.button3.Visible ? this.button3.Text
                + STANDARD_MESSAGEBOX_SEPARATOR_SPACES : string.Empty);

            //Build the same clipboard text as the standard .Net MessageBox
            string textForClipboard = STANDARD_MESSAGEBOX_SEPARATOR_LINES
                                 + this.Text + NL
                                 + STANDARD_MESSAGEBOX_SEPARATOR_LINES
                                 + this.richTextBox.Text + NL
                                 + STANDARD_MESSAGEBOX_SEPARATOR_LINES
                                 + buttonsTextLine.Replace("&", string.Empty) + NL
                                 + STANDARD_MESSAGEBOX_SEPARATOR_LINES;

            //Set text in clipboard
            Clipboard.SetText(textForClipboard);
        }

        private void OnFormShown(object sender, EventArgs e) {
            // Allow it now to be resized beyond the MAXIMUM_WIDTH_FACTOR
            ///and MAXIMUM_WIDTH_FACTOR factors
            this.MaximumSize = new Size(0, 0);

            Button buttonToFocus;

            //Set the default button...
            int buttonIndexToFocus;
            switch (this.defaultButton) {
                case MessageBoxDefaultButton.Button1:
                default:
                    buttonIndexToFocus = 1;
                    break;
                case MessageBoxDefaultButton.Button2:
                    buttonIndexToFocus = 2;
                    break;
                case MessageBoxDefaultButton.Button3:
                    buttonIndexToFocus = 3;
                    break;
            }

            if (buttonIndexToFocus > this.visibleButtonsCount) {
                buttonIndexToFocus = this.visibleButtonsCount;
            }
            if (buttonIndexToFocus == 3) {
                buttonToFocus = this.button3;
            } else if (buttonIndexToFocus == 2) {
                buttonToFocus = this.button2;
            } else {
                buttonToFocus = this.button1;
            }
            buttonToFocus.Focus();
        }
    }
}
