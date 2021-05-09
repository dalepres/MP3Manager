namespace MusicDiskMaker
{
	partial class WindowController
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowController));
			this.btnClose = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnClose.Location = new System.Drawing.Point(93, 11);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(33, 23);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Maximize.png");
			this.imageList1.Images.SetKeyName(1, "Unmaximize.png");
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.button2.Location = new System.Drawing.Point(15, 11);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(33, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "__";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.button1.ImageIndex = 1;
			this.button1.ImageList = this.imageList1;
			this.button1.Location = new System.Drawing.Point(54, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(33, 23);
			this.button1.TabIndex = 6;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// WindowController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnClose);
			this.Name = "WindowController";
			this.Size = new System.Drawing.Size(140, 37);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ImageList imageList1;
	}
}
