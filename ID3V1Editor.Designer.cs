namespace Preston.Media
{
    partial class ID3V1Editor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbV10 = new System.Windows.Forms.RadioButton();
            this.rbV11 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.nudTrackNumber = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Song Name:";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(82, 9);
            this.txtSongName.MaxLength = 30;
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(250, 20);
            this.txtSongName.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 17);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ID3 Tag Version 1";
            // 
            // rbV10
            // 
            this.rbV10.AutoSize = true;
            this.rbV10.Location = new System.Drawing.Point(472, 9);
            this.rbV10.Name = "rbV10";
            this.rbV10.Size = new System.Drawing.Size(78, 17);
            this.rbV10.TabIndex = 3;
            this.rbV10.Text = "Version 1.0";
            this.rbV10.UseVisualStyleBackColor = true;
            this.rbV10.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
            // 
            // rbV11
            // 
            this.rbV11.AutoSize = true;
            this.rbV11.Checked = true;
            this.rbV11.Location = new System.Drawing.Point(556, 9);
            this.rbV11.Name = "rbV11";
            this.rbV11.Size = new System.Drawing.Size(78, 17);
            this.rbV11.TabIndex = 4;
            this.rbV11.TabStop = true;
            this.rbV11.Text = "Version 1.1";
            this.rbV11.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbGenre);
            this.panel1.Controls.Add(this.nudTrackNumber);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtArtistName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAlbumName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtComment);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSongName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 164);
            this.panel1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Genre:";
            // 
            // cbGenre
            // 
            this.cbGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(442, 134);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(200, 21);
            this.cbGenre.TabIndex = 13;
            // 
            // nudTrackNumber
            // 
            this.nudTrackNumber.Location = new System.Drawing.Point(442, 52);
            this.nudTrackNumber.Name = "nudTrackNumber";
            this.nudTrackNumber.Size = new System.Drawing.Size(51, 20);
            this.nudTrackNumber.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Track #:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(442, 9);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(51, 20);
            this.txtYear.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Year:";
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(82, 51);
            this.txtArtistName.MaxLength = 30;
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(250, 20);
            this.txtArtistName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Artist Name:";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(82, 93);
            this.txtAlbumName.MaxLength = 30;
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(250, 20);
            this.txtAlbumName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Album Name:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(82, 135);
            this.txtComment.MaxLength = 30;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(250, 20);
            this.txtComment.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comment:";
            // 
            // ID3V1Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbV11);
            this.Controls.Add(this.rbV10);
            this.Controls.Add(this.lblTitle);
            this.Name = "ID3V1Editor";
            this.Size = new System.Drawing.Size(651, 220);
            this.Load += new System.EventHandler(this.ID3V1Editor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbV10;
        private System.Windows.Forms.RadioButton rbV11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudTrackNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGenre;
    }
}
