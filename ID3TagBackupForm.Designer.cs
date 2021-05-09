namespace Preston.Media
{
    partial class ID3TagBackupForm
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
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkRecursive = new System.Windows.Forms.CheckBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblSourceFolder = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkRemoveTag = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(439, 17);
            this.btnBrowseSource.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSource.TabIndex = 10;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkRecursive
            // 
            this.chkRecursive.AutoSize = true;
            this.chkRecursive.Location = new System.Drawing.Point(6, 42);
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.Size = new System.Drawing.Size(112, 17);
            this.chkRecursive.TabIndex = 11;
            this.chkRecursive.Text = "Include subfolders";
            this.chkRecursive.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(391, 296);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 12;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(340, 147);
            this.listBox1.TabIndex = 13;
            // 
            // lblSourceFolder
            // 
            this.lblSourceFolder.Location = new System.Drawing.Point(6, 22);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(427, 13);
            this.lblSourceFolder.TabIndex = 15;
            this.lblSourceFolder.Text = "Browse for folder to backup tags.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRemoveTag);
            this.groupBox1.Controls.Add(this.lblSourceFolder);
            this.groupBox1.Controls.Add(this.btnBrowseSource);
            this.groupBox1.Controls.Add(this.chkRecursive);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 90);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag Backup Options";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(471, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 182);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // chkRemoveTag
            // 
            this.chkRemoveTag.AutoSize = true;
            this.chkRemoveTag.Location = new System.Drawing.Point(6, 66);
            this.chkRemoveTag.Name = "chkRemoveTag";
            this.chkRemoveTag.Size = new System.Drawing.Size(148, 17);
            this.chkRemoveTag.TabIndex = 16;
            this.chkRemoveTag.Text = "Remove tag from MP3 file";
            this.chkRemoveTag.UseVisualStyleBackColor = true;
            // 
            // ID3TagBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 327);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExecute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "ID3TagBackupForm";
            this.Text = "Backup Track Tags";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmbedPicturesForm_FormClosing);
            this.Load += new System.EventHandler(this.ID3TagBackupForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkRecursive;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblSourceFolder;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkRemoveTag;

    }
}