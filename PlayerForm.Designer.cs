namespace Preston.Media
{
	partial class PlayerForm
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
			this.components = new System.ComponentModel.Container();
			this.lblTrackName = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTrackName
			// 
			this.lblTrackName.AutoSize = true;
			this.lblTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
			this.lblTrackName.Location = new System.Drawing.Point(12, 9);
			this.lblTrackName.Name = "lblTrackName";
			this.lblTrackName.Size = new System.Drawing.Size(1220, 44);
			this.lblTrackName.TabIndex = 0;
			this.lblTrackName.Text = "OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(366, 151);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(257, 469);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(100, 23);
			this.progressBar1.TabIndex = 2;
			// 
			// PlayerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 522);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblTrackName);
			this.Name = "PlayerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "PlayerForm";
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTrackName;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
	}
}