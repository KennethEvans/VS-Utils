using KEUtils.Message;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KEUtils.Utils {
    public static class Utils {
        public static string NL = System.Environment.NewLine;

        /// <summary>
        /// Information message.
        /// </summary>
        /// <param name="msg"></param>
        public static void infoMsg(string msg) {
            MessageDialog.Show(msg, "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Warning message.
        /// </summary>
        /// <param name="msg"></param>
        public static void warnMsg(string msg) {
            MessageDialog.Show(msg, "Warning", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Error message.
        /// </summary>
        /// <param name="msg"></param>
        public static void errMsg(string msg) {
            MessageDialog.Show(msg, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// Exception message.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ex"></param>
        public static void excMsg(string msg, Exception ex) {
            MessageDialog.Show(msg += NL + NL + "Exception: " + ex + NL
            + ex.Message, "Exception", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// Exception message.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="ex"></param>
        public static DialogResult confirmMsg(string prompt) {
            DialogResult res = MessageDialog.Show(prompt, "Confirm", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            return res;
        }

        /// <summary>
        /// Gets an adjjusted width and height for the given width and height
        /// by multiplying them by the current DPI for the given form divided
        /// by 96, the standard DPI.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static Size getDpiAdjustedSize(Form form, Size size) {
            Graphics g = form.CreateGraphics();
            float dpiX = g.DpiX;
            float dpiY = g.DpiY;
            g.Dispose();
            return new Size((int)(dpiX * size.Width / 96F),
                (int)(dpiY * size.Height / 96F));
        }
    }
}
