using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwErrorBox
{
  public partial class ErrorForm : Form
  {
    public ErrorForm()
    {
      InitializeComponent();
    }

    public ErrorForm(ErrorReport errorReport)
    {
      Thread.CurrentThread.CurrentUICulture = errorReport.CurrentCulture ?? Application.CurrentCulture;
    }
  }
}
