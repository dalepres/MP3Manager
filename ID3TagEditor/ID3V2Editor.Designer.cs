namespace Preston.Media.ID3TagEditor
{
    partial class ID3V2Editor
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbV22 = new System.Windows.Forms.RadioButton();
            this.rbV23 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTrackInfo = new System.Windows.Forms.TabPage();
            this.txtTrackNumber = new System.Windows.Forms.TextBox();
            this.txtAlbumArtist = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpComments = new System.Windows.Forms.TabPage();
            this.tpPictures = new System.Windows.Forms.TabPage();
            this.tpRawView = new System.Windows.Forms.TabPage();
            this.imageFramesEditor1 = new Preston.Media.ID3TagEditor.ImageFramesEditor();
            this.commentFramesEditor1 = new Preston.Media.ID3TagEditor.CommentFramesEditor();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpTrackInfo.SuspendLayout();
            this.tpComments.SuspendLayout();
            this.tpPictures.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 17);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ID3 Tag Version 2";
            // 
            // rbV22
            // 
            this.rbV22.AutoSize = true;
            this.rbV22.Location = new System.Drawing.Point(474, 9);
            this.rbV22.Name = "rbV22";
            this.rbV22.Size = new System.Drawing.Size(78, 17);
            this.rbV22.TabIndex = 3;
            this.rbV22.Text = "Version 2.2";
            this.rbV22.UseVisualStyleBackColor = true;
            // 
            // rbV23
            // 
            this.rbV23.AutoSize = true;
            this.rbV23.Checked = true;
            this.rbV23.Location = new System.Drawing.Point(556, 9);
            this.rbV23.Name = "rbV23";
            this.rbV23.Size = new System.Drawing.Size(78, 17);
            this.rbV23.TabIndex = 4;
            this.rbV23.TabStop = true;
            this.rbV23.Text = "Version 2.3";
            this.rbV23.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 189);
            this.panel1.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTrackInfo);
            this.tabControl1.Controls.Add(this.tpComments);
            this.tabControl1.Controls.Add(this.tpPictures);
            this.tabControl1.Controls.Add(this.tpRawView);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 189);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpTrackInfo
            // 
            this.tpTrackInfo.Controls.Add(this.txtTrackNumber);
            this.tpTrackInfo.Controls.Add(this.txtAlbumArtist);
            this.tpTrackInfo.Controls.Add(this.label10);
            this.tpTrackInfo.Controls.Add(this.txtArtistName);
            this.tpTrackInfo.Controls.Add(this.label5);
            this.tpTrackInfo.Controls.Add(this.txtSet);
            this.tpTrackInfo.Controls.Add(this.label2);
            this.tpTrackInfo.Controls.Add(this.label8);
            this.tpTrackInfo.Controls.Add(this.cbGenre);
            this.tpTrackInfo.Controls.Add(this.label7);
            this.tpTrackInfo.Controls.Add(this.txtYear);
            this.tpTrackInfo.Controls.Add(this.label6);
            this.tpTrackInfo.Controls.Add(this.txtAlbumName);
            this.tpTrackInfo.Controls.Add(this.label4);
            this.tpTrackInfo.Controls.Add(this.txtSongName);
            this.tpTrackInfo.Controls.Add(this.label1);
            this.tpTrackInfo.Location = new System.Drawing.Point(4, 22);
            this.tpTrackInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tpTrackInfo.Name = "tpTrackInfo";
            this.tpTrackInfo.Size = new System.Drawing.Size(643, 163);
            this.tpTrackInfo.TabIndex = 0;
            this.tpTrackInfo.Text = "Track Info";
            this.tpTrackInfo.UseVisualStyleBackColor = true;
            // 
            // txtTrackNumber
            // 
            this.txtTrackNumber.Location = new System.Drawing.Point(82, 50);
            this.txtTrackNumber.MaxLength = 4;
            this.txtTrackNumber.Name = "txtTrackNumber";
            this.txtTrackNumber.Size = new System.Drawing.Size(51, 20);
            this.txtTrackNumber.TabIndex = 49;
            // 
            // txtAlbumArtist
            // 
            this.txtAlbumArtist.Location = new System.Drawing.Point(82, 132);
            this.txtAlbumArtist.MaxLength = 250;
            this.txtAlbumArtist.Name = "txtAlbumArtist";
            this.txtAlbumArtist.Size = new System.Drawing.Size(225, 20);
            this.txtAlbumArtist.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Album Artist:";
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(387, 9);
            this.txtArtistName.MaxLength = 250;
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(225, 20);
            this.txtArtistName.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Track Artist:";
            // 
            // txtSet
            // 
            this.txtSet.Location = new System.Drawing.Point(387, 91);
            this.txtSet.MaxLength = 7;
            this.txtSet.Name = "txtSet";
            this.txtSet.Size = new System.Drawing.Size(51, 20);
            this.txtSet.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Set:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Genre:";
            // 
            // cbGenre
            // 
            this.cbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(387, 50);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(200, 21);
            this.cbGenre.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Track #:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(189, 50);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(51, 20);
            this.txtYear.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Year:";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(82, 91);
            this.txtAlbumName.MaxLength = 250;
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(225, 20);
            this.txtAlbumName.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Album Name:";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(82, 9);
            this.txtSongName.MaxLength = 250;
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(225, 20);
            this.txtSongName.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Song Name:";
            // 
            // tpComments
            // 
            this.tpComments.Controls.Add(this.commentFramesEditor1);
            this.tpComments.Location = new System.Drawing.Point(4, 22);
            this.tpComments.Name = "tpComments";
            this.tpComments.Size = new System.Drawing.Size(643, 163);
            this.tpComments.TabIndex = 2;
            this.tpComments.Text = "Comments";
            this.tpComments.UseVisualStyleBackColor = true;
            // 
            // tpPictures
            // 
            this.tpPictures.Controls.Add(this.imageFramesEditor1);
            this.tpPictures.Location = new System.Drawing.Point(4, 22);
            this.tpPictures.Name = "tpPictures";
            this.tpPictures.Size = new System.Drawing.Size(643, 163);
            this.tpPictures.TabIndex = 3;
            this.tpPictures.Text = "Pictures";
            this.tpPictures.UseVisualStyleBackColor = true;
            // 
            // tpRawView
            // 
            this.tpRawView.Location = new System.Drawing.Point(4, 22);
            this.tpRawView.Name = "tpRawView";
            this.tpRawView.Padding = new System.Windows.Forms.Padding(3);
            this.tpRawView.Size = new System.Drawing.Size(643, 163);
            this.tpRawView.TabIndex = 4;
            this.tpRawView.Text = "Raw View";
            this.tpRawView.UseVisualStyleBackColor = true;
            // 
            // imageFramesEditor1
            // 
            this.imageFramesEditor1.Location = new System.Drawing.Point(0, 0);
            this.imageFramesEditor1.Name = "imageFramesEditor1";
            this.imageFramesEditor1.Size = new System.Drawing.Size(643, 163);
            this.imageFramesEditor1.TabIndex = 0;
            // 
            // commentFramesEditor1
            // 
            this.commentFramesEditor1.Location = new System.Drawing.Point(0, 0);
            this.commentFramesEditor1.Name = "commentFramesEditor1";
            this.commentFramesEditor1.Size = new System.Drawing.Size(643, 163);
            this.commentFramesEditor1.TabIndex = 0;
            // 
            // ID3V2Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbV23);
            this.Controls.Add(this.rbV22);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ID3V2Editor";
            this.Size = new System.Drawing.Size(651, 220);
            this.Load += new System.EventHandler(this.ID3V2Editor_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpTrackInfo.ResumeLayout(false);
            this.tpTrackInfo.PerformLayout();
            this.tpComments.ResumeLayout(false);
            this.tpPictures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbV22;
        private System.Windows.Forms.RadioButton rbV23;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTrackInfo;
        private System.Windows.Forms.TextBox txtAlbumArtist;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpComments;
        private System.Windows.Forms.TabPage tpPictures;
        private System.Windows.Forms.TabPage tpRawView;
        private System.Windows.Forms.TextBox txtTrackNumber;
        private ImageFramesEditor imageFramesEditor1;
        private CommentFramesEditor commentFramesEditor1;
    }
}
