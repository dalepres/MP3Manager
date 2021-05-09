namespace Preston.Media
{
	partial class Mp3Manager
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mp3Manager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.btnCopyFromDisk = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.chkCopyFiles = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.btnBrowseDestination = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMaxDiskSize = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbFromFile = new System.Windows.Forms.RadioButton();
            this.rbFromDisk = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEmbedFolderImage = new System.Windows.Forms.CheckBox();
            this.chkCopyFolderImage = new System.Windows.Forms.CheckBox();
            this.chkDuplicateFolders = new System.Windows.Forms.CheckBox();
            this.chkSequence = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCopyFromPlaylist = new System.Windows.Forms.Button();
            this.cbPlayLists = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tvwLibrary = new System.Windows.Forms.TreeView();
            this.cmsTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditTrackTags = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRenameFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRenameTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEmbedPicture = new System.Windows.Forms.ToolStripButton();
            this.tsbFixAlbumArtist = new System.Windows.Forms.ToolStripButton();
            this.tsbBulkUpdateTags = new System.Windows.Forms.ToolStripButton();
            this.tsbCopyLibrary = new System.Windows.Forms.ToolStripButton();
            this.tsbSetAlbumFolderNames = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTagEditor = new System.Windows.Forms.ToolStripButton();
            this.tsbBackupTag = new System.Windows.Forms.ToolStripButton();
            this.tsbCheckForV22Tags = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumArtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmbedPictures = new System.Windows.Forms.ToolStripMenuItem();
            this.fixAlbumArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBulkUpdateTags = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTagEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackupTrackTags = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRestoreTrackTags = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPlayerManager = new System.Windows.Forms.TabPage();
            this.chkRandomize = new System.Windows.Forms.CheckBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tpTagView = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTrackList = new System.Windows.Forms.TextBox();
            this.dsLibrary = new Preston.Media.DSLibrary();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDiskSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cmsTreeView.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPlayerManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Location = new System.Drawing.Point(26, 162);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(295, 20);
            this.txtDestinationFolder.TabIndex = 1;
            this.txtDestinationFolder.Text = "d:\\cds\\";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(26, 41);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(295, 20);
            this.txtSourceFolder.TabIndex = 2;
            // 
            // btnCopyFromDisk
            // 
            this.btnCopyFromDisk.Location = new System.Drawing.Point(425, 38);
            this.btnCopyFromDisk.Name = "btnCopyFromDisk";
            this.btnCopyFromDisk.Size = new System.Drawing.Size(75, 23);
            this.btnCopyFromDisk.TabIndex = 3;
            this.btnCopyFromDisk.Text = "Execute";
            this.btnCopyFromDisk.Click += new System.EventHandler(this.btnCopyFromDisk_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(378, 112);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkCopyFiles
            // 
            this.chkCopyFiles.AutoSize = true;
            this.chkCopyFiles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCopyFiles.Location = new System.Drawing.Point(5, 45);
            this.chkCopyFiles.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.chkCopyFiles.Name = "chkCopyFiles";
            this.chkCopyFiles.Size = new System.Drawing.Size(150, 17);
            this.chkCopyFiles.TabIndex = 5;
            this.chkCopyFiles.Text = "Copy Files to Disk Folders:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Root Source Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Root Destination Folder:";
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(327, 39);
            this.btnBrowseSource.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSource.TabIndex = 8;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Location = new System.Drawing.Point(327, 160);
            this.btnBrowseDestination.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDestination.TabIndex = 9;
            this.btnBrowseDestination.Text = "Browse";
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "xml";
            this.sfd.Filter = "XML files|*.xml|All files|*.*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Maximum Disk Space (MB):";
            // 
            // nudMaxDiskSize
            // 
            this.nudMaxDiskSize.Location = new System.Drawing.Point(150, 101);
            this.nudMaxDiskSize.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.nudMaxDiskSize.Maximum = new decimal(new int[] {
            130000,
            0,
            0,
            0});
            this.nudMaxDiskSize.Name = "nudMaxDiskSize";
            this.nudMaxDiskSize.Size = new System.Drawing.Size(60, 20);
            this.nudMaxDiskSize.TabIndex = 11;
            this.nudMaxDiskSize.Value = new decimal(new int[] {
            16200,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(378, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbFromFile
            // 
            this.rbFromFile.AutoSize = true;
            this.rbFromFile.Location = new System.Drawing.Point(107, 18);
            this.rbFromFile.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.rbFromFile.Name = "rbFromFile";
            this.rbFromFile.Size = new System.Drawing.Size(41, 17);
            this.rbFromFile.TabIndex = 13;
            this.rbFromFile.Text = "File";
            // 
            // rbFromDisk
            // 
            this.rbFromDisk.AutoSize = true;
            this.rbFromDisk.Checked = true;
            this.rbFromDisk.Location = new System.Drawing.Point(151, 18);
            this.rbFromDisk.Name = "rbFromDisk";
            this.rbFromDisk.Size = new System.Drawing.Size(46, 17);
            this.rbFromDisk.TabIndex = 14;
            this.rbFromDisk.TabStop = true;
            this.rbFromDisk.Text = "Disk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Load Library From:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(378, 20);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEmbedFolderImage);
            this.groupBox1.Controls.Add(this.chkCopyFolderImage);
            this.groupBox1.Controls.Add(this.chkDuplicateFolders);
            this.groupBox1.Controls.Add(this.chkSequence);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.rbFromDisk);
            this.groupBox1.Controls.Add(this.rbFromFile);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.nudMaxDiskSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkCopyFiles);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 151);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chkEmbedFolderImage
            // 
            this.chkEmbedFolderImage.AutoSize = true;
            this.chkEmbedFolderImage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEmbedFolderImage.Location = new System.Drawing.Point(239, 102);
            this.chkEmbedFolderImage.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.chkEmbedFolderImage.Name = "chkEmbedFolderImage";
            this.chkEmbedFolderImage.Size = new System.Drawing.Size(123, 17);
            this.chkEmbedFolderImage.TabIndex = 22;
            this.chkEmbedFolderImage.Text = "Embed Folder Image";
            // 
            // chkCopyFolderImage
            // 
            this.chkCopyFolderImage.AutoSize = true;
            this.chkCopyFolderImage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCopyFolderImage.Enabled = false;
            this.chkCopyFolderImage.Location = new System.Drawing.Point(248, 74);
            this.chkCopyFolderImage.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.chkCopyFolderImage.Name = "chkCopyFolderImage";
            this.chkCopyFolderImage.Size = new System.Drawing.Size(114, 17);
            this.chkCopyFolderImage.TabIndex = 21;
            this.chkCopyFolderImage.Text = "Copy Folder Image";
            // 
            // chkDuplicateFolders
            // 
            this.chkDuplicateFolders.AutoSize = true;
            this.chkDuplicateFolders.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDuplicateFolders.Location = new System.Drawing.Point(213, 45);
            this.chkDuplicateFolders.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.chkDuplicateFolders.Name = "chkDuplicateFolders";
            this.chkDuplicateFolders.Size = new System.Drawing.Size(149, 17);
            this.chkDuplicateFolders.TabIndex = 20;
            this.chkDuplicateFolders.Text = "Duplicate Folder Structure";
            this.chkDuplicateFolders.CheckedChanged += new System.EventHandler(this.chkDuplicateFolders_CheckedChanged);
            // 
            // chkSequence
            // 
            this.chkSequence.AutoSize = true;
            this.chkSequence.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSequence.Checked = true;
            this.chkSequence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSequence.Location = new System.Drawing.Point(6, 74);
            this.chkSequence.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.chkSequence.Name = "chkSequence";
            this.chkSequence.Size = new System.Drawing.Size(172, 17);
            this.chkSequence.TabIndex = 19;
            this.chkSequence.Text = "Include Sequence in filename?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCopyFromPlaylist);
            this.groupBox2.Controls.Add(this.cbPlayLists);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDestinationFolder);
            this.groupBox2.Controls.Add(this.btnBrowseDestination);
            this.groupBox2.Controls.Add(this.btnBrowseSource);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSourceFolder);
            this.groupBox2.Controls.Add(this.btnCopyFromDisk);
            this.groupBox2.Location = new System.Drawing.Point(6, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 205);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnCopyFromPlaylist
            // 
            this.btnCopyFromPlaylist.Location = new System.Drawing.Point(425, 101);
            this.btnCopyFromPlaylist.Name = "btnCopyFromPlaylist";
            this.btnCopyFromPlaylist.Size = new System.Drawing.Size(75, 23);
            this.btnCopyFromPlaylist.TabIndex = 12;
            this.btnCopyFromPlaylist.Text = "Execute";
            this.btnCopyFromPlaylist.Click += new System.EventHandler(this.btnCopyFromPlaylist_Click);
            // 
            // cbPlayLists
            // 
            this.cbPlayLists.FormattingEnabled = true;
            this.cbPlayLists.Location = new System.Drawing.Point(26, 103);
            this.cbPlayLists.Name = "cbPlayLists";
            this.cbPlayLists.Size = new System.Drawing.Size(376, 21);
            this.cbPlayLists.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "PlayList:";
            // 
            // tvwLibrary
            // 
            this.tvwLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwLibrary.Location = new System.Drawing.Point(0, 0);
            this.tvwLibrary.Name = "tvwLibrary";
            this.tvwLibrary.Size = new System.Drawing.Size(263, 400);
            this.tvwLibrary.TabIndex = 19;
            this.tvwLibrary.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwLibrary_BeforeExpand);
            // 
            // cmsTreeView
            // 
            this.cmsTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditTrackTags,
            this.tsmiRenameFile,
            this.tsmiRenameTrack,
            this.tsmiPlayTrack});
            this.cmsTreeView.Name = "cmsTreeView";
            this.cmsTreeView.Size = new System.Drawing.Size(151, 92);
            this.cmsTreeView.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTreeView_Opening);
            this.cmsTreeView.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsTrack_ItemClicked);
            // 
            // tsmiEditTrackTags
            // 
            this.tsmiEditTrackTags.Name = "tsmiEditTrackTags";
            this.tsmiEditTrackTags.Size = new System.Drawing.Size(150, 22);
            this.tsmiEditTrackTags.Text = "Edit Track Tags";
            // 
            // tsmiRenameFile
            // 
            this.tsmiRenameFile.Name = "tsmiRenameFile";
            this.tsmiRenameFile.Size = new System.Drawing.Size(150, 22);
            this.tsmiRenameFile.Text = "Rename File";
            // 
            // tsmiRenameTrack
            // 
            this.tsmiRenameTrack.Name = "tsmiRenameTrack";
            this.tsmiRenameTrack.Size = new System.Drawing.Size(150, 22);
            this.tsmiRenameTrack.Text = "Rename Track";
            // 
            // tsmiPlayTrack
            // 
            this.tsmiPlayTrack.Name = "tsmiPlayTrack";
            this.tsmiPlayTrack.Size = new System.Drawing.Size(150, 22);
            this.tsmiPlayTrack.Text = "Play Track";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEmbedPicture,
            this.tsbFixAlbumArtist,
            this.tsbBulkUpdateTags,
            this.tsbCopyLibrary,
            this.tsbSetAlbumFolderNames,
            this.toolStripSeparator1,
            this.tsbTagEditor,
            this.tsbBackupTag,
            this.tsbCheckForV22Tags});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbEmbedPicture
            // 
            this.tsbEmbedPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEmbedPicture.Image = ((System.Drawing.Image)(resources.GetObject("tsbEmbedPicture.Image")));
            this.tsbEmbedPicture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEmbedPicture.Name = "tsbEmbedPicture";
            this.tsbEmbedPicture.Size = new System.Drawing.Size(23, 22);
            this.tsbEmbedPicture.Text = "Embed Pictures";
            this.tsbEmbedPicture.Click += new System.EventHandler(this.tsbEmbedPicture_Click);
            // 
            // tsbFixAlbumArtist
            // 
            this.tsbFixAlbumArtist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFixAlbumArtist.Image = global::Preston.Media.Properties.Resources.AlbumArtistButtonImage;
            this.tsbFixAlbumArtist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFixAlbumArtist.Name = "tsbFixAlbumArtist";
            this.tsbFixAlbumArtist.Size = new System.Drawing.Size(23, 22);
            this.tsbFixAlbumArtist.Text = "Fix Album Artist";
            this.tsbFixAlbumArtist.Click += new System.EventHandler(this.tsbFixAlbumArtist_Click);
            // 
            // tsbBulkUpdateTags
            // 
            this.tsbBulkUpdateTags.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBulkUpdateTags.Image = ((System.Drawing.Image)(resources.GetObject("tsbBulkUpdateTags.Image")));
            this.tsbBulkUpdateTags.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBulkUpdateTags.Name = "tsbBulkUpdateTags";
            this.tsbBulkUpdateTags.Size = new System.Drawing.Size(23, 22);
            this.tsbBulkUpdateTags.Text = "Bulk Update Tags";
            this.tsbBulkUpdateTags.Click += new System.EventHandler(this.tsbBulkUpdateTags_Click);
            // 
            // tsbCopyLibrary
            // 
            this.tsbCopyLibrary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopyLibrary.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopyLibrary.Image")));
            this.tsbCopyLibrary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopyLibrary.Name = "tsbCopyLibrary";
            this.tsbCopyLibrary.Size = new System.Drawing.Size(23, 22);
            this.tsbCopyLibrary.Text = "Copy Library";
            this.tsbCopyLibrary.Click += new System.EventHandler(this.tsbCopyLibrary_Click);
            // 
            // tsbSetAlbumFolderNames
            // 
            this.tsbSetAlbumFolderNames.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSetAlbumFolderNames.Image = ((System.Drawing.Image)(resources.GetObject("tsbSetAlbumFolderNames.Image")));
            this.tsbSetAlbumFolderNames.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSetAlbumFolderNames.Name = "tsbSetAlbumFolderNames";
            this.tsbSetAlbumFolderNames.Size = new System.Drawing.Size(23, 22);
            this.tsbSetAlbumFolderNames.Text = "Set Album Folder Names";
            this.tsbSetAlbumFolderNames.Click += new System.EventHandler(this.tsbSetAlbumFolderNames_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbTagEditor
            // 
            this.tsbTagEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTagEditor.Image = ((System.Drawing.Image)(resources.GetObject("tsbTagEditor.Image")));
            this.tsbTagEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTagEditor.Name = "tsbTagEditor";
            this.tsbTagEditor.Size = new System.Drawing.Size(23, 22);
            this.tsbTagEditor.Text = "toolStripButton1";
            this.tsbTagEditor.ToolTipText = "Open track tag editor";
            this.tsbTagEditor.Click += new System.EventHandler(this.tsbTagEditor_Click);
            // 
            // tsbBackupTag
            // 
            this.tsbBackupTag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBackupTag.Image = ((System.Drawing.Image)(resources.GetObject("tsbBackupTag.Image")));
            this.tsbBackupTag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBackupTag.Name = "tsbBackupTag";
            this.tsbBackupTag.Size = new System.Drawing.Size(23, 22);
            this.tsbBackupTag.Text = "Backup or Remove Track Tags";
            this.tsbBackupTag.Click += new System.EventHandler(this.tsbBackupTag_Click);
            // 
            // tsbCheckForV22Tags
            // 
            this.tsbCheckForV22Tags.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCheckForV22Tags.Image = ((System.Drawing.Image)(resources.GetObject("tsbCheckForV22Tags.Image")));
            this.tsbCheckForV22Tags.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheckForV22Tags.Name = "tsbCheckForV22Tags";
            this.tsbCheckForV22Tags.Size = new System.Drawing.Size(23, 22);
            this.tsbCheckForV22Tags.Text = "Check for V2.2 Tags";
            this.tsbCheckForV22Tags.Click += new System.EventHandler(this.tsbCheckForV22Tags_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.libraryToolStripMenuItem,
            this.tsmiTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumArtToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // albumArtToolStripMenuItem
            // 
            this.albumArtToolStripMenuItem.Name = "albumArtToolStripMenuItem";
            this.albumArtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.albumArtToolStripMenuItem.Text = "Album Art";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromDiskToolStripMenuItem,
            this.playToolStripMenuItem});
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "Library";
            // 
            // loadFromDiskToolStripMenuItem
            // 
            this.loadFromDiskToolStripMenuItem.Name = "loadFromDiskToolStripMenuItem";
            this.loadFromDiskToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.loadFromDiskToolStripMenuItem.Text = "Load From Disk";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmbedPictures,
            this.fixAlbumArtistToolStripMenuItem,
            this.tsmiBulkUpdateTags,
            this.tsmiTagEditor,
            this.tsmiBackupTrackTags,
            this.tsmiRestoreTrackTags});
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(46, 20);
            this.tsmiTools.Text = "Tools";
            // 
            // tsmiEmbedPictures
            // 
            this.tsmiEmbedPictures.Name = "tsmiEmbedPictures";
            this.tsmiEmbedPictures.Size = new System.Drawing.Size(169, 22);
            this.tsmiEmbedPictures.Text = "Embed Pictures";
            // 
            // fixAlbumArtistToolStripMenuItem
            // 
            this.fixAlbumArtistToolStripMenuItem.Name = "fixAlbumArtistToolStripMenuItem";
            this.fixAlbumArtistToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.fixAlbumArtistToolStripMenuItem.Text = "Fix Album Artist";
            // 
            // tsmiBulkUpdateTags
            // 
            this.tsmiBulkUpdateTags.Name = "tsmiBulkUpdateTags";
            this.tsmiBulkUpdateTags.Size = new System.Drawing.Size(169, 22);
            this.tsmiBulkUpdateTags.Text = "Bulk Update Tags";
            // 
            // tsmiTagEditor
            // 
            this.tsmiTagEditor.Name = "tsmiTagEditor";
            this.tsmiTagEditor.Size = new System.Drawing.Size(169, 22);
            this.tsmiTagEditor.Text = "Tag Editor";
            // 
            // tsmiBackupTrackTags
            // 
            this.tsmiBackupTrackTags.Name = "tsmiBackupTrackTags";
            this.tsmiBackupTrackTags.Size = new System.Drawing.Size(169, 22);
            this.tsmiBackupTrackTags.Text = "Backup Track Tags";
            this.tsmiBackupTrackTags.Click += new System.EventHandler(this.tsmiBackupTrackTags_Click);
            // 
            // tsmiRestoreTrackTags
            // 
            this.tsmiRestoreTrackTags.Name = "tsmiRestoreTrackTags";
            this.tsmiRestoreTrackTags.Size = new System.Drawing.Size(169, 22);
            this.tsmiRestoreTrackTags.Text = "Restore Track Tags";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPlayerManager);
            this.tabControl1.Controls.Add(this.tpTagView);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 400);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(520, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(514, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPlayerManager
            // 
            this.tabPlayerManager.Controls.Add(this.chkRandomize);
            this.tabPlayerManager.Controls.Add(this.btnPlay);
            this.tabPlayerManager.Controls.Add(this.label5);
            this.tabPlayerManager.Location = new System.Drawing.Point(4, 22);
            this.tabPlayerManager.Name = "tabPlayerManager";
            this.tabPlayerManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayerManager.Size = new System.Drawing.Size(520, 374);
            this.tabPlayerManager.TabIndex = 2;
            this.tabPlayerManager.Text = "Player Manager";
            this.tabPlayerManager.UseVisualStyleBackColor = true;
            // 
            // chkRandomize
            // 
            this.chkRandomize.AutoSize = true;
            this.chkRandomize.Location = new System.Drawing.Point(277, 32);
            this.chkRandomize.Name = "chkRandomize";
            this.chkRandomize.Size = new System.Drawing.Size(79, 17);
            this.chkRandomize.TabIndex = 3;
            this.chkRandomize.Text = "Randomize";
            this.chkRandomize.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(380, 26);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Existing Playlists";
            // 
            // tpTagView
            // 
            this.tpTagView.AutoScroll = true;
            this.tpTagView.Location = new System.Drawing.Point(4, 22);
            this.tpTagView.Name = "tpTagView";
            this.tpTagView.Padding = new System.Windows.Forms.Padding(3);
            this.tpTagView.Size = new System.Drawing.Size(520, 374);
            this.tpTagView.TabIndex = 3;
            this.tpTagView.Text = "Track Tag";
            this.tpTagView.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvwLibrary);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(795, 400);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 23;
            // 
            // txtTrackList
            // 
            this.txtTrackList.BackColor = System.Drawing.Color.White;
            this.txtTrackList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTrackList.Location = new System.Drawing.Point(0, 449);
            this.txtTrackList.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txtTrackList.MaxLength = 0;
            this.txtTrackList.Multiline = true;
            this.txtTrackList.Name = "txtTrackList";
            this.txtTrackList.ReadOnly = true;
            this.txtTrackList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTrackList.Size = new System.Drawing.Size(795, 100);
            this.txtTrackList.TabIndex = 0;
            // 
            // dsLibrary
            // 
            this.dsLibrary.DataSetName = "DSLibrary";
            this.dsLibrary.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsLibrary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Mp3Manager
            // 
            this.ClientSize = new System.Drawing.Size(795, 549);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtTrackList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mp3Manager";
            this.Text = "Mp3Manager";
            this.Load += new System.EventHandler(this.Mp3DiskMaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDiskSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cmsTreeView.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPlayerManager.ResumeLayout(false);
            this.tabPlayerManager.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.TextBox txtDestinationFolder;
		private System.Windows.Forms.TextBox txtSourceFolder;
		private System.Windows.Forms.Button btnCopyFromDisk;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.CheckBox chkCopyFiles;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBrowseSource;
		private System.Windows.Forms.Button btnBrowseDestination;
		private System.Windows.Forms.FolderBrowserDialog fbd;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudMaxDiskSize;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.RadioButton rbFromFile;
		private System.Windows.Forms.RadioButton rbFromDisk;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TreeView tvwLibrary;
		private DSLibrary dsLibrary;
        private System.Windows.Forms.ContextMenuStrip cmsTreeView;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenameFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenameTrack;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayTrack;
        private System.Windows.Forms.CheckBox chkSequence;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbEmbedPicture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkDuplicateFolders;
        private System.Windows.Forms.CheckBox chkCopyFolderImage;
        private System.Windows.Forms.CheckBox chkEmbedFolderImage;
        private System.Windows.Forms.TextBox txtTrackList;
        private System.Windows.Forms.ToolStripButton tsbFixAlbumArtist;
        private System.Windows.Forms.ToolStripButton tsbBulkUpdateTags;
        private System.Windows.Forms.ToolStripButton tsbCopyLibrary;
		private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromDiskToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton tsbSetAlbumFolderNames;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem albumArtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPlayerManager;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.CheckBox chkRandomize;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tpTagView;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbTagEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditTrackTags;
        private System.Windows.Forms.ToolStripButton tsbBackupTag;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmbedPictures;
        private System.Windows.Forms.ToolStripMenuItem fixAlbumArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBulkUpdateTags;
        private System.Windows.Forms.ToolStripMenuItem tsmiTagEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackupTrackTags;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestoreTrackTags;
        private System.Windows.Forms.ToolStripButton tsbCheckForV22Tags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPlayLists;
        private System.Windows.Forms.Button btnCopyFromPlaylist;
    }
}