namespace Preston.Media
{
    partial class TagViewer
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtbHexDisplay = new System.Windows.Forms.RichTextBox();
            this.rtbCharDisplay = new System.Windows.Forms.RichTextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 55);
            this.panel2.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 319);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(673, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtbHexDisplay);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbCharDisplay);
            this.splitContainer1.Size = new System.Drawing.Size(673, 264);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.TabIndex = 3;
            // 
            // rtbHexDisplay
            // 
            this.rtbHexDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHexDisplay.Location = new System.Drawing.Point(0, 0);
            this.rtbHexDisplay.Name = "rtbHexDisplay";
            this.rtbHexDisplay.Size = new System.Drawing.Size(420, 264);
            this.rtbHexDisplay.TabIndex = 1;
            this.rtbHexDisplay.Text = "";
            // 
            // rtbCharDisplay
            // 
            this.rtbCharDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbCharDisplay.Location = new System.Drawing.Point(0, 0);
            this.rtbCharDisplay.Name = "rtbCharDisplay";
            this.rtbCharDisplay.Size = new System.Drawing.Size(249, 264);
            this.rtbCharDisplay.TabIndex = 0;
            this.rtbCharDisplay.Text = "";
            // 
            // TagViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "TagViewer";
            this.Size = new System.Drawing.Size(673, 341);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbHexDisplay;
        private System.Windows.Forms.RichTextBox rtbCharDisplay;
    }
}
