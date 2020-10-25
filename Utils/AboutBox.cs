using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace KEUtils.About {
    public partial class AboutBox : Form {
        /// <summary>
        /// Brings up an AboutBox.
        /// </summary>
        /// </summary>
        /// <param name="title">Title of the form.</param>
        /// <param name="image">Image to use in the display. Suggested size is 256x256.</param>
        /// <param name="product">Name of the product.</param>
        /// <param name="version">The version.</param>
        /// <param name="copyright">The copyright notice.</param>
        /// <param name="company">The company name.</param>
        /// <param name="description">The description</param>
        public AboutBox(string title, Image image, string product, string version,
            string copyright, string company, string description) {
            InitializeComponent();
            this.Text = title;
            this.labelProductName.Text = product;
            this.labelVersion.Text = version;
            this.labelCopyright.Text = copyright;
            this.labelCompanyName.Text = company;
            this.textBoxDescription.Text = description;
            this.logoPictureBox.Image = image;
        }

        /// <summary>
        /// Brings up an AboutBox.
        /// </summary>
        /// <param name="title">Title of the form.</param>
        /// <param name="image">Image to use in the display. Suggested size is 256x256.</param>
        /// <param name="assembly">The Assembly from which to get information. 
        /// Typically Assembly.GetExecutingAssembly().</param>
        public AboutBox(string title, Image image, Assembly assembly) {
            InitializeComponent();
            this.Text = title;
            this.labelProductName.Text = getAssemblyProduct(assembly);
            this.labelVersion.Text = getAssemblyVersion(assembly);
            this.labelCopyright.Text = getAssemblyCopyright(assembly);
            this.labelCompanyName.Text = getAssemblyCompany(assembly);
            this.textBoxDescription.Text = getAssemblyDescription(assembly);
            this.logoPictureBox.Image = image;
        }

        #region Assembly methods

        /// <summary>
        /// Gets the tilte from the Assembly.
        /// </summary>
        /// <param name="assembly">The Assembly to use.</param>
        /// <returns>The title.</returns>
        public string getAssemblyTitle(Assembly assembly) {
            object[] attributes = assembly.
                GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            if (attributes.Length > 0) {
                AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                if (titleAttribute.Title != "") {
                    return titleAttribute.Title;
                }
            }
            return System.IO.Path.
                GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
        }

        /// <summary>
        /// Gets the title from the Assembly.
        /// </summary>
        /// <param name="assembly">The Assembly to use.</param>
        /// <returns>The title.</returns>
        public string getAssemblyVersion(Assembly assembly) {
            return assembly.GetName().Version.ToString();
        }

        /// <summary>
        /// Gets the description from the Assembly.
        /// </summary>
        /// <param name="assembly">The Assembly to use.</param>
        /// <returns>The description.</returns>
        public string getAssemblyDescription(Assembly assembly) {
            object[] attributes = assembly
                .GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
            if (attributes.Length == 0) {
                return "";
            }
            return ((AssemblyDescriptionAttribute)attributes[0]).Description;
        }

        /// <summary>
        /// Gets the product from the Assembly.
        /// </summary>
        /// <param name="assembly">The Assembly to use.</param>
        /// <returns>The product.</returns>
        public string getAssemblyProduct(Assembly assembly) {
            object[] attributes = assembly.
                GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            if (attributes.Length == 0) {
                return "";
            }
            return ((AssemblyProductAttribute)attributes[0]).Product;
        }

        /// <summary>
        /// Gets the copyright from the Assembly.
        /// </summary>
        /// <param name="assembly">The Assembly to use.</param>
        /// <returns>The copyright.</returns>
        public string getAssemblyCopyright(Assembly assembly) {
            object[] attributes = assembly.
                GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            if (attributes.Length == 0) {
                return "";
            }
            return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        }

        /// <summary>
        /// Gets the company from the Assembly.
        /// </summary>
        /// <param name="assembly">The Assembly to use.</param>
        /// <returns>The company.</returns>
        public string getAssemblyCompany(Assembly assembly) {
            object[] attributes = assembly.
                GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            if (attributes.Length == 0) {
                return "";
            }
            return ((AssemblyCompanyAttribute)attributes[0]).Company;
        }

        #endregion
    }
}
