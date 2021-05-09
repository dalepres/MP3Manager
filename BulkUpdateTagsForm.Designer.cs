namespace Preston.Media
{
    partial class BulkUpdateTagsForm
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
			this.lblSourceFolder = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnBrowseSource
			// 
			this.btnBrowseSource.Location = new System.Drawing.Point(318, 9);
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
			this.chkRecursive.Location = new System.Drawing.Point(12, 55);
			this.chkRecursive.Name = "chkRecursive";
			this.chkRecursive.Size = new System.Drawing.Size(74, 17);
			this.chkRecursive.TabIndex = 11;
			this.chkRecursive.Text = "Recursive";
			this.chkRecursive.UseVisualStyleBackColor = true;
			// 
			// btnExecute
			// 
			this.btnExecute.Location = new System.Drawing.Point(318, 51);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(75, 23);
			this.btnExecute.TabIndex = 12;
			this.btnExecute.Text = "Execute";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// lblSourceFolder
			// 
			this.lblSourceFolder.AutoSize = true;
			this.lblSourceFolder.Location = new System.Drawing.Point(9, 14);
			this.lblSourceFolder.Name = "lblSourceFolder";
			this.lblSourceFolder.Size = new System.Drawing.Size(124, 13);
			this.lblSourceFolder.TabIndex = 15;
			this.lblSourceFolder.Text = "Browse for source folder.";
			// 
			// BulkUpdateTagsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 118);
			this.Controls.Add(this.lblSourceFolder);
			this.Controls.Add(this.btnExecute);
			this.Controls.Add(this.chkRecursive);
			this.Controls.Add(this.btnBrowseSource);
			this.Name = "BulkUpdateTagsForm";
			this.Text = "BulkUpdateTagsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkRecursive;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblSourceFolder;

    }
}