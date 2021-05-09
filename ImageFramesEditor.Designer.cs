namespace Preston.Media
{
    partial class ImageFramesEditor
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
            this.imageFrameEditor1 = new Preston.Media.ImageFrameEditor();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 163);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imageFrameEditor1
            // 
            this.imageFrameEditor1.Location = new System.Drawing.Point(331, 3);
            this.imageFrameEditor1.Name = "imageFrameEditor1";
            this.imageFrameEditor1.PicFrame = null;
            this.imageFrameEditor1.ReadOnly = false;
            this.imageFrameEditor1.Size = new System.Drawing.Size(300, 110);
            this.imageFrameEditor1.TabIndex = 1;
            // 
            // ImageFramesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageFrameEditor1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ImageFramesEditor";
            this.Size = new System.Drawing.Size(643, 163);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Preston.Media.ImageFrameEditor imageFrameEditor1;
    }
}
