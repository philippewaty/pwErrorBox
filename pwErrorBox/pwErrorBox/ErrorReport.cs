using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace pwErrorBox
{
    /// <summary>
    /// Prepare and display a error report to be displayed or to be sent by mail
    /// </summary>
    public class ErrorReport
    {
        /// <summary>
        /// Indicates if ErrorReport is already bound or not
        /// </summary>
        private static bool bound = false;

        /// <summary>
        /// Singleton object
        /// </summary>
        private static ErrorReport _Instance = null;

        /// <summary>
        /// Gets or sets exception that occured.
        /// </summary>
        public Exception Exception;

        /// <summary>
        /// Gets or sets the source method generating the exception
        /// </summary>
        public string Source;

        /// <summary>
        /// Gets or sets the current culture used to display messages.
        /// </summary>
        public CultureInfo CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

        /// <summary>
        /// Gets or sets email address to receive the error report. If empty, it takes the email address set at Bind() time.
        /// </summary>
        public string ToEmail = string.Empty;

        /// <summary>
        /// Creates an instance of this class if not already created.
        /// </summary>
        private static void MakeInstance()
        {
            if (_Instance == null)
            {
                _Instance = new ErrorReport();
            }
        }

        public void DisplayReport()
        {
            if (this.Exception != null)
            {
                DisplayReport(Exception);
            }

        }

        public void DisplayReport(Exception ex)
        {
            ErrorReport report = new ErrorReport();
            report.Exception = ex;
            ErrorForm errorBox = new ErrorForm(report, _Instance.ToEmail);
            errorBox.ShowDialog();
        }

        public void DisplayReport(Exception ex, ErrorReport report)
        {
            report.Exception = ex;
            if (string.IsNullOrEmpty(report.ToEmail))
            {
                report.ToEmail = _Instance.ToEmail;
            }
            ErrorForm errorBox = new ErrorForm(report, report.ToEmail);
            errorBox.ShowDialog();
        }

        /// <summary>
        /// Disposes application log FileStream and StreamWriter.
        /// </summary>
        public void Dispose()
        {
            AppDomain.CurrentDomain.UnhandledException -= CurrentDomain_UnhandledException;
        }

        public static void Bind(string email)
        {
            if (bound) return;
            bound = true;
            MakeInstance();
            _Instance.ToEmail = email;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            _Instance.DisplayReport(e.Exception);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            _Instance.DisplayReport((Exception)e.ExceptionObject);
        }
    }

}
