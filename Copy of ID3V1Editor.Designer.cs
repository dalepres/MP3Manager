namespace Preston.Media
{
    partial class ID3V1EditorG
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
            this.rbV10 = new System.Windows.Forms.RadioButton();
            this.rbV11 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackNumber)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 189);
            this.panel2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 137);
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
            this.cbGenre.Location = new System.Drawing.Point(434, 134);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(200, 21);
            this.cbGenre.TabIndex = 13;
            // 
            // nudTrackNumber
            // 
            this.nudTrackNumber.Location = new System.Drawing.Point(434, 52);
            this.nudTrackNumber.Name = "nudTrackNumber";
            this.nudTrackNumber.Size = new System.Drawing.Size(51, 20);
            this.nudTrackNumber.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Track #:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(434, 9);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(51, 20);
            this.txtYear.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 12);
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
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(82, 9);
            this.txtSongName.MaxLength = 30;
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(250, 20);
            this.txtSongName.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(4, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 164);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Genre:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(434, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(434, 52);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Track #:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 9);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Year:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 51);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Artist Name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 93);
            this.textBox3.MaxLength = 30;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Album Name:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 135);
            this.textBox4.MaxLength = 30;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Comment:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(82, 9);
            this.textBox5.MaxLength = 30;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(250, 20);
            this.textBox5.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Song Name:";
            // 
            // ID3V1EditorG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rbV11);
            this.Controls.Add(this.rbV10);
            this.Controls.Add(this.lblTitle);
            this.Name = "ID3V1EditorG";
            this.Size = new System.Drawing.Size(651, 220);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbV10;
        private System.Windows.Forms.RadioButton rbV11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.NumericUpDown nudTrackNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label14;
    }
}
