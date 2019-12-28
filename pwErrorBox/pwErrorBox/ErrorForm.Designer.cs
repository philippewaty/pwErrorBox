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
      this.chkIncludeScreenshot = new System.Windows.Forms.CheckBox();
      this.picScreenshot = new System.Windows.Forms.PictureBox();
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
      // btnMail
      // 
      this.btnMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnMail.Image = ((System.Drawing.Image)(resources.GetObject("btnMail.Image")));
      this.btnMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnMail.Location = new System.Drawing.Point(101, 375);
      this.btnMail.Name = "btnMail";
      this.HelpProvider1.SetShowHelp(this.btnMail, true);
      this.btnMail.Size = new System.Drawing.Size(88, 27);
      this.btnMail.TabIndex = 21;
      this.btnMail.Text = "&Mail";
      this.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnMail.UseVisualStyleBackColor = true;
      // 
      // TabControl1
      // 
      this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TabControl1.Controls.Add(this.TabPageGeneral);
      this.TabControl1.Controls.Add(this.TabPageDetail);
      this.TabControl1.Controls.Add(this.TabPageScreenshot);
      this.TabControl1.Location = new System.Drawing.Point(7, 82);
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.HelpProvider1.SetShowHelp(this.TabControl1, true);
      this.TabControl1.Size = new System.Drawing.Size(610, 287);
      this.TabControl1.TabIndex = 18;
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
      this.TabPageGeneral.Location = new System.Drawing.Point(4, 22);
      this.TabPageGeneral.Name = "TabPageGeneral";
      this.TabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
      this.HelpProvider1.SetShowHelp(this.TabPageGeneral, true);
      this.TabPageGeneral.Size = new System.Drawing.Size(602, 261);
      this.TabPageGeneral.TabIndex = 2;
      this.TabPageGeneral.Text = "General";
      this.TabPageGeneral.UseVisualStyleBackColor = true;
      // 
      // txtOS
      // 
      this.txtOS.Location = new System.Drawing.Point(71, 60);
      this.txtOS.Name = "txtOS";
      this.txtOS.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtOS, true);
      this.txtOS.Size = new System.Drawing.Size(461, 20);
      this.txtOS.TabIndex = 7;
      // 
      // lblOS
      // 
      this.lblOS.AutoSize = true;
      this.lblOS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOS.Location = new System.Drawing.Point(4, 60);
      this.lblOS.Name = "lblOS";
      this.HelpProvider1.SetShowHelp(this.lblOS, true);
      this.lblOS.Size = new System.Drawing.Size(22, 13);
      this.lblOS.TabIndex = 6;
      this.lblOS.Text = "OS";
      // 
      // txtExplaination
      // 
      this.txtExplaination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtExplaination.Location = new System.Drawing.Point(9, 125);
      this.txtExplaination.Multiline = true;
      this.txtExplaination.Name = "txtExplaination";
      this.txtExplaination.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.HelpProvider1.SetShowHelp(this.txtExplaination, true);
      this.txtExplaination.Size = new System.Drawing.Size(587, 130);
      this.txtExplaination.TabIndex = 11;
      // 
      // lblExplaination
      // 
      this.lblExplaination.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblExplaination.Location = new System.Drawing.Point(6, 109);
      this.lblExplaination.Name = "lblExplaination";
      this.HelpProvider1.SetShowHelp(this.lblExplaination, true);
      this.lblExplaination.Size = new System.Drawing.Size(100, 23);
      this.lblExplaination.TabIndex = 10;
      this.lblExplaination.Text = "Explaination to reproduce the error";
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(71, 86);
      this.txtEmail.Name = "txtEmail";
      this.HelpProvider1.SetShowHelp(this.txtEmail, true);
      this.txtEmail.Size = new System.Drawing.Size(461, 20);
      this.txtEmail.TabIndex = 9;
      // 
      // lblMail
      // 
      this.lblMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblMail.Location = new System.Drawing.Point(4, 86);
      this.lblMail.Name = "lblMail";
      this.HelpProvider1.SetShowHelp(this.lblMail, true);
      this.lblMail.Size = new System.Drawing.Size(100, 23);
      this.lblMail.TabIndex = 8;
      this.lblMail.Text = "Your email";
      // 
      // txtDate
      // 
      this.txtDate.Location = new System.Drawing.Point(410, 32);
      this.txtDate.Name = "txtDate";
      this.txtDate.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtDate, true);
      this.txtDate.Size = new System.Drawing.Size(122, 20);
      this.txtDate.TabIndex = 5;
      // 
      // lblDate
      // 
      this.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblDate.Location = new System.Drawing.Point(351, 32);
      this.lblDate.Name = "lblDate";
      this.HelpProvider1.SetShowHelp(this.lblDate, true);
      this.lblDate.Size = new System.Drawing.Size(100, 23);
      this.lblDate.TabIndex = 4;
      this.lblDate.Text = "Date";
      // 
      // txtVersion
      // 
      this.txtVersion.Location = new System.Drawing.Point(71, 32);
      this.txtVersion.Name = "txtVersion";
      this.txtVersion.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtVersion, true);
      this.txtVersion.Size = new System.Drawing.Size(274, 20);
      this.txtVersion.TabIndex = 3;
      // 
      // lblVersion
      // 
      this.lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblVersion.Location = new System.Drawing.Point(4, 32);
      this.lblVersion.Name = "lblVersion";
      this.HelpProvider1.SetShowHelp(this.lblVersion, true);
      this.lblVersion.Size = new System.Drawing.Size(100, 23);
      this.lblVersion.TabIndex = 2;
      this.lblVersion.Text = "Version";
      // 
      // txtApplication
      // 
      this.txtApplication.Location = new System.Drawing.Point(71, 6);
      this.txtApplication.Name = "txtApplication";
      this.txtApplication.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtApplication, true);
      this.txtApplication.Size = new System.Drawing.Size(461, 20);
      this.txtApplication.TabIndex = 1;
      // 
      // lblApplication
      // 
      this.lblApplication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblApplication.Location = new System.Drawing.Point(4, 6);
      this.lblApplication.Name = "lblApplication";
      this.HelpProvider1.SetShowHelp(this.lblApplication, true);
      this.lblApplication.Size = new System.Drawing.Size(100, 23);
      this.lblApplication.TabIndex = 0;
      this.lblApplication.Text = "Application";
      // 
      // TabPageDetail
      // 
      this.TabPageDetail.Controls.Add(this.txtException);
      this.TabPageDetail.Controls.Add(this.lblException);
      this.TabPageDetail.Controls.Add(this.txtSource);
      this.TabPageDetail.Controls.Add(this.lblSource);
      this.TabPageDetail.Controls.Add(this.txtStackTrace);
      this.TabPageDetail.Location = new System.Drawing.Point(4, 22);
      this.TabPageDetail.Name = "TabPageDetail";
      this.TabPageDetail.Padding = new System.Windows.Forms.Padding(3);
      this.HelpProvider1.SetShowHelp(this.TabPageDetail, true);
      this.TabPageDetail.Size = new System.Drawing.Size(602, 261);
      this.TabPageDetail.TabIndex = 0;
      this.TabPageDetail.Text = "Detail";
      this.TabPageDetail.UseVisualStyleBackColor = true;
      // 
      // txtException
      // 
      this.txtException.Location = new System.Drawing.Point(71, 32);
      this.txtException.Name = "txtException";
      this.txtException.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtException, true);
      this.txtException.Size = new System.Drawing.Size(274, 20);
      this.txtException.TabIndex = 3;
      // 
      // lblException
      // 
      this.lblException.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblException.Location = new System.Drawing.Point(4, 32);
      this.lblException.Name = "lblException";
      this.HelpProvider1.SetShowHelp(this.lblException, true);
      this.lblException.Size = new System.Drawing.Size(100, 23);
      this.lblException.TabIndex = 2;
      this.lblException.Text = "Exception";
      // 
      // txtSource
      // 
      this.txtSource.Location = new System.Drawing.Point(71, 6);
      this.txtSource.Name = "txtSource";
      this.txtSource.ReadOnly = true;
      this.HelpProvider1.SetShowHelp(this.txtSource, true);
      this.txtSource.Size = new System.Drawing.Size(274, 20);
      this.txtSource.TabIndex = 1;
      // 
      // lblSource
      // 
      this.lblSource.AutoSize = true;
      this.lblSource.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblSource.Location = new System.Drawing.Point(4, 6);
      this.lblSource.Name = "lblSource";
      this.HelpProvider1.SetShowHelp(this.lblSource, true);
      this.lblSource.Size = new System.Drawing.Size(41, 13);
      this.lblSource.TabIndex = 0;
      this.lblSource.Text = "Source";
      // 
      // txtStackTrace
      // 
      this.txtStackTrace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtStackTrace.BackColor = System.Drawing.SystemColors.Window;
      this.txtStackTrace.Font = new System.Drawing.Font("Courier New", 10.2F);
      this.txtStackTrace.Location = new System.Drawing.Point(3, 58);
      this.txtStackTrace.Multiline = true;
      this.txtStackTrace.Name = "txtStackTrace";
      this.txtStackTrace.ReadOnly = true;
      this.txtStackTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.HelpProvider1.SetShowHelp(this.txtStackTrace, true);
      this.txtStackTrace.Size = new System.Drawing.Size(596, 200);
      this.txtStackTrace.TabIndex = 4;
      // 
      // TabPageScreenshot
      // 
      this.TabPageScreenshot.Controls.Add(this.chkIncludeScreenshot);
      this.TabPageScreenshot.Controls.Add(this.picScreenshot);
      this.TabPageScreenshot.Location = new System.Drawing.Point(4, 22);
      this.TabPageScreenshot.Name = "TabPageScreenshot";
      this.TabPageScreenshot.Padding = new System.Windows.Forms.Padding(3);
      this.HelpProvider1.SetShowHelp(this.TabPageScreenshot, true);
      this.TabPageScreenshot.Size = new System.Drawing.Size(602, 261);
      this.TabPageScreenshot.TabIndex = 1;
      this.TabPageScreenshot.Text = "Screenshot";
      this.TabPageScreenshot.UseVisualStyleBackColor = true;
      // 
      // chkIncludeScreenshot
      // 
      this.chkIncludeScreenshot.AutoSize = true;
      this.chkIncludeScreenshot.Checked = true;
      this.chkIncludeScreenshot.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkIncludeScreenshot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkIncludeScreenshot.Location = new System.Drawing.Point(6, 6);
      this.chkIncludeScreenshot.Name = "chkIncludeScreenshot";
      this.HelpProvider1.SetShowHelp(this.chkIncludeScreenshot, true);
      this.chkIncludeScreenshot.Size = new System.Drawing.Size(154, 17);
      this.chkIncludeScreenshot.TabIndex = 2;
      this.chkIncludeScreenshot.Text = "Include screenshot in email";
      this.ToolTip1.SetToolTip(this.chkIncludeScreenshot, "Include screenshot in error report");
      this.chkIncludeScreenshot.UseVisualStyleBackColor = true;
      // 
      // picScreenshot
      // 
      this.picScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.picScreenshot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.picScreenshot.Location = new System.Drawing.Point(3, 29);
      this.picScreenshot.Name = "picScreenshot";
      this.HelpProvider1.SetShowHelp(this.picScreenshot, true);
      this.picScreenshot.Size = new System.Drawing.Size(596, 226);
      this.picScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.picScreenshot.TabIndex = 1;
      this.picScreenshot.TabStop = false;
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
      this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnSave.Location = new System.Drawing.Point(195, 375);
      this.btnSave.Name = "btnSave";
      this.HelpProvider1.SetShowHelp(this.btnSave, true);
      this.btnSave.Size = new System.Drawing.Size(88, 27);
      this.btnSave.TabIndex = 22;
      this.btnSave.Text = "&Save";
      this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSave.UseVisualStyleBackColor = true;
      // 
      // ContextMenuStripCopy
      // 
      this.ContextMenuStripCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTexte,
            this.mnuScreenshot});
      this.ContextMenuStripCopy.Name = "ContextMenuStrip1";
      this.HelpProvider1.SetShowHelp(this.ContextMenuStripCopy, true);
      this.ContextMenuStripCopy.Size = new System.Drawing.Size(159, 48);
      // 
      // mnuTexte
      // 
      this.mnuTexte.Name = "mnuTexte";
      this.mnuTexte.Size = new System.Drawing.Size(158, 22);
      this.mnuTexte.Text = "Texte";
      // 
      // mnuScreenshot
      // 
      this.mnuScreenshot.Name = "mnuScreenshot";
      this.mnuScreenshot.Size = new System.Drawing.Size(158, 22);
      this.mnuScreenshot.Text = "Capture d\'écran";
      // 
      // btnClipboard
      // 
      this.btnClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnClipboard.ContextMenuStrip = this.ContextMenuStripCopy;
      this.btnClipboard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClipboard.Image = ((System.Drawing.Image)(resources.GetObject("btnClipboard.Image")));
      this.btnClipboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnClipboard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnClipboard.Location = new System.Drawing.Point(7, 375);
      this.btnClipboard.Name = "btnClipboard";
      this.HelpProvider1.SetShowHelp(this.btnClipboard, true);
      this.btnClipboard.Size = new System.Drawing.Size(88, 27);
      this.btnClipboard.TabIndex = 20;
      this.btnClipboard.Text = "Co&py";
      this.btnClipboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnClipboard.UseVisualStyleBackColor = true;
      // 
      // txtError
      // 
      this.txtError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtError.Location = new System.Drawing.Point(65, 13);
      this.txtError.Multiline = true;
      this.txtError.Name = "txtError";
      this.txtError.ReadOnly = true;
      this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.HelpProvider1.SetShowHelp(this.txtError, true);
      this.txtError.Size = new System.Drawing.Size(545, 63);
      this.txtError.TabIndex = 19;
      // 
      // PictureBox1
      // 
      this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
      this.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.PictureBox1.Location = new System.Drawing.Point(11, 13);
      this.PictureBox1.Name = "PictureBox1";
      this.HelpProvider1.SetShowHelp(this.PictureBox1, true);
      this.PictureBox1.Size = new System.Drawing.Size(48, 48);
      this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.PictureBox1.TabIndex = 24;
      this.PictureBox1.TabStop = false;
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.AutoSize = true;
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
      this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnClose.Location = new System.Drawing.Point(508, 375);
      this.btnClose.Name = "btnClose";
      this.HelpProvider1.SetShowHelp(this.btnClose, true);
      this.btnClose.Size = new System.Drawing.Size(109, 27);
      this.btnClose.TabIndex = 23;
      this.btnClose.Text = "C&lose";
      this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // ErrorForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.CancelButton = this.btnClose;
      this.ClientSize = new System.Drawing.Size(624, 415);
      this.Controls.Add(this.btnMail);
      this.Controls.Add(this.TabControl1);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnClipboard);
      this.Controls.Add(this.txtError);
      this.Controls.Add(this.PictureBox1);
      this.Controls.Add(this.btnClose);
      this.Name = "ErrorForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "{0} has crashed";
      this.TabControl1.ResumeLayout(false);
      this.TabPageGeneral.ResumeLayout(false);
      this.TabPageGeneral.PerformLayout();
      this.TabPageDetail.ResumeLayout(false);
      this.TabPageDetail.PerformLayout();
      this.TabPageScreenshot.ResumeLayout(false);
      this.TabPageScreenshot.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).EndInit();
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
  }
}