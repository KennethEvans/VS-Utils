using System;
using System.Drawing;
using System.Windows.Forms;

namespace KEUtils.ScrolledHTML {
    public partial class ScrolledHTMLDialog : Form {
        /// <summary>
        /// Brings up a dialog with the given HTML as scrollable.
        /// </summary>
        /// <param name="size">The Size of the dialog.</param>
        /// <param name="title">The title of the Form.</param>
        /// <param name="htmlFile">The HTML file to use.</param>
        public ScrolledHTMLDialog(Size size, string title, string htmlFile) {
            InitializeComponent();

            if (!String.IsNullOrEmpty(title)) {
                this.Text = title;
            }

            // Resize the Form
            this.Size = size;

            if (String.IsNullOrEmpty(htmlFile)) {
                Utils.Utils.errMsg("HTML file is invalid");
                return;
            }

            // Add the HTML
            string appDir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            webBrowser.Url = new Uri(System.IO.Path.Combine(appDir, htmlFile));

        }

        private void OnFormClosing(object sender, FormClosingEventArgs e) {
            // Just hide rather than close if the user did it
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Visible = false;
            }
        }

        private void OnButtonBackClick(object sender, EventArgs e) {
            webBrowser.GoBack();
        }

        private void OnButtonForwardClick(object sender, EventArgs e) {
            webBrowser.GoForward();
        }

        private void OnButtonCancelClick(object sender, EventArgs e) {
            this.Visible = false;
        }
    }
}
