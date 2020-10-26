﻿//#define SHOW_ITEM_CLICKED

using KEUtils.About;
using KEUtils.Message;
using KEUtils.ScrolledHTML;
using KEUtils.ScrolledText;
using KEUtils.Utils;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Utils_Demo {
    public partial class MainForm : Form {
        public static readonly String NL = Environment.NewLine;
        public static readonly string LONG_STRING =
     "Sed ut perspiciatis unde omnis iste natus error sit voluptatem"
     + "accusantium doloremque laudantium, totam rem aperiam, "
     + "eaque ipsa quae ab illo inventore veritatis et quasi "
     + "architecto beatae vitae dicta sunt explicabo.Nemo enim "
     + "ipsam voluptatem quia voluptas sit aspernatur aut odit "
     + "aut fugit, sed quia consequuntur magni dolores eos qui "
     + "ratione voluptatem sequi nesciunt. Neque porro quisquam "
     + "est, qui dolorem ipsum quia dolor sit amet, consectetur, "
     + "adipisci velit, sed quia non numquam eius modi tempora "
     + "incidunt ut labore et dolore magnam aliquam quaerat " +
     "voluptatem. Ut enim ad minima veniam, quis nostrum "
     + "exercitationem ullam corporis suscipit laboriosam, "
     + "nisi ut aliquid ex ea commodi consequatur? Quis autem "
     + "vel eum iure reprehenderit qui in ea voluptate velit "
     + "esse quam nihil molestiae consequatur, vel illum qui "
     + "dolorem eum fugiat quo voluptas nulla pariatur ?";
        public static readonly string VERY_LONG_STRING = LONG_STRING +
            " " + LONG_STRING + " " + LONG_STRING + " " + LONG_STRING +
            " " + LONG_STRING + " " + LONG_STRING + " " + LONG_STRING +
            " " + LONG_STRING;

        private static ScrolledHTMLDialog overviewDlg;
        private static ScrolledTextDialog scrolledText;


        public MainForm() {
            InitializeComponent();
        }

        private void OnFileQuitClick(object sender, EventArgs e) {
            Close();
        }

        private void OnHelpOverviewClick(object sender, EventArgs e) {
            // Create, show, or set visible the overview dialog as appropriate
            if (overviewDlg == null) {
                MainForm app = (MainForm)FindForm().FindForm();
                overviewDlg = new ScrolledHTMLDialog(
                    Utils.getDpiAdjustedSize(app, new Size(800, 600)),
                    "Overview");
                overviewDlg.Show();
            } else {
                overviewDlg.Visible = true;
            }
        }

        private void OnHelpAboutClick(object sender, EventArgs e) {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Image image = null;
            try {
                image = Image.FromFile(@".\Help\UtilsDemo.256x256.png");
            } catch (Exception ex) {
                Utils.excMsg("Failed to get AbutBox image", ex);
            }
            AboutBox dlg = new AboutBox("About Utils Demo", image, assembly);
            dlg.ShowDialog();
        }

        private void OnInfoClick(object sender, EventArgs e) {
            string msg = "This is some example information."
                + NL + "This is a second line";
            Utils.infoMsg(msg);
        }

        private void OnWarnClick(object sender, EventArgs e) {
            //string msg = "This is an example warning."
            //+ NL + "This is a second line";
            string text = VERY_LONG_STRING;
            Utils.warnMsg(text);
        }

        private void OnErrClick(object sender, EventArgs e) {
            string msg = "This is some example error information."
                + NL + "This is a second line";
            Utils.errMsg(msg);
        }

        private void OnExcClick(object sender, EventArgs e) {
            string msg = "This is some example exception information.";
            try {
                Double.Parse("garbage");
            } catch (Exception ex) {
                Utils.excMsg(msg, ex);
            }
        }

        private void OnExc1Click(object sender, EventArgs e) {
            string msg = "This is some example exception information with a stack trace.";
            try {
                Double.Parse("garbage");
            } catch (Exception ex) {
                Utils.excMsg(msg + NL + ex.StackTrace, ex);
            }
        }

        private void OnScrolledTextClickModelessClick(object sender, EventArgs e) {
            DateTime now = new DateTime();
            if (scrolledText == null) {
                scrolledText = new ScrolledTextDialog(
                Utils.getDpiAdjustedSize(this, new Size(400, 400)),
                "Start of Scrolled Text");
                scrolledText.appendTextAndNL("OnScrolledTextClick (First Time)"
                    + now);
            }
            scrolledText.ButtonCancel.Visible = false;
            scrolledText.appendTextAndNL(NL + "OnScrolledTextClick " + now);
            scrolledText.Visible = true;
        }

        private void OnScrolledTextClickModalClick(object sender, EventArgs e) {
            string msg = LONG_STRING;
            ScrolledTextDialog dlg = new ScrolledTextDialog(
            Utils.getDpiAdjustedSize(this, new Size(400, 400)),
            "Example Scrolled Text");
            dlg.appendText(msg);
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK) {
                Utils.infoMsg("You clicked OK");
            } else if (res == DialogResult.Cancel) {
                Utils.infoMsg("You clicked Cancel");
            }
        }

        private void OnMessageOkClick(object sender, EventArgs e) {
            string caption = "Caption";
            string text = "Text";
            DialogResult res = MessageDialog.Show(text, caption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
#if SHOW_ITEM_CLICKED
            Utils.infoMsg( res + " clicked");
#endif
        }

        private void OnMessageOkCancelClick(object sender, EventArgs e) {
            string caption = "Caption";
            string text = LONG_STRING;
            DialogResult res = MessageDialog.Show(text, caption,
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
#if SHOW_ITEM_CLICKED
            Utils.infoMsg( res + " clicked");
#endif
        }

        private void OnMessageAbortRetryIgnoreClick(object sender, EventArgs e) {
            string caption = "Caption";
            string text = "Text";
            DialogResult res = MessageDialog.Show(text, caption,
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
#if SHOW_ITEM_CLICKED
            Utils.infoMsg( res + " clicked");
#endif
        }

        private void OnMessageYesNoCancelClick(object sender, EventArgs e) {
            string caption = "Caption";
            string text = "Text";
            DialogResult res = MessageDialog.Show(text, caption,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
#if SHOW_ITEM_CLICKED
            Utils.infoMsg( res + " clicked");
#endif
        }

        private void OnMessageYesNoClick(object sender, EventArgs e) {
            string caption = "Caption";
            string text = "Text";
            DialogResult res = MessageDialog.Show(text, caption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
#if SHOW_ITEM_CLICKED
            Utils.infoMsg( res + " clicked");
#endif
        }

        private void OnMessageRetryCancelClick(object sender, EventArgs e) {
            string caption = "Caption";
            string text = "Text";
            DialogResult res = MessageDialog.Show(text, caption,
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
#if SHOW_ITEM_CLICKED
            Utils.infoMsg( res + " clicked");
#endif
        }

        private void OnMessageBoxOk(object sender, EventArgs e) {
            string caption = "Caption";
            string text = "Text";
            DialogResult res = MessageBox.Show(text, caption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
#if SHOW_ITEM_CLICKED
            Utils.infoMsg( res + " clicked");
#endif
        }

        private void OnMessageBoxLong(object sender, EventArgs e) {
            string caption = "Caption";
            string text = LONG_STRING;
            DialogResult res = MessageBox.Show(text, caption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
#if SHOW_ITEM_CLICKED
            Utils.infoMsg( res + " clicked");
#endif
        }

        private void OnMessageBoxLonger(object sender, EventArgs e) {
            string caption = "Caption";
            string text = VERY_LONG_STRING;
            DialogResult res = MessageBox.Show(text, caption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
#if SHOW_ITEM_CLICKED
            Utils.infoMsg( res + " clicked");
#endif
        }

        private void OnMessageLong(object sender, EventArgs e) {
            string caption = "Caption";
            string text = LONG_STRING;
            DialogResult res = MessageDialog.Show(text, caption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
#if SHOW_ITEM_CLICKED
            Utils.infoMsg( res + " clicked");
#endif
        }
        private void OnMessageLonger(object sender, EventArgs e) {
            string caption = "Caption";
            string text = VERY_LONG_STRING;
            DialogResult res = MessageDialog.Show(text, caption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
#if SHOW_ITEM_CLICKED
            Utils.infoMsg( res + " clicked");
#endif
        }

    }
}
