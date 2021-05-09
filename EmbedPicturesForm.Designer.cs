namespace Preston.Media
{
    partial class EmbedPicturesForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSourceFolder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbPictureTypes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.chkRecursive.Location = new System.Drawing.Point(404, 101);
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.Size = new System.Drawing.Size(112, 17);
            this.chkRecursive.TabIndex = 11;
            this.chkRecursive.Text = "Include subfolders";
            this.chkRecursive.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(389, 338);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(367, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblSourceFolder
            // 
            this.lblSourceFolder.Location = new System.Drawing.Point(6, 22);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(427, 13);
            this.lblSourceFolder.TabIndex = 15;
            this.lblSourceFolder.Text = "Browse for source folder.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Description (64 char max):";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(144, 72);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(372, 20);
            this.txtDescription.TabIndex = 18;
            this.txtDescription.Text = "Dale\'s Scanned CD Cover";
            // 
            // cbPictureTypes
            // 
            this.cbPictureTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPictureTypes.FormattingEnabled = true;
            this.cbPictureTypes.Items.AddRange(new object[] {
            "Other ",
            "32x32 pixels \'file icon\' (PNG only) ",
            "Other file icon ",
            "Cover (front) ",
            "Cover (back) ",
            "Leaflet page ",
            "Media (e.g. lable side of CD) ",
            "Lead artist/lead performer/soloist ",
            "Artist/performer ",
            "Conductor ",
            "Band/Orchestra ",
            "Composer ",
            "Lyricist/text writer ",
            "Recording Location ",
            "During recording ",
            "During performance ",
            "Movie/video screen capture ",
            "A bright coloured fish ",
            "Illustration ",
            "Band/artist logotype ",
            "Publisher/Studio logotype"});
            this.cbPictureTypes.Location = new System.Drawing.Point(144, 99);
            this.cbPictureTypes.Name = "cbPictureTypes";
            this.cbPictureTypes.Size = new System.Drawing.Size(205, 21);
            this.cbPictureTypes.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Select image type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtImageName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSourceFolder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBrowseSource);
            this.groupBox1.Controls.Add(this.cbPictureTypes);
            this.groupBox1.Controls.Add(this.chkRecursive);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 129);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Embed Picture Options";
            // 
            // txtImageName
            // 
            this.txtImageName.Location = new System.Drawing.Point(144, 45);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(205, 20);
            this.txtImageName.TabIndex = 22;
            this.txtImageName.Text = "Folder.jpg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Image file name:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(471, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 182);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // EmbedPicturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 368);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExecute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "EmbedPicturesForm";
            this.Text = "Embed Pictures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmbedPicturesForm_FormClosing);
            this.Load += new System.EventHandler(this.EmbedPicturesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSourceFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.ComboBox cbPictureTypes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtImageName;
		private System.Windows.Forms.Label label3;

    }
}