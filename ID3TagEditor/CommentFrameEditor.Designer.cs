namespace Preston.Media.ID3TagEditor
{
    partial class CommentFrameEditor
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
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(7, 66);
            this.txtComment.MaxLength = 1000;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(270, 42);
            this.txtComment.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(7, 2);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(7, 49);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(54, 13);
            this.lblComment.TabIndex = 5;
            this.lblComment.Text = "Comment:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(7, 20);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(270, 20);
            this.txtDescription.TabIndex = 6;
            // 
            // CommentFrameEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtComment);
            this.Name = "CommentFrameEditor";
            this.Size = new System.Drawing.Size(282, 113);
            this.Enter += new System.EventHandler(this.CommentFrameEditor_Enter);
            this.Load += new System.EventHandler(this.CommenFrameEditor_Load);
            this.Leave += new System.EventHandler(this.ImageFrameEditor_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtDescription;
    }
}
