namespace VP_Unpack
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.file_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.file_Open_PKG = new System.Windows.Forms.ToolStripMenuItem();
            this.file_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.file_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unpackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpOffsetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.outputConsole = new System.Windows.Forms.TextBox();
            this.consoleSC = new System.Windows.Forms.SplitContainer();
            this.mainSC = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogOnNewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePathToolStrip = new System.Windows.Forms.ToolStrip();
            this.filePathLabel = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consoleSC)).BeginInit();
            this.consoleSC.Panel1.SuspendLayout();
            this.consoleSC.Panel2.SuspendLayout();
            this.consoleSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSC)).BeginInit();
            this.mainSC.Panel1.SuspendLayout();
            this.mainSC.SuspendLayout();
            this.filePathToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_File,
            this.viewToolStripMenuItem,
            this.menuItem_Tools,
            this.menuItem_Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(679, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuItem_File
            // 
            this.menuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_Open,
            this.file_Settings,
            this.file_Exit});
            this.menuItem_File.Name = "menuItem_File";
            this.menuItem_File.Size = new System.Drawing.Size(46, 24);
            this.menuItem_File.Text = "File";
            // 
            // file_Open
            // 
            this.file_Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_Open_PKG});
            this.file_Open.Name = "file_Open";
            this.file_Open.Size = new System.Drawing.Size(224, 26);
            this.file_Open.Text = "Open";
            // 
            // file_Open_PKG
            // 
            this.file_Open_PKG.Name = "file_Open_PKG";
            this.file_Open_PKG.Size = new System.Drawing.Size(224, 26);
            this.file_Open_PKG.Text = ".PKG";
            this.file_Open_PKG.Click += new System.EventHandler(this.OpenPKG);
            // 
            // file_Settings
            // 
            this.file_Settings.Name = "file_Settings";
            this.file_Settings.Size = new System.Drawing.Size(224, 26);
            this.file_Settings.Text = "Settings";
            this.file_Settings.Click += new System.EventHandler(this.OpenSettingsForm);
            // 
            // file_Exit
            // 
            this.file_Exit.Name = "file_Exit";
            this.file_Exit.Size = new System.Drawing.Size(224, 26);
            this.file_Exit.Text = "Exit";
            this.file_Exit.Click += new System.EventHandler(this.ExitProgram);
            // 
            // menuItem_Tools
            // 
            this.menuItem_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuItem_Tools.Name = "menuItem_Tools";
            this.menuItem_Tools.Size = new System.Drawing.Size(58, 24);
            this.menuItem_Tools.Text = "Tools";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unpackToolStripMenuItem,
            this.packToolStripMenuItem,
            this.dumpOffsetsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = ".pkg";
            // 
            // unpackToolStripMenuItem
            // 
            this.unpackToolStripMenuItem.Name = "unpackToolStripMenuItem";
            this.unpackToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.unpackToolStripMenuItem.Text = "Unpack";
            this.unpackToolStripMenuItem.Click += new System.EventHandler(this.unpackToolStripMenuItem_Click);
            // 
            // packToolStripMenuItem
            // 
            this.packToolStripMenuItem.Name = "packToolStripMenuItem";
            this.packToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.packToolStripMenuItem.Text = "Pack";
            // 
            // dumpOffsetsToolStripMenuItem
            // 
            this.dumpOffsetsToolStripMenuItem.Name = "dumpOffsetsToolStripMenuItem";
            this.dumpOffsetsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dumpOffsetsToolStripMenuItem.Text = "Dump Offsets";
            this.dumpOffsetsToolStripMenuItem.Click += new System.EventHandler(this.dumpOffsetsToolStripMenuItem_Click);
            // 
            // menuItem_Help
            // 
            this.menuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_About});
            this.menuItem_Help.Name = "menuItem_Help";
            this.menuItem_Help.Size = new System.Drawing.Size(55, 24);
            this.menuItem_Help.Text = "Help";
            // 
            // help_About
            // 
            this.help_About.Name = "help_About";
            this.help_About.Size = new System.Drawing.Size(207, 26);
            this.help_About.Text = "About VP Unpack";
            // 
            // outputConsole
            // 
            this.outputConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputConsole.Location = new System.Drawing.Point(-1, 0);
            this.outputConsole.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.outputConsole.Multiline = true;
            this.outputConsole.Name = "outputConsole";
            this.outputConsole.ReadOnly = true;
            this.outputConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputConsole.Size = new System.Drawing.Size(661, 56);
            this.outputConsole.TabIndex = 3;
            // 
            // consoleSC
            // 
            this.consoleSC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleSC.Location = new System.Drawing.Point(9, 33);
            this.consoleSC.Margin = new System.Windows.Forms.Padding(0);
            this.consoleSC.Name = "consoleSC";
            this.consoleSC.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // consoleSC.Panel1
            // 
            this.consoleSC.Panel1.Controls.Add(this.mainSC);
            // 
            // consoleSC.Panel2
            // 
            this.consoleSC.Panel2.Controls.Add(this.outputConsole);
            this.consoleSC.Size = new System.Drawing.Size(661, 419);
            this.consoleSC.SplitterDistance = 344;
            this.consoleSC.SplitterWidth = 2;
            this.consoleSC.TabIndex = 4;
            // 
            // mainSC
            // 
            this.mainSC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSC.Location = new System.Drawing.Point(-1, -1);
            this.mainSC.Name = "mainSC";
            // 
            // mainSC.Panel1
            // 
            this.mainSC.Panel1.Controls.Add(this.treeView);
            this.mainSC.Size = new System.Drawing.Size(661, 343);
            this.mainSC.SplitterDistance = 218;
            this.mainSC.SplitterWidth = 2;
            this.mainSC.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(216, 341);
            this.treeView.TabIndex = 1;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewSelection);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loggingToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // loggingToolStripMenuItem
            // 
            this.loggingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogOnNewFileToolStripMenuItem});
            this.loggingToolStripMenuItem.Name = "loggingToolStripMenuItem";
            this.loggingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loggingToolStripMenuItem.Text = "Logging";
            // 
            // clearLogOnNewFileToolStripMenuItem
            // 
            this.clearLogOnNewFileToolStripMenuItem.Name = "clearLogOnNewFileToolStripMenuItem";
            this.clearLogOnNewFileToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.clearLogOnNewFileToolStripMenuItem.Text = "Clear log on new file";
            this.clearLogOnNewFileToolStripMenuItem.Click += new System.EventHandler(this.ClearLogCheck);
            // 
            // filePathToolStrip
            // 
            this.filePathToolStrip.AllowMerge = false;
            this.filePathToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathToolStrip.AutoSize = false;
            this.filePathToolStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.filePathToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.filePathToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.filePathToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.filePathToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.filePathToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filePathLabel});
            this.filePathToolStrip.Location = new System.Drawing.Point(9, 436);
            this.filePathToolStrip.Name = "filePathToolStrip";
            this.filePathToolStrip.Size = new System.Drawing.Size(661, 25);
            this.filePathToolStrip.TabIndex = 5;
            // 
            // filePathLabel
            // 
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(679, 461);
            this.Controls.Add(this.filePathToolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.consoleSC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.consoleSC.Panel1.ResumeLayout(false);
            this.consoleSC.Panel2.ResumeLayout(false);
            this.consoleSC.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consoleSC)).EndInit();
            this.consoleSC.ResumeLayout(false);
            this.mainSC.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSC)).EndInit();
            this.mainSC.ResumeLayout(false);
            this.filePathToolStrip.ResumeLayout(false);
            this.filePathToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItem_File;
        private System.Windows.Forms.ToolStripMenuItem file_Settings;
        private System.Windows.Forms.ToolStripMenuItem file_Open;
        private System.Windows.Forms.ToolStripMenuItem file_Open_PKG;
        private System.Windows.Forms.ToolStripMenuItem file_Exit;
        private System.Windows.Forms.SplitContainer consoleSC;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem help_About;
        private System.Windows.Forms.SplitContainer mainSC;
        public System.Windows.Forms.TextBox outputConsole;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Tools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unpackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpOffsetsToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogOnNewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip filePathToolStrip;
        private System.Windows.Forms.ToolStripLabel filePathLabel;
    }
}