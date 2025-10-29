using System;
using System.Windows.Forms;

namespace pwErrorBoxTest
{
    public partial class Form1 : Form
    {

        const string EMAIL = "pwerrorbox.corrosive249@slmail.me";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new Exception("test error form");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("test error form");
            }
            catch (Exception ex)
            {
                pwErrorBox.ErrorReport errorReport = new pwErrorBox.ErrorReport();
                errorReport.Source = "pwErrorBoxTest Form1 button2_Click";
                //errorReport.ToEmail = EMAIL;
                errorReport.DisplayReport(ex, errorReport);
            }
        }
    }
}
