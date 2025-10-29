using System;
using System.Windows.Forms;

namespace pwErrorBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pwErrorBox.ErrorReport.Bind("pwerrorbox.corrosive249@slmail.me");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new Exception("test error form");
        }
    }
}
