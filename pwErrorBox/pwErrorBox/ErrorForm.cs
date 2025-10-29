using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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

        private string _ToEmail= string.Empty;
        #endregion
        private System.Resources.ResourceManager RM = new System.Resources.ResourceManager("pwErrorBox.ErrorForm", typeof(ErrorForm).Assembly);

        public ErrorForm()
        {
            InitializeComponent();
        }

        public ErrorForm(ErrorReport errorReport, string ToEmail)
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = errorReport.CurrentCulture ?? Application.CurrentCulture;

            _ToEmail = ToEmail;
            _errorReport = errorReport;
            _exception = _errorReport.Exception;
            txtError.Text = _exception?.Message;
            txtError.SelectionStart = 0;
            txtError.SelectionLength = 0;
            txtStackTrace.Text = errorReport.Exception.StackTrace.ToString();
            txtApplication.Text = System.AppDomain.CurrentDomain.FriendlyName;
            txtVersion.Text = string.Format("{0} ({1})", ParentAssembly().GetName().Version.ToString(), AssemblyBuildDate(ParentAssembly()).ToString());
            txtDate.Text = DateTime.Now.ToString();
            txtOS.Text = Environment.OSVersion.VersionString;
            txtSource.Text = _errorReport.Source;
            txtException.Text = _exception.GetType().ToString();
            TakeScreenshotPrivate();
            if (_screenshotPic != null)
            {
                picScreenshot.Image = _screenshotPic;
            }
            dgvAssemblies.Rows.Clear();
            foreach (AssemblyInfo value in GetAssemblies())
            {
                dgvAssemblies.Rows.Add(value.Name, value.ImageRuntimeVersion, value.Location);
            }
            UpdateLanguage();
        }

        private static System.Reflection.Assembly ParentAssembly()
        {
            if (_objParentAssembly == null)
            {
                if (System.Reflection.Assembly.GetEntryAssembly() == null)
                {
                    _objParentAssembly = System.Reflection.Assembly.GetCallingAssembly();
                }
                else
                {
                    _objParentAssembly = System.Reflection.Assembly.GetEntryAssembly();
                }
            }
            return _objParentAssembly;
        }


        /// <summary>
        /// filesystem create time is used, if revision and build were overridden by user
        /// </summary>
        /// <param name="objAssembly"></param>
        /// <param name="blnForceFileDate"></param>
        /// <returns>returns build datetime of assembly<br/>
        /// assumes default assembly value in AssemblyInfo:<br/>
        /// Assembly: AssemblyVersion("1.0.*") 
        /// </returns>
        /// <remarks></remarks>
        private static DateTime AssemblyBuildDate(System.Reflection.Assembly objAssembly, bool blnForceFileDate = false)
        {
            System.Version objVersion = objAssembly.GetName().Version;
            DateTime dtBuild;

            if (blnForceFileDate)
            {
                dtBuild = AssemblyFileTime(objAssembly);
            }
            else
            {
                dtBuild = new DateTime(2000, 1, 1).AddDays(objVersion.Build).AddSeconds(objVersion.Revision * 2);
                if (TimeZone.IsDaylightSavingTime(DateTime.Now, TimeZone.CurrentTimeZone.GetDaylightChanges(DateTime.Now.Year)))
                {
                    dtBuild = dtBuild.AddHours(1);
                }
                if (dtBuild > DateTime.Now | objVersion.Build < 730 | objVersion.Revision == 0)
                {
                    dtBuild = AssemblyFileTime(objAssembly);
                }
            }

            return dtBuild;
        }

        /// <summary>
        /// exception-safe file attrib retrieval; we don't care if this fails
        /// </summary>
        /// <param name="objAssembly"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        private static DateTime AssemblyFileTime(System.Reflection.Assembly objAssembly)
        {
            try
            {
                return System.IO.File.GetLastWriteTime(objAssembly.Location);
            }
            catch (Exception ex)
            {
                return DateTime.MaxValue;
            }
        }

        /// <summary>
        /// Renvoie la list des dépendances du programme.
        /// </summary>
        /// <returns></returns>
        private List<AssemblyInfo> GetAssemblies()
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            List<AssemblyInfo> result = new List<AssemblyInfo>();

            IComparer comparer = new SortComparer();

            Array.Sort(assemblies, comparer);
            foreach (Assembly assem in assemblies)
            {
                result.Add(new AssemblyInfo
                {
                    Name = assem.GetName().Name,
                    ImageRuntimeVersion = assem.ImageRuntimeVersion,
                    Location = assem.Location
                });
            }

            return result;
        }

        /// <summary>
        /// Takes a screenshot of the desktop and saves to filename and format specified
        /// </summary>
        /// <remarks></remarks>
        private static void TakeScreenshotPrivate()
        {
            Rectangle bounds;
            Graphics graph;
            bounds = Screen.PrimaryScreen.Bounds;
            _screenshotPic = new System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            graph = Graphics.FromImage(_screenshotPic);
            graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);

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

        private class SortComparer : IComparer
        {

            // Call CaseInsensitiveComparer.Compare with the parameters reversed.
            int IComparer.Compare(object x, object y)
            {
                return (new CaseInsensitiveComparer()).Compare((x as Assembly).GetName().Name, (y as Assembly).GetName().Name);
            }

        }

        private void mnuTexte_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                string message = GenerateErrorText();
                Clipboard.SetText(message, TextDataFormat.Text);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
            }

        }

        /// <summary>
        /// Generate the error text to copy to clipboard or save to file
        /// </summary>
        /// <returns></returns>
        string GenerateErrorText()
        {
            string message;

            message = "---- Error Report ----" + Environment.NewLine;
            message += $"Error: {txtError.Text}{Environment.NewLine}";
            message += Environment.NewLine;
            message += "---- General Information ----" + Environment.NewLine;
            message += $"Application: {txtApplication.Text}{Environment.NewLine}";
            message += $"Version: {txtVersion.Text}{Environment.NewLine}";
            message += $"Date: {txtDate.Text}{Environment.NewLine}";
            message += $"OS: {txtOS.Text}{Environment.NewLine}";
            message += $"Explaination: {Environment.NewLine}{txtExplaination.Text}{Environment.NewLine}";
            message += Environment.NewLine;
            message += "---- Exception Details ----" + Environment.NewLine;
            message += $"Source: {txtSource.Text}{Environment.NewLine}";
            message += $"Exception: {txtException.Text}{Environment.NewLine}";
            message += $"Error: {txtError.Text}{Environment.NewLine}";

            return message;
        }

        private void btnClipboard_MouseUp(object sender, MouseEventArgs e)
        {
            ContextMenuStripCopy.Show(btnClipboard, new Point(0, btnClipboard.Height));
        }

        private void mnuScreenshot_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetImage(_screenshotPic);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string screenshotFilename;
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                FileName = $"{Application.ProductName} {DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss")}.txt"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    SaveErrorText(saveFileDialog.FileName);
                    screenshotFilename = SaveScreenshot(saveFileDialog.FileName);

                    Process.Start("explorer.exe", "/select, \"" + saveFileDialog.FileName + "\"");

                    SendMail(saveFileDialog.FileName, screenshotFilename);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print(ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void SaveErrorText(string filename)
        {
            try
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filename, false, Encoding.UTF8))
                {
                    sw.WriteLine(GenerateErrorText());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string SaveScreenshot(string filename)
        {
            string screenshotFilename = filename;

            if (string.IsNullOrEmpty(screenshotFilename))
            {
                screenshotFilename = System.IO.Path.GetDirectoryName(System.IO.Path.GetTempFileName()) + "\\";
                screenshotFilename += string.Format("{0} {1}.txt", Application.ProductName, DateTime.Now.ToString("yyyyMMddHHmmss"));
            }

            screenshotFilename = System.IO.Path.ChangeExtension(screenshotFilename, ".jpg");
            picScreenshot.Image.Save(screenshotFilename, System.Drawing.Imaging.ImageFormat.Jpeg);

            return screenshotFilename;
        }

        /// <summary>
        /// Send the email with files attached
        /// </summary>
        /// <param name="textFilename"></param>
        /// <param name="pictureFilename"></param>
        private void SendMail(string textFilename, string pictureFilename)
        {

            MAPI mapi = new MAPI();
            mapi.AddRecipientTo(_ToEmail);

            if (File.Exists(textFilename))
            {
                mapi.AddAttachment(textFilename);
            }
            if (File.Exists(pictureFilename))
            {
                mapi.AddAttachment(pictureFilename);
            }
            mapi.SendMailPopup($"Error in {Application.ProductName}", GenerateErrorText());

        }
        private void btnMail_Click(object sender, EventArgs e)
        {
            string tempFileName;
            string screenshotFilename = string.Empty;

            tempFileName = Path.Combine(Path.GetTempPath(), $"{Application.ProductName} {DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss")}.txt");
            SaveErrorText(tempFileName);
            if (chkIncludeScreenshot.Checked)
            {
                screenshotFilename = SaveScreenshot(tempFileName);
            }

            SendMail(tempFileName, screenshotFilename);
        }
    }
}
