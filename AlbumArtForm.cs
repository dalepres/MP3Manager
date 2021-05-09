using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace MusicDiskMaker
{
	public delegate void MediaControlEventHandler(string action);

	public class AlbumArtForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private Point MouseXY;
		private Label lblTrackName;
		private ProgressBar progressBar1;
		private Label lblArtistName;
		private int ScreenNumber;
		private Button btnClose;
		private Timer PlaySecondsTimer;
		private Label lblAlbumName;
		private PictureBox pictureBox1;
		private Label lblDuration;
		private ID3Lib.TrackInfo trackInfo;
		private ImageList imageList1;
		private Button btnUnMaximize;
		private Label lblAlbumNameSmall;
		private Label lblArtistNameSmall;
		private Label lblTrackNameSmall;
		private Label lblDurationSmall;
		private ProgressBar progressBarSmall;
		private TimeSpan playTime;
		private DateTime startTime;
		private Button btnVolumeDown;
		private Button btnVolumeUp;
		private Button btnPausePlay;
		private Button btnPrevious;
		private Button btnNext;

		private bool isMaximized = false;

		private Microsoft.Win32.RegistryKey regkeyScreenSaver;

		private object origScreenSaveSetting;

		private AlbumArtForm(int scrn)
			: this()
		{
			ScreenNumber = scrn;
		}


		public AlbumArtForm(ID3Lib.TrackInfo trackInfo)
			: this()
		{
			this.trackInfo = trackInfo;
		}


		public AlbumArtForm()
		{
			ScreenNumber = 0;
			InitializeComponent();
			DisplayNextTrack = new Display(SetTrackInfo);
			StartDurationCounter = new UpdateDuration(SetDuration);
		}


		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private void AlbumArtForm_Load(object sender, System.EventArgs e)
		{
			try
			{
				MaximizeForm();

				DisplayTrackInfo(this.trackInfo);
			}
			catch
			{
				CloseForm();
			}

			// Get current screen saver setting
			regkeyScreenSaver = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
			origScreenSaveSetting = regkeyScreenSaver.GetValue("ScreenSaveActive");

			//Turn screen saver off
			regkeyScreenSaver.SetValue("ScreenSaveActive", "0");
		}


		private void MaximizeForm()
		{
			isMaximized = true;
			this.Bounds = Screen.AllScreens[ScreenNumber].Bounds;

			TopMost = true;

			lblTrackName.Visible = true;
			lblDuration.Visible = true;
			lblAlbumName.Visible = true;
			lblArtistName.Visible = true;
			progressBar1.Visible = true;

			lblTrackNameSmall.Visible = false;
			lblDurationSmall.Visible = false;
			lblArtistNameSmall.Visible = false;
			lblAlbumNameSmall.Visible = false;
			progressBarSmall.Visible = false;

			this.pictureBox1.Size = new Size(480,480);

			SetPictureLocation();


			this.btnClose.Left = this.Width - (btnClose.Width + 5);
			this.btnUnMaximize.Left = btnClose.Left - (btnUnMaximize.Width + 3);
			this.btnUnMaximize.ImageIndex = 0;

			this.lblAlbumName.Left = (this.Width / 2) - (lblAlbumName.Width / 2);
			btnClose.Top = 10;
			btnClose.Left = this.Width - (btnClose.Width + 10);
			this.btnUnMaximize.Top = btnClose.Top;
			btnUnMaximize.Left = btnClose.Left - (btnUnMaximize.Width + 10);

			this.progressBar1.Value = this.progressBarSmall.Value = 0;
			this.progressBar1.Width = (int)(this.Width * .80);
			this.progressBar1.Top = this.Height - (this.progressBar1.Height + 4);
			this.progressBar1.Left = (this.Width / 2) - (progressBar1.Width / 2);

			this.lblDuration.Top = progressBar1.Top - (lblDuration.Height);
			this.lblDuration.Left = (progressBar1.Left + progressBar1.Width) - lblDuration.Width;

			this.btnPrevious.Top = btnPausePlay.Top = btnNext.Top = btnVolumeDown.Top = btnVolumeUp.Top
				= this.progressBar1.Top - (btnPrevious.Height + 5);
			this.btnPrevious.Left = progressBar1.Left;
			btnPausePlay.Left = btnPrevious.Left + btnPrevious.Width + 10;
			btnNext.Left = btnPausePlay.Left + btnPausePlay.Width + 10;
			btnVolumeDown.Left = btnNext.Left + btnNext.Width + 50;
			btnVolumeUp.Left = btnVolumeDown.Left + btnVolumeDown.Width + 10;

		}


		private void UnMaximizeForm()
		{
			isMaximized = false;
			this.TopMost = false;

			this.Height = 400;
			this.Width = 600;
			this.Top = 150;
			this.Left = 250;
			lblTrackName.Visible = false;
			lblDuration.Visible = false;
			lblAlbumName.Visible = false;
			lblArtistName.Visible = false;
			progressBar1.Visible = false;

			lblTrackNameSmall.Visible = true;
			lblDurationSmall.Visible = true;
			lblArtistNameSmall.Visible = true;
			lblAlbumNameSmall.Visible = true;
			progressBarSmall.Visible = true;

			this.pictureBox1.Size = new Size(200, 200);
			SetPictureLocation();

			btnUnMaximize.ImageIndex = 1;
			this.btnClose.Left = this.Width - (btnClose.Width + 5);
			this.btnUnMaximize.Left = btnClose.Left - (btnUnMaximize.Width + 3);
			this.btnUnMaximize.ImageIndex = 0;
			btnClose.Top = 5;
			btnClose.Left = this.Width - (btnClose.Width + 5);
			this.btnUnMaximize.Top = btnClose.Top;
			btnUnMaximize.Left = btnClose.Left - (btnUnMaximize.Width + 5);

			this.progressBarSmall.Value = this.progressBarSmall.Value = 0;
			this.progressBarSmall.Width = (int)(this.Width * .80);
			this.progressBarSmall.Top = this.Height - (this.progressBarSmall.Height + 4);
			this.progressBarSmall.Left = (this.Width / 2) - (progressBarSmall.Width / 2);

			this.lblDurationSmall.Top = progressBarSmall.Top - (lblDurationSmall.Height);
			this.lblDurationSmall.Left = (progressBarSmall.Left + progressBarSmall.Width) - lblDurationSmall.Width;

			this.btnPrevious.Top = btnPausePlay.Top = btnNext.Top = btnVolumeDown.Top = btnVolumeUp.Top
				= this.progressBarSmall.Top - (btnPrevious.Height + 5);
			this.btnPrevious.Left = progressBarSmall.Left;
			btnPausePlay.Left = btnPrevious.Left + btnPrevious.Width + 10;
			btnNext.Left = btnPausePlay.Left + btnPausePlay.Width + 10;
			btnVolumeDown.Left = btnNext.Left + btnNext.Width + 50;
			btnVolumeUp.Left = btnVolumeDown.Left + btnVolumeDown.Width + 10;
		}


		private void DisplayTrackInfo(ID3Lib.TrackInfo trackInfo)
		{
			try
			{
				PlaySecondsTimer.Enabled = false;

				if (trackInfo == null)
				{
					return;
				}

				this.lblDuration.Text = lblDurationSmall.Text = "00:00";

				this.lblTrackName.Text = lblTrackNameSmall.Text = trackInfo.TrackName;
				this.lblArtistName.Text = lblArtistNameSmall.Text = trackInfo.ArtistName;
				this.lblAlbumName.Text = lblAlbumNameSmall.Text = trackInfo.AlbumName;

				this.lblTrackName.Top = 10;
				this.lblTrackName.Left = 10;
				this.lblArtistName.Top = lblTrackName.Top + lblTrackName.Height + 10;
				this.lblArtistName.Left = 10;

				this.lblTrackNameSmall.Top = 5;
				this.lblTrackNameSmall.Left = 5;
				this.lblArtistNameSmall.Top = this.lblTrackNameSmall.Top + lblTrackNameSmall.Height + 5;
				this.lblArtistNameSmall.Left = 5;

				this.pictureBox1.ImageLocation = Path.Combine(Path.GetDirectoryName(trackInfo.FilePath), "Folder.jpg");

				SetPictureLocation();
				if (isMaximized)
				{
					MaximizeForm();
				}
				else
				{
					UnMaximizeForm();
				}
			}
			catch
			{
				CloseForm();
			}
		}

		private void SetPictureLocation()
		{
			if (isMaximized)
			{
				pictureBox1.Left = (this.Width / 2) - 240;
				pictureBox1.Top = lblArtistName.Top + lblArtistName.Height + 10;
				this.lblAlbumName.Top = pictureBox1.Top + pictureBox1.Height;
				lblAlbumName.Left = (this.Width / 2) - (lblAlbumName.Width / 2);
			}
			else
			{
				pictureBox1.Left = (this.Width / 2) - 100;
				pictureBox1.Top = lblArtistNameSmall.Top + lblArtistNameSmall.Height + 5;
				this.lblAlbumNameSmall.Top = pictureBox1.Top + pictureBox1.Height;
				lblAlbumNameSmall.Left = (this.Width / 2) - (lblAlbumNameSmall.Width / 2);
			}
		}


		private void OnMouseEvent(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				if (!MouseXY.IsEmpty)
				{
					//if (MouseXY != new Point(e.X, e.Y))
					//    CloseForm();
					//if (e.Clicks > 0)
					//    CloseForm();
				}
				MouseXY = new Point(e.X, e.Y);
			}
			catch (Exception)
			{
				CloseForm();
			}
		}
		
		private void ScreenSaverForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			CloseForm();
		}

		private void CloseForm()
		{
			Cursor.Show();
			this.Hide();
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumArtForm));
			this.lblTrackName = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lblArtistName = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.PlaySecondsTimer = new System.Windows.Forms.Timer(this.components);
			this.lblAlbumName = new System.Windows.Forms.Label();
			this.lblDuration = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.lblAlbumNameSmall = new System.Windows.Forms.Label();
			this.lblArtistNameSmall = new System.Windows.Forms.Label();
			this.lblTrackNameSmall = new System.Windows.Forms.Label();
			this.lblDurationSmall = new System.Windows.Forms.Label();
			this.progressBarSmall = new System.Windows.Forms.ProgressBar();
			this.btnVolumeDown = new System.Windows.Forms.Button();
			this.btnVolumeUp = new System.Windows.Forms.Button();
			this.btnPausePlay = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnUnMaximize = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTrackName
			// 
			this.lblTrackName.AutoSize = true;
			this.lblTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTrackName.ForeColor = System.Drawing.Color.White;
			this.lblTrackName.Location = new System.Drawing.Point(13, 13);
			this.lblTrackName.MaximumSize = new System.Drawing.Size(950, 120);
			this.lblTrackName.Name = "lblTrackName";
			this.lblTrackName.Size = new System.Drawing.Size(0, 39);
			this.lblTrackName.TabIndex = 0;
			// 
			// progressBar1
			// 
			this.progressBar1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.progressBar1.Location = new System.Drawing.Point(80, 238);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(100, 16);
			this.progressBar1.Step = 1;
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 0;
			// 
			// lblArtistName
			// 
			this.lblArtistName.AutoSize = true;
			this.lblArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblArtistName.ForeColor = System.Drawing.Color.White;
			this.lblArtistName.Location = new System.Drawing.Point(13, 77);
			this.lblArtistName.MaximumSize = new System.Drawing.Size(950, 120);
			this.lblArtistName.Name = "lblArtistName";
			this.lblArtistName.Size = new System.Drawing.Size(0, 33);
			this.lblArtistName.TabIndex = 3;
			// 
			// btnClose
			// 
			this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
			this.btnClose.Location = new System.Drawing.Point(12, 113);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(33, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// PlaySecondsTimer
			// 
			this.PlaySecondsTimer.Interval = 995;
			this.PlaySecondsTimer.Tick += new System.EventHandler(this.PlaySecondsTimer_Tick);
			// 
			// lblAlbumName
			// 
			this.lblAlbumName.AutoSize = true;
			this.lblAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlbumName.ForeColor = System.Drawing.Color.White;
			this.lblAlbumName.Location = new System.Drawing.Point(97, 120);
			this.lblAlbumName.MaximumSize = new System.Drawing.Size(950, 120);
			this.lblAlbumName.Name = "lblAlbumName";
			this.lblAlbumName.Size = new System.Drawing.Size(0, 33);
			this.lblAlbumName.TabIndex = 5;
			// 
			// lblDuration
			// 
			this.lblDuration.AutoSize = true;
			this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDuration.ForeColor = System.Drawing.Color.White;
			this.lblDuration.Location = new System.Drawing.Point(146, 109);
			this.lblDuration.MaximumSize = new System.Drawing.Size(950, 120);
			this.lblDuration.Name = "lblDuration";
			this.lblDuration.Size = new System.Drawing.Size(0, 39);
			this.lblDuration.TabIndex = 7;
			this.lblDuration.Visible = false;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Unmaximize.png");
			this.imageList1.Images.SetKeyName(1, "Maximize.png");
			this.imageList1.Images.SetKeyName(2, "Pause.png");
			this.imageList1.Images.SetKeyName(3, "Play.png");
			// 
			// lblAlbumNameSmall
			// 
			this.lblAlbumNameSmall.AutoSize = true;
			this.lblAlbumNameSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlbumNameSmall.ForeColor = System.Drawing.Color.White;
			this.lblAlbumNameSmall.Location = new System.Drawing.Point(146, 120);
			this.lblAlbumNameSmall.MaximumSize = new System.Drawing.Size(500, 40);
			this.lblAlbumNameSmall.Name = "lblAlbumNameSmall";
			this.lblAlbumNameSmall.Size = new System.Drawing.Size(0, 20);
			this.lblAlbumNameSmall.TabIndex = 9;
			this.lblAlbumNameSmall.Visible = false;
			// 
			// lblArtistNameSmall
			// 
			this.lblArtistNameSmall.AutoSize = true;
			this.lblArtistNameSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblArtistNameSmall.ForeColor = System.Drawing.Color.White;
			this.lblArtistNameSmall.Location = new System.Drawing.Point(146, 126);
			this.lblArtistNameSmall.MaximumSize = new System.Drawing.Size(500, 40);
			this.lblArtistNameSmall.Name = "lblArtistNameSmall";
			this.lblArtistNameSmall.Size = new System.Drawing.Size(0, 20);
			this.lblArtistNameSmall.TabIndex = 10;
			this.lblArtistNameSmall.Visible = false;
			// 
			// lblTrackNameSmall
			// 
			this.lblTrackNameSmall.AutoSize = true;
			this.lblTrackNameSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTrackNameSmall.ForeColor = System.Drawing.Color.White;
			this.lblTrackNameSmall.Location = new System.Drawing.Point(154, 134);
			this.lblTrackNameSmall.MaximumSize = new System.Drawing.Size(500, 80);
			this.lblTrackNameSmall.Name = "lblTrackNameSmall";
			this.lblTrackNameSmall.Size = new System.Drawing.Size(0, 25);
			this.lblTrackNameSmall.TabIndex = 11;
			this.lblTrackNameSmall.Visible = false;
			// 
			// lblDurationSmall
			// 
			this.lblDurationSmall.AutoSize = true;
			this.lblDurationSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDurationSmall.ForeColor = System.Drawing.Color.White;
			this.lblDurationSmall.Location = new System.Drawing.Point(146, 124);
			this.lblDurationSmall.MaximumSize = new System.Drawing.Size(500, 40);
			this.lblDurationSmall.Name = "lblDurationSmall";
			this.lblDurationSmall.Size = new System.Drawing.Size(0, 25);
			this.lblDurationSmall.TabIndex = 12;
			this.lblDurationSmall.Visible = false;
			// 
			// progressBarSmall
			// 
			this.progressBarSmall.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.progressBarSmall.Location = new System.Drawing.Point(96, 128);
			this.progressBarSmall.Name = "progressBarSmall";
			this.progressBarSmall.Size = new System.Drawing.Size(100, 12);
			this.progressBarSmall.Step = 1;
			this.progressBarSmall.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarSmall.TabIndex = 13;
			this.progressBarSmall.Visible = false;
			// 
			// btnVolumeDown
			// 
			this.btnVolumeDown.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnVolumeDown.Location = new System.Drawing.Point(215, 13);
			this.btnVolumeDown.Name = "btnVolumeDown";
			this.btnVolumeDown.Size = new System.Drawing.Size(33, 23);
			this.btnVolumeDown.TabIndex = 18;
			this.btnVolumeDown.Text = "Dn";
			this.btnVolumeDown.UseVisualStyleBackColor = true;
			this.btnVolumeDown.Click += new System.EventHandler(this.btnVolumeDown_Click);
			// 
			// btnVolumeUp
			// 
			this.btnVolumeUp.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnVolumeUp.Location = new System.Drawing.Point(178, 13);
			this.btnVolumeUp.Name = "btnVolumeUp";
			this.btnVolumeUp.Size = new System.Drawing.Size(33, 23);
			this.btnVolumeUp.TabIndex = 17;
			this.btnVolumeUp.Text = "Up";
			this.btnVolumeUp.UseVisualStyleBackColor = true;
			this.btnVolumeUp.Click += new System.EventHandler(this.btnVolumeUp_Click);
			// 
			// btnPausePlay
			// 
			this.btnPausePlay.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnPausePlay.ImageIndex = 2;
			this.btnPausePlay.ImageList = this.imageList1;
			this.btnPausePlay.Location = new System.Drawing.Point(57, 13);
			this.btnPausePlay.Name = "btnPausePlay";
			this.btnPausePlay.Size = new System.Drawing.Size(33, 23);
			this.btnPausePlay.TabIndex = 16;
			this.btnPausePlay.Tag = "Pause";
			this.btnPausePlay.UseVisualStyleBackColor = true;
			this.btnPausePlay.Click += new System.EventHandler(this.btnPausePlay_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnPrevious.Location = new System.Drawing.Point(20, 13);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(33, 23);
			this.btnPrevious.TabIndex = 15;
			this.btnPrevious.Text = "<<";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnNext.Location = new System.Drawing.Point(94, 13);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(33, 23);
			this.btnNext.TabIndex = 14;
			this.btnNext.Text = ">>";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnUnMaximize
			// 
			this.btnUnMaximize.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnUnMaximize.ImageIndex = 0;
			this.btnUnMaximize.ImageList = this.imageList1;
			this.btnUnMaximize.Location = new System.Drawing.Point(130, 125);
			this.btnUnMaximize.Name = "btnUnMaximize";
			this.btnUnMaximize.Size = new System.Drawing.Size(33, 23);
			this.btnUnMaximize.TabIndex = 8;
			this.btnUnMaximize.UseVisualStyleBackColor = true;
			this.btnUnMaximize.Click += new System.EventHandler(this.btnUnMaximize_Click);
			// 
			// pictureBox1
			// 
			//this.pictureBox1.ErrorImage = global::MusicDiskMaker.Properties.Resources.Note;
			//this.pictureBox1.InitialImage = global::MusicDiskMaker.Properties.Resources.Note;
			this.pictureBox1.Location = new System.Drawing.Point(80, 156);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// AlbumArtForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.btnVolumeDown);
			this.Controls.Add(this.btnVolumeUp);
			this.Controls.Add(this.btnPausePlay);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.progressBarSmall);
			this.Controls.Add(this.lblDurationSmall);
			this.Controls.Add(this.lblTrackNameSmall);
			this.Controls.Add(this.lblArtistNameSmall);
			this.Controls.Add(this.lblAlbumNameSmall);
			this.Controls.Add(this.btnUnMaximize);
			this.Controls.Add(this.lblDuration);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblAlbumName);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblArtistName);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.lblTrackName);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AlbumArtForm";
			this.Text = "Album-Art View";
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenSaverForm_KeyDown);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
			this.Load += new System.EventHandler(this.AlbumArtForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		public ID3Lib.TrackInfo TrackInfo
		{
			get { return this.trackInfo; }
			set
			{
				try
				{
					this.trackInfo = value;
					DisplayTrackInfo(trackInfo);
				}
				catch
				{
					CloseForm();
				}
			}
		}

		public delegate void Display(ID3Lib.TrackInfo trackInfo);

		public delegate void UpdateDuration(double duration, string durationString, string url);

		public Display DisplayNextTrack;

		public UpdateDuration StartDurationCounter;

		public void SetTrackInfo(ID3Lib.TrackInfo trackInfo)
		{
			this.TrackInfo = trackInfo;
			this.Show();
		}

		public void SetDuration(double duration, string durationString, string url)
		{
			startTime = DateTime.Now;
			playTime = TimeSpan.Zero;

			if (durationString.StartsWith("00"))
			{
				durationString = durationString.Substring(1);
			}

			lblDuration.Text = "0:00/" + durationString;
			lblDuration.Visible = true;
			lblDuration.Top = this.progressBar1.Top - (lblDuration.Height);
			lblDuration.Left = (progressBar1.Left + progressBar1.Width) - lblDuration.Width;
			lblDurationSmall.Left = (progressBarSmall.Left + progressBarSmall.Width) - lblDurationSmall.Width;

			progressBar1.Maximum = progressBarSmall.Maximum = (int)duration;
			PlaySecondsTimer.Enabled = true;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			CloseForm();
		}

		private void PlaySecondsTimer_Tick(object sender, EventArgs e)
		{
			int currentPosition = (int)MediaPlayerAccessLayer.GetCurrentPosition();
			if (currentPosition < progressBar1.Maximum)
			{
				this.progressBar1.Value = progressBarSmall.Value = currentPosition;
				string[] split = lblDuration.Text.Split('/');
				split[0] = MediaPlayerAccessLayer.GetCurrentPositionString();

				while (split[1].StartsWith("0"))
				{
					split[1] = split[1].Substring(1);
				}

				if (split[1].StartsWith(":"))
				{
					split[1] = "0" + split[1];
				}

				lblDuration.Text = lblDurationSmall.Text = String.Join("/", split);
				lblDurationSmall.Left = (progressBarSmall.Left + progressBarSmall.Width) - lblDurationSmall.Width;
				lblDuration.Left = (progressBar1.Left + progressBar1.Width) - lblDuration.Width;
			}
			else
			{
				progressBar1.Value = progressBarSmall.Value = progressBar1.Maximum;
			}
		}

		private void btnUnMaximize_Click(object sender, EventArgs e)
		{
			if (isMaximized)
				UnMaximizeForm();
			else
				MaximizeForm();
		}

		public event MediaControlEventHandler MediaControlClicked;

		public void OnMediaControlClicked(string action)
		{
			if (MediaControlClicked != null)
			{
				MediaControlClicked(action);
			}
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			OnMediaControlClicked("Previous");
		}

		private void btnPausePlay_Click(object sender, EventArgs e)
		{
			OnMediaControlClicked((string)btnPausePlay.Tag);
			if ((string)btnPausePlay.Tag == "Pause")
			{
				btnPausePlay.Tag = "Play";
				btnPausePlay.ImageIndex = 3;
			}
			else
			{
				btnPausePlay.Tag = "Pause";
				btnPausePlay.ImageIndex = 2;
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			OnMediaControlClicked("Next");
		}

		private void btnVolumeUp_Click(object sender, EventArgs e)
		{
			OnMediaControlClicked("VolumeUp");
		}

		private void btnVolumeDown_Click(object sender, EventArgs e)
		{
			OnMediaControlClicked("VolumeDown");
		}


		~AlbumArtForm()
		{
			if (origScreenSaveSetting != null)
			{
				regkeyScreenSaver.SetValue("ScreenSaveActive", origScreenSaveSetting);
			}
		}
	}
}
