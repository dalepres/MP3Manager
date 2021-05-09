namespace Preston.Media.ID3TagEditor
{
    partial class CommentFramesEditor
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.commentFrameEditor1 = new Preston.Media.ID3TagEditor.CommentFrameEditor();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 128);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(438, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(336, 132);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(540, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // commentFrameEditor1
            // 
            this.commentFrameEditor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentFrameEditor1.Comment = "";
            this.commentFrameEditor1.CommentFrame = null;
            this.commentFrameEditor1.Description = "";
            this.commentFrameEditor1.Location = new System.Drawing.Point(350, 10);
            this.commentFrameEditor1.Name = "commentFrameEditor1";
            this.commentFrameEditor1.ReadOnly = false;
            this.commentFrameEditor1.Size = new System.Drawing.Size(284, 115);
            this.commentFrameEditor1.TabIndex = 1;
            // 
            // CommentFramesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.commentFrameEditor1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CommentFramesEditor";
            this.Size = new System.Drawing.Size(643, 163);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CommentFrameEditor commentFrameEditor1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
    }
}
