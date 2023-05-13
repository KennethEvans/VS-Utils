using System;
using System.Drawing;
using System.Windows.Forms;

namespace KEUtils.ScrolledHTML2 {
    public partial class ScrolledHTMLDialog2 : Form {
        /// <summary>
        /// Brings up a dialog with the given HTML as scrollable. It was
        /// designed to be used to show Help for an application, and by default
        /// (useAppDir=true) the html file is a path relative to the appDir.
        /// (For example @"Help\Overview.html")
        /// Otherwise it is a string representing a web address.
        /// </summary>
        /// <param name="size">The Size of the dialog.</param>
        /// <param name="title">The title of the Form.</param>
        /// <param name="htmlFile">The HTML file to use.</param>
        /// <param name="useAppDir">If true (default), the htmlfile is a filename
        /// relative to the app directory, othewise a valid web address</param>
        public ScrolledHTMLDialog2(Size size, string title, string htmlFile,
            bool useAppDir = true) {
            InitializeComponent();
            // This is not necessary if use webView2.Source =
            //InitializeAsync();

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
            try {
                if (useAppDir) {
                    string appDir = System.IO.Path.GetDirectoryName(
                        System.Reflection.Assembly.GetExecutingAssembly()
                        .GetName().CodeBase);
                    Uri uri = new Uri(System.IO.Path.Combine(appDir, htmlFile));
                    webView.Source = uri;
                } else {
                    Uri uri = new Uri(htmlFile);
                    webView.Source = uri;
                }
            } catch (Exception ex) {
                Utils.Utils.excMsg("Error creating WebView", ex);
                return;
            }
        }

        //async void InitializeAsync() {
        //    await webView.EnsureCoreWebView2Async(null);
        //}


        private void OnFormClosing(object sender, FormClosingEventArgs e) {
            // Just hide rather than close if the user did it
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Visible = false;
            }
        }

        private void OnButtonBackClick(object sender, EventArgs e) {
            webView.GoBack();
        }

        private void OnButtonForwardClick(object sender, EventArgs e) {
            webView.GoForward();
        }

        private void OnButtonCancelClick(object sender, EventArgs e) {
            this.Visible = false;
        }
    }
}
