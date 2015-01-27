namespace FindInFiles {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.contextMenuListMatches = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuListMatchesOpenAS = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuListMatchesOpenSecondary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuListMatchesCopyFull = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuListMatchesCopyFilename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuListMatchesExcludeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuListMatchesShowOnlyFile = new System.Windows.Forms.ToolStripMenuItem();
            this.listMatches = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.textQuery = new System.Windows.Forms.TextBox();
            this.contextMenuListMatches.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuListMatches
            // 
            this.contextMenuListMatches.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuListMatches.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuListMatchesOpenAS,
            this.contextMenuListMatchesOpenSecondary,
            this.toolStripMenuItem1,
            this.contextMenuListMatchesCopyFull,
            this.contextMenuListMatchesCopyFilename,
            this.toolStripMenuItem3,
            this.contextMenuListMatchesExcludeFile,
            this.contextMenuListMatchesShowOnlyFile});
            this.contextMenuListMatches.Name = "contextMenuListMatches";
            this.contextMenuListMatches.Size = new System.Drawing.Size(247, 160);
            // 
            // contextMenuListMatchesOpenAS
            // 
            this.contextMenuListMatchesOpenAS.Name = "contextMenuListMatchesOpenAS";
            this.contextMenuListMatchesOpenAS.Size = new System.Drawing.Size(246, 24);
            this.contextMenuListMatchesOpenAS.Text = "&Open in Android Studio";
            // 
            // contextMenuListMatchesOpenSecondary
            // 
            this.contextMenuListMatchesOpenSecondary.Name = "contextMenuListMatchesOpenSecondary";
            this.contextMenuListMatchesOpenSecondary.Size = new System.Drawing.Size(246, 24);
            this.contextMenuListMatchesOpenSecondary.Text = "Open in &Secondary Editor";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(243, 6);
            // 
            // contextMenuListMatchesCopyFull
            // 
            this.contextMenuListMatchesCopyFull.Name = "contextMenuListMatchesCopyFull";
            this.contextMenuListMatchesCopyFull.Size = new System.Drawing.Size(246, 24);
            this.contextMenuListMatchesCopyFull.Text = "&Copy Full Path";
            this.contextMenuListMatchesCopyFull.Click += new System.EventHandler(this.contextMenuListMatchesCopyFull_Click);
            // 
            // contextMenuListMatchesCopyFilename
            // 
            this.contextMenuListMatchesCopyFilename.Name = "contextMenuListMatchesCopyFilename";
            this.contextMenuListMatchesCopyFilename.Size = new System.Drawing.Size(246, 24);
            this.contextMenuListMatchesCopyFilename.Text = "Copy &File Name";
            this.contextMenuListMatchesCopyFilename.Click += new System.EventHandler(this.contextMenuListMatchesCopyFilename_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(243, 6);
            // 
            // contextMenuListMatchesExcludeFile
            // 
            this.contextMenuListMatchesExcludeFile.Name = "contextMenuListMatchesExcludeFile";
            this.contextMenuListMatchesExcludeFile.Size = new System.Drawing.Size(246, 24);
            this.contextMenuListMatchesExcludeFile.Text = "E&xclude This File";
            this.contextMenuListMatchesExcludeFile.Click += new System.EventHandler(this.contextMenuListMatchesExcludeFile_Click);
            // 
            // contextMenuListMatchesShowOnlyFile
            // 
            this.contextMenuListMatchesShowOnlyFile.Name = "contextMenuListMatchesShowOnlyFile";
            this.contextMenuListMatchesShowOnlyFile.Size = new System.Drawing.Size(246, 24);
            this.contextMenuListMatchesShowOnlyFile.Text = "&Show Only This File";
            // 
            // listMatches
            // 
            this.listMatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listMatches.ContextMenuStrip = this.contextMenuListMatches;
            this.listMatches.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMatches.FullRowSelect = true;
            this.listMatches.GridLines = true;
            this.listMatches.HideSelection = false;
            this.listMatches.Location = new System.Drawing.Point(0, 65);
            this.listMatches.MultiSelect = false;
            this.listMatches.Name = "listMatches";
            this.listMatches.Size = new System.Drawing.Size(855, 659);
            this.listMatches.TabIndex = 2;
            this.listMatches.UseCompatibleStateImageBehavior = false;
            this.listMatches.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 261;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Line";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sample";
            this.columnHeader3.Width = 573;
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(855, 28);
            this.menuMain.TabIndex = 4;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileSettings,
            this.toolStripMenuItem2,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(42, 24);
            this.menuFile.Text = "&File";
            // 
            // menuFileSettings
            // 
            this.menuFileSettings.Name = "menuFileSettings";
            this.menuFileSettings.Size = new System.Drawing.Size(130, 24);
            this.menuFileSettings.Text = "&Settings";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(130, 24);
            this.menuFileExit.Text = "E&xit";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.buttonRun);
            this.panelHeader.Controls.Add(this.textPath);
            this.panelHeader.Controls.Add(this.textQuery);
            this.panelHeader.Location = new System.Drawing.Point(0, 31);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(855, 29);
            this.panelHeader.TabIndex = 5;
            // 
            // buttonRun
            // 
            this.buttonRun.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location = new System.Drawing.Point(731, 0);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(124, 29);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Search";
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // textPath
            // 
            this.textPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.textPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPath.Location = new System.Drawing.Point(218, 0);
            this.textPath.Margin = new System.Windows.Forms.Padding(4);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(485, 27);
            this.textPath.TabIndex = 2;
            this.textPath.Text = "C:\\Users\\wes\\AndroidStudioProjects\\jackthreads-android\\src";
            // 
            // textQuery
            // 
            this.textQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.textQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuery.Location = new System.Drawing.Point(0, 0);
            this.textQuery.Margin = new System.Windows.Forms.Padding(4);
            this.textQuery.Name = "textQuery";
            this.textQuery.Size = new System.Drawing.Size(218, 27);
            this.textQuery.TabIndex = 1;
            this.textQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textQuery_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 724);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.listMatches);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Find In Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuListMatches.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuListMatches;
        private System.Windows.Forms.ToolStripMenuItem contextMenuListMatchesOpenAS;
        private System.Windows.Forms.ToolStripMenuItem contextMenuListMatchesOpenSecondary;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuListMatchesCopyFull;
        private System.Windows.Forms.ToolStripMenuItem contextMenuListMatchesCopyFilename;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem contextMenuListMatchesExcludeFile;
        private System.Windows.Forms.ToolStripMenuItem contextMenuListMatchesShowOnlyFile;
        private System.Windows.Forms.ListView listMatches;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.TextBox textQuery;
    }
}

