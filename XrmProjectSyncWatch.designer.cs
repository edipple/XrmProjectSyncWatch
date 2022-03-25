
namespace XrmProjectSyncWatch
{
  partial class XrmProjectSyncWatch
  {
    /// <summary> 
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    /// <summary> 
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.toolStripMenu = new System.Windows.Forms.ToolStrip();
      this.tsbClose = new System.Windows.Forms.ToolStripButton();
      this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbLoadProjects = new System.Windows.Forms.ToolStripButton();
      this.splitContainerMain = new System.Windows.Forms.SplitContainer();
      this.lbProjects = new System.Windows.Forms.ListBox();
      this.toolStripMenu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
      this.splitContainerMain.Panel1.SuspendLayout();
      this.splitContainerMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStripMenu
      // 
      this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbLoadProjects});
      this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
      this.toolStripMenu.Name = "toolStripMenu";
      this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
      this.toolStripMenu.Size = new System.Drawing.Size(746, 31);
      this.toolStripMenu.TabIndex = 4;
      this.toolStripMenu.Text = "toolStrip1";
      // 
      // tsbClose
      // 
      this.tsbClose.Image = global::XrmProjectSyncWatch.Properties.Resources.Close_red_16x;
      this.tsbClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.tsbClose.Name = "tsbClose";
      this.tsbClose.Size = new System.Drawing.Size(73, 28);
      this.tsbClose.Text = "Close";
      this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
      // 
      // tssSeparator1
      // 
      this.tssSeparator1.Name = "tssSeparator1";
      this.tssSeparator1.Size = new System.Drawing.Size(6, 31);
      // 
      // tsbLoadProjects
      // 
      this.tsbLoadProjects.Image = global::XrmProjectSyncWatch.Properties.Resources.Open_16x;
      this.tsbLoadProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.tsbLoadProjects.Name = "tsbLoadProjects";
      this.tsbLoadProjects.Size = new System.Drawing.Size(70, 28);
      this.tsbLoadProjects.Text = "Load";
      this.tsbLoadProjects.Click += new System.EventHandler(this.tsbSample_Click);
      // 
      // splitContainerMain
      // 
      this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerMain.Location = new System.Drawing.Point(0, 31);
      this.splitContainerMain.Name = "splitContainerMain";
      // 
      // splitContainerMain.Panel1
      // 
      this.splitContainerMain.Panel1.Controls.Add(this.lbProjects);
      this.splitContainerMain.Size = new System.Drawing.Size(746, 339);
      this.splitContainerMain.SplitterDistance = 156;
      this.splitContainerMain.TabIndex = 5;
      // 
      // lbProjects
      // 
      this.lbProjects.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbProjects.FormattingEnabled = true;
      this.lbProjects.ItemHeight = 16;
      this.lbProjects.Location = new System.Drawing.Point(0, 0);
      this.lbProjects.Name = "lbProjects";
      this.lbProjects.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.lbProjects.Size = new System.Drawing.Size(156, 339);
      this.lbProjects.TabIndex = 0;
      // 
      // XrmProjectSyncWatch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainerMain);
      this.Controls.Add(this.toolStripMenu);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "XrmProjectSyncWatch";
      this.Size = new System.Drawing.Size(746, 370);
      this.Load += new System.EventHandler(this.MyPluginControl_Load);
      this.toolStripMenu.ResumeLayout(false);
      this.toolStripMenu.PerformLayout();
      this.splitContainerMain.Panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
      this.splitContainerMain.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ToolStrip toolStripMenu;
    private System.Windows.Forms.ToolStripButton tsbClose;
    private System.Windows.Forms.ToolStripButton tsbLoadProjects;
    private System.Windows.Forms.ToolStripSeparator tssSeparator1;
    private System.Windows.Forms.SplitContainer splitContainerMain;
    private System.Windows.Forms.ListBox lbProjects;
  }
}
