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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textQuery = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.listMatches = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuListMatches = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuListMatchesOpenAS = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuListMatchesOpenSecondary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuListMatchesCopyFull = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuListMatchesCopyFilename = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.contextMenuListMatches.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listMatches);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(855, 724);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 28);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textQuery);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonRun);
            this.splitContainer2.Panel2.Controls.Add(this.textPath);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer2.Size = new System.Drawing.Size(855, 41);
            this.splitContainer2.SplitterDistance = 285;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // textQuery
            // 
            this.textQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuery.Location = new System.Drawing.Point(10, 10);
            this.textQuery.Margin = new System.Windows.Forms.Padding(4);
            this.textQuery.Name = "textQuery";
            this.textQuery.Size = new System.Drawing.Size(265, 22);
            this.textQuery.TabIndex = 0;
            this.textQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textQuery_KeyDown);
            // 
            // buttonRun
            // 
            this.buttonRun.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location = new System.Drawing.Point(480, 10);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 21);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Search";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textPath
            // 
            this.textPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.textPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPath.Location = new System.Drawing.Point(10, 10);
            this.textPath.Margin = new System.Windows.Forms.Padding(4);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(463, 22);
            this.textPath.TabIndex = 1;
            this.textPath.Text = "C:\\Users\\wes\\AndroidStudioProjects\\jackthreads-android\\src";
            // 
            // listMatches
            // 
            this.listMatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listMatches.ContextMenuStrip = this.contextMenuListMatches;
            this.listMatches.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listMatches.FullRowSelect = true;
            this.listMatches.GridLines = true;
            this.listMatches.HideSelection = false;
            this.listMatches.Location = new System.Drawing.Point(10, 2);
            this.listMatches.MultiSelect = false;
            this.listMatches.Name = "listMatches";
            this.listMatches.Size = new System.Drawing.Size(835, 638);
            this.listMatches.TabIndex = 1;
            this.listMatches.UseCompatibleStateImageBehavior = false;
            this.listMatches.View = System.Windows.Forms.View.Details;
            this.listMatches.DoubleClick += new System.EventHandler(this.listMatches_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 187;
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
            // contextMenuListMatches
            // 
            this.contextMenuListMatches.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuListMatches.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuListMatchesOpenAS,
            this.contextMenuListMatchesOpenSecondary,
            this.toolStripMenuItem1,
            this.contextMenuListMatchesCopyFull,
            this.contextMenuListMatchesCopyFilename});
            this.contextMenuListMatches.Name = "contextMenuListMatches";
            this.contextMenuListMatches.Size = new System.Drawing.Size(247, 106);
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
            // 
            // contextMenuListMatchesCopyFilename
            // 
            this.contextMenuListMatchesCopyFilename.Name = "contextMenuListMatchesCopyFilename";
            this.contextMenuListMatchesCopyFilename.Size = new System.Drawing.Size(246, 24);
            this.contextMenuListMatchesCopyFilename.Text = "Copy &File Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.menuFileSettings.Size = new System.Drawing.Size(175, 24);
            this.menuFileSettings.Text = "&Settings";
            this.menuFileSettings.Click += new System.EventHandler(this.menuFileSettings_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(175, 24);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 724);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Find In Files";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.contextMenuListMatches.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textQuery;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.ListView listMatches;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuListMatches;
        private System.Windows.Forms.ToolStripMenuItem contextMenuListMatchesOpenAS;
        private System.Windows.Forms.ToolStripMenuItem contextMenuListMatchesOpenSecondary;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuListMatchesCopyFull;
        private System.Windows.Forms.ToolStripMenuItem contextMenuListMatchesCopyFilename;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
    }
}

