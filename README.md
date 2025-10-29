# pwErrorBox
Advanced error messagebox that displays information about the error, making it easier to correct.

It displays informations about the program version, the OS, error details, a screenshot, and the list of assemblies.

<p align="center"><img align="center" src="./Screenshot.jpg?raw=true" alt="Screenshot"></p>

## Install

To install pwErrorBox (.NET Framework 4.5), run the following command in the Package Manager Console NuGet

PM> Install-Package pwErrorBox


https://www.nuget.org/packages/pwErrorBox/


## SAMPLE

``` csharp
const string EMAIL = "youremail@domain.com";

//Put the Bind call in "Program Main method"
[STAThread]
static void Main()
{
	pwErrorBox.ErrorReport.Bind(EMAIL);

    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run(new Form1());
}
```

Their are tho ways to call the ErrorBox
* Basic calling
``` csharp
throw new Exception("test error form");
```

* More informations to send to the ErrorBox
``` csharp
try
{
	throw new Exception("test error form");
}
catch (Exception ex)
{
	pwErrorBox.ErrorReport errorReport = new pwErrorBox.ErrorReport();
    errorReport.Source = "pwErrorBoxTest Form1 button2_Click";
    //errorReport.ToEmail = "your email"; //to bypass the Bind email setting
    errorReport.DisplayReport(ex, errorReport);
}
```
