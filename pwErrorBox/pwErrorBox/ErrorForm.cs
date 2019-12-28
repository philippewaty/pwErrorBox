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
#region Private declarations
    private static System.Reflection.Assembly _objParentAssembly = null;

    private static System.Drawing.Bitmap _screenshotPic;
    private ErrorReport _errorReport;
    private Exception _exception = null;

    private string _errorText = string.Empty;
#endregion
    private System.Resources.ResourceManager RM = new System.Resources.ResourceManager("pwErrorBox.ErrorForm", typeof(ErrorForm).Assembly);

    public ErrorForm()
    {
      InitializeComponent();
    }

    public ErrorForm(ErrorReport errorReport)
    {
      Thread.CurrentThread.CurrentUICulture = errorReport.CurrentCulture ?? Application.CurrentCulture;

      _errorReport = errorReport;
      _exception = _errorReport.Exception;
      txtError.Text = _exception.Message;
      txtError.SelectionStart = 0;
      txtError.SelectionLength = 0;
      txtStackTrace.Text = errorReport.Exception.StackTrace.ToString();
      txtApplication.Text = System.AppDomain.CurrentDomain.FriendlyName();
      txtVersion.Text = string.Format("{0} ({1})", ParentAssembly.GetName().Version().ToString, AssemblyBuildDate(ParentAssembly).ToString);
      txtDate.Text = DateTime.Now.ToString();
      txtOS.Text = Environment.OSVersion.VersionString;
      txtSource.Text = _errorReport.Source;
      txtException.Text = _exception.GetType().ToString();
      TakeScreenshotPrivate();
      if (!_screenshotPic == null)
      {
        picScreenshot.Image = _screenshotPic;
      }
      UpdateLanguage();

    }

    /// <summary>
    /// Met à jour les libellés en fonction de la langer
    /// </summary>
    private void UpdateLanguage()
    {
      this.Text = string.Format(RM.GetString("$this.Text"), txtApplication.Text);
      //lblErrorTitle.Text = "Une erreur est survenue"
      //TabPageDetail.Text = RM.GetString("TabPageDetail.Text")
      //TabPageScreenshot.Text = RM.GetString("TabPageScreenshot")
      //btnClipboard.Text = RM.GetString("btnCopy")
      //ToolTip1.SetToolTip(btnClipboard, RM.GetString("tooltipCopy"))
      //btnClose.Text = RM.GetString("btnClose")
      //ToolTip1.SetToolTip(btnClose, RM.GetString("tooltipClose"))
      //btnMail.Text = RM.GetString("btnMail")
      //ToolTip1.SetToolTip(btnMail, RM.GetString("tooltipMail"))
      //btnSave.Text = RM.GetString("btnSave")
      //ToolTip1.SetToolTip(btnSave, RM.GetString("tooltipSave"))
      //btnClose.Text = RM.GetString("btnClose")
      //ToolTip1.SetToolTip(btnClose, RM.GetString("tooltipClose"))

      //lblApplication.Text = RM.GetString("Application")
      //lblDate.Text = RM.GetString("Date")
      //lblException.Text = RM.GetString("Exception")
      //lblExplaination.Text = RM.GetString("Explaination")
      //lblMail.Text = RM.GetString("Email")
      //lblOS.Text = RM.GetString("OS")
      //lblSource.Text = RM.GetString("Source")
      //lblVersion.Text = RM.GetString("Version")
      //chkIncludeScreenshot.Text = RM.GetString("IncludeScreenshot")
    }

  }
}
