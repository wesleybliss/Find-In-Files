namespace FindInFiles {
    partial class SettingsForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.textSnippetSize = new FindInFiles.NumericTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkRememberLastQuery = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAndroidProjectsDir = new System.Windows.Forms.TextBox();
            this.buttonBrowsetextAndroidProjectsDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snippet Size (x2):";
            // 
            // textSnippetSize
            // 
            this.textSnippetSize.AllowSpace = false;
            this.textSnippetSize.Location = new System.Drawing.Point(138, 10);
            this.textSnippetSize.Name = "textSnippetSize";
            this.textSnippetSize.Size = new System.Drawing.Size(67, 22);
            this.textSnippetSize.TabIndex = 1;
            this.textSnippetSize.Text = "10";
            this.textSnippetSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(457, 333);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 28);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkRememberLastQuery
            // 
            this.checkRememberLastQuery.AutoSize = true;
            this.checkRememberLastQuery.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkRememberLastQuery.Checked = true;
            this.checkRememberLastQuery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRememberLastQuery.Location = new System.Drawing.Point(12, 47);
            this.checkRememberLastQuery.Name = "checkRememberLastQuery";
            this.checkRememberLastQuery.Size = new System.Drawing.Size(173, 21);
            this.checkRememberLastQuery.TabIndex = 4;
            this.checkRememberLastQuery.Text = "Remember last query?";
            this.checkRememberLastQuery.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Android projects directory:";
            // 
            // textAndroidProjectsDir
            // 
            this.textAndroidProjectsDir.Location = new System.Drawing.Point(16, 104);
            this.textAndroidProjectsDir.Name = "textAndroidProjectsDir";
            this.textAndroidProjectsDir.Size = new System.Drawing.Size(439, 22);
            this.textAndroidProjectsDir.TabIndex = 6;
            // 
            // buttonBrowsetextAndroidProjectsDir
            // 
            this.buttonBrowsetextAndroidProjectsDir.Location = new System.Drawing.Point(461, 103);
            this.buttonBrowsetextAndroidProjectsDir.Name = "buttonBrowsetextAndroidProjectsDir";
            this.buttonBrowsetextAndroidProjectsDir.Size = new System.Drawing.Size(81, 23);
            this.buttonBrowsetextAndroidProjectsDir.TabIndex = 7;
            this.buttonBrowsetextAndroidProjectsDir.Text = "Browse";
            this.buttonBrowsetextAndroidProjectsDir.UseVisualStyleBackColor = true;
            this.buttonBrowsetextAndroidProjectsDir.Click += new System.EventHandler(this.buttonBrowsetextAndroidProjectsDir_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 373);
            this.Controls.Add(this.buttonBrowsetextAndroidProjectsDir);
            this.Controls.Add(this.textAndroidProjectsDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkRememberLastQuery);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textSnippetSize);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "Find In Files - Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private NumericTextBox textSnippetSize;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkRememberLastQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAndroidProjectsDir;
        private System.Windows.Forms.Button buttonBrowsetextAndroidProjectsDir;
    }
}