using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DateClick(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.Start.ToString());
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Application.StartupPath + "\\Help.rtf");
            //Process.Start(Application.StartupPath + "\\ReadMe.txt");
        }

        private void MainLoad(object sender, EventArgs e)
        {
            Text = "Version " + Application.ProductVersion;
        }
    }
}
