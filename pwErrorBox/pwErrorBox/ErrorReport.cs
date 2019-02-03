using System;
using System.Globalization;

namespace pwErrorBox
{
  /// <summary>
  /// Prepare and display a error report to be displayed or to be sent by mail
  /// </summary>
  public class ErrorReport
  {

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
    /// Gets or sets name or IP address of the SMTP Host.
    /// </summary>

    public string SmtpHost;
    /// <summary>
    /// Gets or sets if the SMTP uses SSL.
    /// </summary>

    public bool EnableSSL;
    /// <summary>
    /// Gets or sets the port used for SMTP.
    /// </summary>

    public int Port = 25;
    /// <summary>
    /// Gets or sets the username used for SMTP.
    /// </summary>

    public string UserName = "";
    /// <summary>
    /// Gets or sets the password used for SMTP. 
    /// </summary>

    public string Password = "";
    /// <summary>
    /// Gets or sets email address to receive the error report.
    /// </summary>

    public string ToEmail;
    /// <summary>
    /// Gets or sets email address of the error report sender.
    /// </summary>

    public string FromEmail;

    public void DisplayReport()
    {
      if (this.Exception != null)
      {
        DisplayReport(Exception);
      }

    }

    public void DisplayReport(Exception ex)
    {
      ErrorForm errorBox = new ErrorForm(this);
      errorBox.ShowDialog();
    }

  }

}
