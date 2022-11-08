using Microsoft.Deployment.WindowsInstaller;
using System;
using System.Windows.Forms;

namespace MyCustomAction
{
    public partial class LicenseInfoForm : Form
    {
        public LicenseInfoForm(Session session)
        {
            InitializeComponent();
            Application.EnableVisualStyles();
            TopMost = true;

            txtName.Text = session["LICENSE_NAME"];
            txtKey.Text = session["LICENSE_KEY"];
        }

        private void NextClick(object sender, EventArgs e)
        {
            bool valid = false;
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtKey.Text))
            {
                valid = VerifyLicenseInfo(txtName.Text, txtKey.Text);
            }

            if (!valid)
            {
                MessageBox.Show("You license information does not appear to be valid. Please try again.", "Invalid info");
            }
            else
            {
                this.DialogResult = DialogResult.Yes;
            }
        }

        private bool VerifyLicenseInfo(string registeredName, string key)
        {
            // Connect to License server or run algorithm check to 
            // verify license key.
            return true;
        }
    }
}
