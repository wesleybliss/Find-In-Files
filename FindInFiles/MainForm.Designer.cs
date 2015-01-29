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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBody = new System.Windows.Forms.Panel();
            this.listMatches = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.textQuery = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.contextMenuListMatches.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.tableLayoutMain.SuspendLayout();
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
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(855, 28);
            this.menuMain.TabIndex = 6;
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
            this.menuFileSettings.Click += new System.EventHandler(this.menuFileSettings_Click);
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
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.listMatches);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 108);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panelBody.Size = new System.Drawing.Size(855, 616);
            this.panelBody.TabIndex = 7;
            // 
            // listMatches
            // 
            this.listMatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listMatches.ContextMenuStrip = this.contextMenuListMatches;
            this.listMatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMatches.FullRowSelect = true;
            this.listMatches.GridLines = true;
            this.listMatches.HideSelection = false;
            this.listMatches.Location = new System.Drawing.Point(10, 0);
            this.listMatches.MultiSelect = false;
            this.listMatches.Name = "listMatches";
            this.listMatches.Size = new System.Drawing.Size(835, 606);
            this.listMatches.TabIndex = 3;
            this.listMatches.UseCompatibleStateImageBehavior = false;
            this.listMatches.View = System.Windows.Forms.View.Details;
            this.listMatches.DoubleClick += new System.EventHandler(this.listMatches_DoubleClick);
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
            // tableLayoutMain
            // 
            this.tableLayoutMain.AutoSize = true;
            this.tableLayoutMain.ColumnCount = 3;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.59016F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.38642F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.02342F));
            this.tableLayoutMain.Controls.Add(this.buttonRun, 0, 0);
            this.tableLayoutMain.Controls.Add(this.textPath, 0, 0);
            this.tableLayoutMain.Controls.Add(this.textQuery, 0, 0);
            this.tableLayoutMain.Controls.Add(this.labelStatus, 0, 1);
            this.tableLayoutMain.Controls.Add(this.labelCurrentOperation, 1, 1);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 2;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutMain.Size = new System.Drawing.Size(855, 80);
            this.tableLayoutMain.TabIndex = 9;
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location = new System.Drawing.Point(693, 10);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(152, 28);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Search";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textPath
            // 
            this.textPath.AcceptsReturn = true;
            this.textPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPath.HideSelection = false;
            this.textPath.Location = new System.Drawing.Point(220, 10);
            this.textPath.Margin = new System.Windows.Forms.Padding(10);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(453, 27);
            this.textPath.TabIndex = 2;
            this.textPath.Text = "C:\\Users\\wes\\AndroidStudioProjects\\jackthreads-android\\src";
            // 
            // textQuery
            // 
            this.textQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuery.Location = new System.Drawing.Point(10, 10);
            this.textQuery.Margin = new System.Windows.Forms.Padding(10);
            this.textQuery.Name = "textQuery";
            this.textQuery.Size = new System.Drawing.Size(190, 27);
            this.textQuery.TabIndex = 1;
            this.textQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textQuery_KeyDown);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Location = new System.Drawing.Point(7, 48);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelStatus.Size = new System.Drawing.Size(200, 32);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Ready";
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Location = new System.Drawing.Point(217, 48);
            this.labelCurrentOperation.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelCurrentOperation.Size = new System.Drawing.Size(463, 32);
            this.labelCurrentOperation.TabIndex = 5;
            // 
            // backgroundWorkerSearch
            // 
            this.backgroundWorkerSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSearch_DoWork);
            this.backgroundWorkerSearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSearch_ProgressChanged);
            this.backgroundWorkerSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSearch_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(855, 724);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.tableLayoutMain);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Find In Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuListMatches.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMain.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.ListView listMatches;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.TextBox textQuery;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
    }
}

