namespace Preston.Media.ID3TagEditor
{
    partial class TrackTagEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackTagEditor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD3V2Editor = new Preston.Media.ID3TagEditor.ID3V2Editor();
            this.lblTteNoFileSelected = new System.Windows.Forms.Label();
            this.id3V1Editor = new Preston.Media.ID3TagEditor.ID3V1Editor();
            this.cbTags = new System.Windows.Forms.ComboBox();
            this.lblTteChooseTag = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTteTrackFileName = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbShowFileList = new System.Windows.Forms.ToolStripButton();
            this.btnChangeFileName = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iD3V2Editor);
            this.panel1.Controls.Add(this.lblTteNoFileSelected);
            this.panel1.Controls.Add(this.id3V1Editor);
            this.panel1.Location = new System.Drawing.Point(7, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 220);
            this.panel1.TabIndex = 0;
            // 
            // iD3V2Editor
            // 
            this.iD3V2Editor.Id3Tag = null;
            this.iD3V2Editor.Location = new System.Drawing.Point(0, 0);
            this.iD3V2Editor.Margin = new System.Windows.Forms.Padding(0);
            this.iD3V2Editor.Name = "iD3V2Editor";
            this.iD3V2Editor.Size = new System.Drawing.Size(651, 220);
            this.iD3V2Editor.TabIndex = 2;
            this.iD3V2Editor.Visible = false;
            // 
            // lblTteNoFileSelected
            // 
            this.lblTteNoFileSelected.AutoSize = true;
            this.lblTteNoFileSelected.Location = new System.Drawing.Point(283, 104);
            this.lblTteNoFileSelected.Name = "lblTteNoFileSelected";
            this.lblTteNoFileSelected.Size = new System.Drawing.Size(83, 13);
            this.lblTteNoFileSelected.TabIndex = 0;
            this.lblTteNoFileSelected.Text = "No file selected.";
            // 
            // id3V1Editor
            // 
            this.id3V1Editor.Id3Tag = null;
            this.id3V1Editor.Location = new System.Drawing.Point(0, 0);
            this.id3V1Editor.Name = "id3V1Editor";
            this.id3V1Editor.Size = new System.Drawing.Size(643, 220);
            this.id3V1Editor.TabIndex = 1;
            this.id3V1Editor.Visible = false;
            // 
            // cbTags
            // 
            this.cbTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTags.Enabled = false;
            this.cbTags.FormattingEnabled = true;
            this.cbTags.Location = new System.Drawing.Point(113, 65);
            this.cbTags.Name = "cbTags";
            this.cbTags.Size = new System.Drawing.Size(150, 21);
            this.cbTags.TabIndex = 1;
            this.cbTags.SelectedIndexChanged += new System.EventHandler(this.cbTags_SelectedIndexChanged);
            // 
            // lblTteChooseTag
            // 
            this.lblTteChooseTag.AutoSize = true;
            this.lblTteChooseTag.Location = new System.Drawing.Point(9, 68);
            this.lblTteChooseTag.Name = "lblTteChooseTag";
            this.lblTteChooseTag.Size = new System.Drawing.Size(101, 13);
            this.lblTteChooseTag.TabIndex = 2;
            this.lblTteChooseTag.Text = "Choose tag to view:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(269, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = Properties.Resources.tteBtnDeleteTagText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTteTrackFileName
            // 
            this.lblTteTrackFileName.AutoSize = true;
            this.lblTteTrackFileName.Location = new System.Drawing.Point(9, 39);
            this.lblTteTrackFileName.Name = "lblTteTrackFileName";
            this.lblTteTrackFileName.Size = new System.Drawing.Size(83, 13);
            this.lblTteTrackFileName.TabIndex = 4;
            this.lblTteTrackFileName.Text = "Track file name:";
            // 
            // lblFileName
            // 
            this.lblFileName.AllowDrop = true;
            this.lblFileName.AutoEllipsis = true;
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(100, 39);
            this.lblFileName.MaximumSize = new System.Drawing.Size(436, 20);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(104, 13);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "Drop MP3 file here...";
            this.lblFileName.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblFileName_DragDrop);
            this.lblFileName.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblFileName_DragEnter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbShowFileList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(665, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbShowFileList
            // 
            this.tsbShowFileList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShowFileList.Image = ((System.Drawing.Image)(resources.GetObject("tsbShowFileList.Image")));
            this.tsbShowFileList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowFileList.Name = "tsbShowFileList";
            this.tsbShowFileList.Size = new System.Drawing.Size(23, 22);
            this.tsbShowFileList.Text = Properties.Resources.tteTsbShowFileListText;
            this.tsbShowFileList.ToolTipText = Properties.Resources.tteTsbShowFileListText;
            // 
            // btnChangeFileName
            // 
            this.btnChangeFileName.Enabled = false;
            this.btnChangeFileName.Location = new System.Drawing.Point(540, 34);
            this.btnChangeFileName.Name = "btnChangeFileName";
            this.btnChangeFileName.Size = new System.Drawing.Size(116, 23);
            this.btnChangeFileName.TabIndex = 7;
            this.btnChangeFileName.Text = Properties.Resources.tteBtnChangeFileNameText;
            this.btnChangeFileName.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(581, 321);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(502, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(423, 321);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // TrackTagEditor
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 350);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnChangeFileName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblTteTrackFileName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTteChooseTag);
            this.Controls.Add(this.cbTags);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrackTagEditor";
            this.Text = "Track Tag Editor";
            this.Load += new System.EventHandler(this.TrackTagEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTags;
        private System.Windows.Forms.Label lblTteChooseTag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTteTrackFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbShowFileList;
        private System.Windows.Forms.Button btnChangeFileName;
        private System.Windows.Forms.Label lblTteNoFileSelected;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private ID3V2Editor iD3V2Editor;
        private ID3V1Editor id3V1Editor;
    }
}