namespace pwErrorBox
{
  partial class ErrorForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
      this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.chkIncludeScreenshot = new System.Windows.Forms.CheckBox();
      this.btnMail = new System.Windows.Forms.Button();
      this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
      this.TabControl1 = new System.Windows.Forms.TabControl();
      this.TabPageGeneral = new System.Windows.Forms.TabPage();
      this.txtOS = new System.Windows.Forms.TextBox();
      this.lblOS = new System.Windows.Forms.Label();
      this.txtExplaination = new System.Windows.Forms.TextBox();
      this.lblExplaination = new System.Windows.Forms.Label();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.lblMail = new System.Windows.Forms.Label();
      this.txtDate = new System.Windows.Forms.TextBox();
      this.lblDate = new System.Windows.Forms.Label();
      this.txtVersion = new System.Windows.Forms.TextBox();
      this.lblVersion = new System.Windows.Forms.Label();
      this.txtApplication = new System.Windows.Forms.TextBox();
      this.lblApplication = new System.Windows.Forms.Label();
      this.TabPageDetail = new System.Windows.Forms.TabPage();
      this.txtException = new System.Windows.Forms.TextBox();
      this.lblException = new System.Windows.Forms.Label();
      this.txtSource = new System.Windows.Forms.TextBox();
      this.lblSource = new System.Windows.Forms.Label();
      this.txtStackTrace = new System.Windows.Forms.TextBox();
      this.TabPageScreenshot = new System.Windows.Forms.TabPage();
      this.picScreenshot = new System.Windows.Forms.PictureBox();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.txtAssemblies = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.ContextMenuStripCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuTexte = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuScreenshot = new System.Windows.Forms.ToolStripMenuItem();
      this.btnClipboard = new System.Windows.Forms.Button();
      this.txtError = new System.Windows.Forms.TextBox();
      this.PictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnClose = new System.Windows.Forms.Button();
      this.TabControl1.SuspendLayout();
      this.TabPageGeneral.SuspendLayout();
      this.TabPageDetail.SuspendLayout();
      this.TabPageScreenshot.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).BeginInit();
      this.tabPage1.SuspendLayout();
      this.ContextMenuStripCopy.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // ToolTip1
      // 
      this.ToolTip1.ShowAlways = true;
      this.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.ToolTip1.ToolTipTitle = "Info";
      // 
      // chkIncludeScreenshot
      // 
      resources.ApplyResources(this.chkIncludeScreenshot, "chkIncludeScreenshot");
      this.chkIncludeScreenshot.Checked = true;
      this.chkIncludeScreenshot.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkIncludeScreenshot.Name = "chkIncludeScreenshot";
      this.HelpProvider1.SetShowHelp(this.chkIncludeScreenshot, ((bool)(resources.GetObject("chkIncludeScreenshot.ShowHelp"))));
      this.ToolTip1.SetToolTip(this.chkIncludeScreenshot, resources.GetString("chkIncludeScreenshot.ToolTip"));
      this.chkIncludeScreenshot.UseVisualStyleBackColor = true;
      // 
      // btnMail
      // 
      resources.ApplyResources(this.btnMail, "btnMail");
      this.btnMail.Name = "btnMail";
      this.HelpProvider1.SetShowHelp(this.btnMail, ((bool)(resources.GetObject("btnMail.ShowHelp"))));
      this.btnMail.UseVisualStyleBackColor = true;
      // 
      // TabControl1
      // 
      resources.ApplyResources(this.TabControl1, "TabControl1");
      this.TabControl1.Controls.Add(this.TabPageGeneral);
      this.TabControl1.Controls.Add(this.TabPageDetail);
      this.TabControl1.Controls.Add(this.TabPageScreenshot);
      this.TabControl1.Controls.Add(this.tabPage1);
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.HelpProvider1.SetShowHelp(this.TabControl1, ((bool)(resources.GetObject("TabControl1.ShowHelp"))));
      // 
      // TabPageGeneral
      // 
      this.TabPageGeneral.Controls.Add(this.txtOS);
      this.TabPageGeneral.Controls.Add(this.lblOS);
      this.TabPageGeneral.Controls.Add(this.txtExplaination);
      this.TabPageGeneral.Controls.Add(this.lblExplaination);
      this.TabPageGeneral.Controls.Add(this.txtEmail);
      this.TabPageGeneral.Controls.Add(this.lblMail);
      this.TabPageGeneral.Controls.Add(this.txtDate);
      this.TabPageGeneral.Controls.Add(this.lblDate);
      this.TabPageGeneral.Controls.Add(this.txtVersion);
      this.TabPageGeneral.Controls.Add(this.lblVersion);
      this.TabPageGeneral.Controls.Add(this.txtApplication);
      this.TabPageGeneral.Controls.Add(this.lblApplication);
      resources.ApplyResources(this.TabPageGeneral, "TabPageGeneral");
      this.TabPageGeneral.Name = "TabPageGeneral";
      this.HelpProvider1.SetShowHelp(this.TabPageGeneral, ((bool)(resources.GetObject("TabPageGeneral.ShowHelp"))));
      this.TabPageGeneral.UseVisualStyleBackColor = true;
      // 
      // txtOS
      // 
      resources.ApplyResources(this.txtOS, "txtOS");
      this.txtOS.Name = "txtOS";
      this.txtOS.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtOS, ((bool)(resources.GetObject("txtOS.ShowHelp"))));
      // 
      // lblOS
      // 
      resources.ApplyResources(this.lblOS, "lblOS");
      this.lblOS.Name = "lblOS";
      this.HelpProvider1.SetShowHelp(this.lblOS, ((bool)(resources.GetObject("lblOS.ShowHelp"))));
      // 
      // txtExplaination
      // 
      resources.ApplyResources(this.txtExplaination, "txtExplaination");
      this.txtExplaination.Name = "txtExplaination";
      this.HelpProvider1.SetShowHelp(this.txtExplaination, ((bool)(resources.GetObject("txtExplaination.ShowHelp"))));
      // 
      // lblExplaination
      // 
      resources.ApplyResources(this.lblExplaination, "lblExplaination");
      this.lblExplaination.Name = "lblExplaination";
      this.HelpProvider1.SetShowHelp(this.lblExplaination, ((bool)(resources.GetObject("lblExplaination.ShowHelp"))));
      // 
      // txtEmail
      // 
      resources.ApplyResources(this.txtEmail, "txtEmail");
      this.txtEmail.Name = "txtEmail";
      this.HelpProvider1.SetShowHelp(this.txtEmail, ((bool)(resources.GetObject("txtEmail.ShowHelp"))));
      // 
      // lblMail
      // 
      resources.ApplyResources(this.lblMail, "lblMail");
      this.lblMail.Name = "lblMail";
      this.HelpProvider1.SetShowHelp(this.lblMail, ((bool)(resources.GetObject("lblMail.ShowHelp"))));
      // 
      // txtDate
      // 
      resources.ApplyResources(this.txtDate, "txtDate");
      this.txtDate.Name = "txtDate";
      this.txtDate.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtDate, ((bool)(resources.GetObject("txtDate.ShowHelp"))));
      // 
      // lblDate
      // 
      resources.ApplyResources(this.lblDate, "lblDate");
      this.lblDate.Name = "lblDate";
      this.HelpProvider1.SetShowHelp(this.lblDate, ((bool)(resources.GetObject("lblDate.ShowHelp"))));
      // 
      // txtVersion
      // 
      resources.ApplyResources(this.txtVersion, "txtVersion");
      this.txtVersion.Name = "txtVersion";
      this.txtVersion.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtVersion, ((bool)(resources.GetObject("txtVersion.ShowHelp"))));
      // 
      // lblVersion
      // 
      resources.ApplyResources(this.lblVersion, "lblVersion");
      this.lblVersion.Name = "lblVersion";
      this.HelpProvider1.SetShowHelp(this.lblVersion, ((bool)(resources.GetObject("lblVersion.ShowHelp"))));
      // 
      // txtApplication
      // 
      resources.ApplyResources(this.txtApplication, "txtApplication");
      this.txtApplication.Name = "txtApplication";
      this.txtApplication.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtApplication, ((bool)(resources.GetObject("txtApplication.ShowHelp"))));
      // 
      // lblApplication
      // 
      resources.ApplyResources(this.lblApplication, "lblApplication");
      this.lblApplication.Name = "lblApplication";
      this.HelpProvider1.SetShowHelp(this.lblApplication, ((bool)(resources.GetObject("lblApplication.ShowHelp"))));
      // 
      // TabPageDetail
      // 
      this.TabPageDetail.Controls.Add(this.txtException);
      this.TabPageDetail.Controls.Add(this.lblException);
      this.TabPageDetail.Controls.Add(this.txtSource);
      this.TabPageDetail.Controls.Add(this.lblSource);
      this.TabPageDetail.Controls.Add(this.txtStackTrace);
      resources.ApplyResources(this.TabPageDetail, "TabPageDetail");
      this.TabPageDetail.Name = "TabPageDetail";
      this.HelpProvider1.SetShowHelp(this.TabPageDetail, ((bool)(resources.GetObject("TabPageDetail.ShowHelp"))));
      this.TabPageDetail.UseVisualStyleBackColor = true;
      // 
      // txtException
      // 
      resources.ApplyResources(this.txtException, "txtException");
      this.txtException.Name = "txtException";
      this.txtException.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtException, ((bool)(resources.GetObject("txtException.ShowHelp"))));
      // 
      // lblException
      // 
      resources.ApplyResources(this.lblException, "lblException");
      this.lblException.Name = "lblException";
      this.HelpProvider1.SetShowHelp(this.lblException, ((bool)(resources.GetObject("lblException.ShowHelp"))));
      // 
      // txtSource
      // 
      resources.ApplyResources(this.txtSource, "txtSource");
      this.txtSource.Name = "txtSource";
      this.txtSource.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtSource, ((bool)(resources.GetObject("txtSource.ShowHelp"))));
      // 
      // lblSource
      // 
      resources.ApplyResources(this.lblSource, "lblSource");
      this.lblSource.Name = "lblSource";
      this.HelpProvider1.SetShowHelp(this.lblSource, ((bool)(resources.GetObject("lblSource.ShowHelp"))));
      // 
      // txtStackTrace
      // 
      resources.ApplyResources(this.txtStackTrace, "txtStackTrace");
      this.txtStackTrace.BackColor = System.Drawing.SystemColors.Window;
      this.txtStackTrace.Name = "txtStackTrace";
      this.txtStackTrace.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtStackTrace, ((bool)(resources.GetObject("txtStackTrace.ShowHelp"))));
      // 
      // TabPageScreenshot
      // 
      this.TabPageScreenshot.Controls.Add(this.chkIncludeScreenshot);
      this.TabPageScreenshot.Controls.Add(this.picScreenshot);
      resources.ApplyResources(this.TabPageScreenshot, "TabPageScreenshot");
      this.TabPageScreenshot.Name = "TabPageScreenshot";
      this.HelpProvider1.SetShowHelp(this.TabPageScreenshot, ((bool)(resources.GetObject("TabPageScreenshot.ShowHelp"))));
      this.TabPageScreenshot.UseVisualStyleBackColor = true;
      // 
      // picScreenshot
      // 
      resources.ApplyResources(this.picScreenshot, "picScreenshot");
      this.picScreenshot.Name = "picScreenshot";
      this.HelpProvider1.SetShowHelp(this.picScreenshot, ((bool)(resources.GetObject("picScreenshot.ShowHelp"))));
      this.picScreenshot.TabStop = false;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.txtAssemblies);
      resources.ApplyResources(this.tabPage1, "tabPage1");
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // txtAssemblies
      // 
      resources.ApplyResources(this.txtAssemblies, "txtAssemblies");
      this.txtAssemblies.Name = "txtAssemblies";
      this.txtAssemblies.ReadOnly = true;
      // 
      // btnSave
      // 
      resources.ApplyResources(this.btnSave, "btnSave");
      this.btnSave.Name = "btnSave";
      this.HelpProvider1.SetShowHelp(this.btnSave, ((bool)(resources.GetObject("btnSave.ShowHelp"))));
      this.btnSave.UseVisualStyleBackColor = true;
      // 
      // ContextMenuStripCopy
      // 
      this.ContextMenuStripCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTexte,
            this.mnuScreenshot});
      this.ContextMenuStripCopy.Name = "ContextMenuStrip1";
      this.HelpProvider1.SetShowHelp(this.ContextMenuStripCopy, ((bool)(resources.GetObject("ContextMenuStripCopy.ShowHelp"))));
      resources.ApplyResources(this.ContextMenuStripCopy, "ContextMenuStripCopy");
      // 
      // mnuTexte
      // 
      this.mnuTexte.Name = "mnuTexte";
      resources.ApplyResources(this.mnuTexte, "mnuTexte");
      // 
      // mnuScreenshot
      // 
      this.mnuScreenshot.Name = "mnuScreenshot";
      resources.ApplyResources(this.mnuScreenshot, "mnuScreenshot");
      // 
      // btnClipboard
      // 
      resources.ApplyResources(this.btnClipboard, "btnClipboard");
      this.btnClipboard.ContextMenuStrip = this.ContextMenuStripCopy;
      this.btnClipboard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClipboard.Name = "btnClipboard";
      this.HelpProvider1.SetShowHelp(this.btnClipboard, ((bool)(resources.GetObject("btnClipboard.ShowHelp"))));
      this.btnClipboard.UseVisualStyleBackColor = true;
      // 
      // txtError
      // 
      resources.ApplyResources(this.txtError, "txtError");
      this.txtError.Name = "txtError";
      this.txtError.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtError, ((bool)(resources.GetObject("txtError.ShowHelp"))));
      // 
      // PictureBox1
      // 
      this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.PictureBox1, "PictureBox1");
      this.PictureBox1.Name = "PictureBox1";
      this.HelpProvider1.SetShowHelp(this.PictureBox1, ((bool)(resources.GetObject("PictureBox1.ShowHelp"))));
      this.PictureBox1.TabStop = false;
      // 
      // btnClose
      // 
      resources.ApplyResources(this.btnClose, "btnClose");
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Name = "btnClose";
      this.HelpProvider1.SetShowHelp(this.btnClose, ((bool)(resources.GetObject("btnClose.ShowHelp"))));
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // ErrorForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.CancelButton = this.btnClose;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.btnMail);
      this.Controls.Add(this.TabControl1);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnClipboard);
      this.Controls.Add(this.txtError);
      this.Controls.Add(this.PictureBox1);
      this.Controls.Add(this.btnClose);
      this.Name = "ErrorForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.TabControl1.ResumeLayout(false);
      this.TabPageGeneral.ResumeLayout(false);
      this.TabPageGeneral.PerformLayout();
      this.TabPageDetail.ResumeLayout(false);
      this.TabPageDetail.PerformLayout();
      this.TabPageScreenshot.ResumeLayout(false);
      this.TabPageScreenshot.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).EndInit();
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.ContextMenuStripCopy.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolTip ToolTip1;
    internal System.Windows.Forms.Button btnMail;
    internal System.Windows.Forms.HelpProvider HelpProvider1;
    internal System.Windows.Forms.TabControl TabControl1;
    internal System.Windows.Forms.TabPage TabPageGeneral;
    internal System.Windows.Forms.TextBox txtOS;
    internal System.Windows.Forms.Label lblOS;
    internal System.Windows.Forms.TextBox txtExplaination;
    internal System.Windows.Forms.Label lblExplaination;
    internal System.Windows.Forms.TextBox txtEmail;
    internal System.Windows.Forms.Label lblMail;
    internal System.Windows.Forms.TextBox txtDate;
    internal System.Windows.Forms.Label lblDate;
    internal System.Windows.Forms.TextBox txtVersion;
    internal System.Windows.Forms.Label lblVersion;
    internal System.Windows.Forms.TextBox txtApplication;
    internal System.Windows.Forms.Label lblApplication;
    internal System.Windows.Forms.TabPage TabPageDetail;
    internal System.Windows.Forms.TextBox txtException;
    internal System.Windows.Forms.Label lblException;
    internal System.Windows.Forms.TextBox txtSource;
    internal System.Windows.Forms.Label lblSource;
    private System.Windows.Forms.TextBox txtStackTrace;
    internal System.Windows.Forms.TabPage TabPageScreenshot;
    internal System.Windows.Forms.CheckBox chkIncludeScreenshot;
    internal System.Windows.Forms.PictureBox picScreenshot;
    internal System.Windows.Forms.Button btnSave;
    internal System.Windows.Forms.ContextMenuStrip ContextMenuStripCopy;
    internal System.Windows.Forms.ToolStripMenuItem mnuTexte;
    internal System.Windows.Forms.ToolStripMenuItem mnuScreenshot;
    internal System.Windows.Forms.Button btnClipboard;
    internal System.Windows.Forms.TextBox txtError;
    internal System.Windows.Forms.PictureBox PictureBox1;
    internal System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TextBox txtAssemblies;
  }
}