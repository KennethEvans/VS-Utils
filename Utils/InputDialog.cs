using System;
using System.Windows.Forms;

namespace KEUtils.InputDialog {
    public partial class InputDialog : Form {

        public InputDialog() : this(null, null, null) {
        }

        public InputDialog(string title, string prompt) : this(title, prompt, null) {
        }

        public InputDialog(string title, string prompt, string value) {
            InitializeComponent();

            if (title != null) Title = title;
            if (prompt != null) Prompt = prompt;
            if (value != null) Value = value;
        }

        public string Title {
            get {
                return Text;
            }
            set {
                Text = value;
            }
        }

        public string Prompt {
            get {
                return labelPrompt.Text;
            }
            set {
                labelPrompt.Text = value;
            }
        }

        public string Value {
            get {
                return textBoxValue.Text;
            }
            set {
                textBoxValue.Text = value;
            }
        }

        /// <summary>
        /// Gets the Ok button.
        /// </summary>
        public Button OkButton {
            get {
                return buttonOk;
            }
        }

        /// <summary>
        /// Gets the Cancel button. (This hides Form.CancelButton.)
        /// </summary>
        new public Button CancelButton {
            get {
                return buttonCancel;
            }
        }

        private void OnButtonClicked(object sender, EventArgs e) {
            Button btn = (Button)sender;
            if (btn == buttonOk) {
                DialogResult = DialogResult.OK;
            } else if (btn == buttonCancel) {
                DialogResult = DialogResult.Cancel;
                return;
            }
            Close();
        }
    }
}
