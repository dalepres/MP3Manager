#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ID3Lib;



#endregion

namespace MusicDiskMaker
{
	partial class Mp3DiskMaker : Form
	{
		private TreeNode rootNode;
		private TreeNode albumsNode;
		private TreeNode artistsNode;
		private TreeNode tracksNode;
		private bool stop = false;

		public delegate void UpdateStatusDisplay(string s);
		UpdateStatusDisplay updatedisplay;

		public Mp3DiskMaker()
		{
			InitializeComponent();
			this.txtSourceFolder.Text = Properties.Settings.Default.SourceFolder;
		}

		private void ClearData()
		{
			return;
		}

		private void btnExecute_Click(object sender, EventArgs e)
		{
			btnExecute.Enabled = false;

			string[] files = Directory.GetFiles(this.txtSourceFolder.Text, "*.mp3", SearchOption.AllDirectories);

			List<int> copiedFiles = new List<int>();
			Random rnd = new Random();
			long maxDiskSize = Convert.ToInt64(nudMaxDiskSize.Value) * 1024L * 1024L;
			long diskSize = 0L;
			string fileName;
			int fileNumber;
			string sequenceString;
            int fileCount = 0;

			do
			{
				fileNumber = rnd.Next(files.Length);
				while (copiedFiles.IndexOf(fileNumber) > -1)
				{
					fileNumber = rnd.Next(files.Length);
				}

				copiedFiles.Add(fileNumber);

				fileName = files[fileNumber];

				if (!Directory.Exists(txtDestinationFolder.Text))
				{
					Directory.CreateDirectory(txtDestinationFolder.Text);
				}

				string trackPath = Path.GetDirectoryName(fileName);
				string albumArtist = Directory.GetParent(trackPath).Name;

				Track track = new Track();
				track.AlbumArtist = albumArtist;
				track.FullFilePath = fileName;

				if (this.chkSequence.Checked)
				{
					sequenceString = (++fileCount).ToString() + "[-]";
				}
				else
				{
					sequenceString = string.Empty;
				}

				diskSize += CDTagger.Instance.TagForCD(track,
					GetDestinationFolder(fileName),
					sequenceString + Path.GetFileName(fileName),
					this.chkEmbedFolderImage.Checked,
					false);
			} while (diskSize < maxDiskSize);

            btnExecute.Enabled = true;
		}


		private string GetDestinationFolder(string fileName)
		{
			string newSubFolder = string.Empty;
			string destinationFolder = txtDestinationFolder.Text.Trim();


			if (this.chkDuplicateFolders.Checked)
			{
				newSubFolder = Path.GetDirectoryName(fileName).Substring(txtSourceFolder.Text.Trim().Length);
				destinationFolder += newSubFolder;
			}

			if (!Directory.Exists(destinationFolder))
			{
				Directory.CreateDirectory(destinationFolder);

				if (chkCopyFolderImage.Checked)
				{
					CopyFolderImage(Path.GetDirectoryName(fileName), destinationFolder);
				}
			}

			return destinationFolder;
		}


		private void CopyFolderImage(string sourceFolder, string destinationFolder)
		{
			string sourceFile = Path.Combine(sourceFolder, "Folder.jpg");
			string destinationFile = Path.Combine(destinationFolder, "Folder.jpg");

			if (File.Exists(sourceFile) && (!File.Exists(destinationFile)))
			{
				File.Copy(sourceFile, destinationFile);
			}
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			string xmlPath = Application.StartupPath;
			dsLibrary.WriteXml(xmlPath + "\\MyMusic.xml", XmlWriteMode.WriteSchema);
			MessageBox.Show("Done exporting to XML");
		}

		private void btnBrowseSource_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(txtSourceFolder.Text.Trim()))
			{
				fbd.SelectedPath = txtSourceFolder.Text.Trim();
			}
			fbd.Description = "Choose the root source folder to create your MP3 disks from.";
			fbd.ShowNewFolderButton = false;
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				txtSourceFolder.Text = fbd.SelectedPath;
				if (!txtSourceFolder.Text.EndsWith("\\"))
				{
					txtSourceFolder.Text += "\\";
				}
			}

		}

		private void btnBrowseDestination_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(txtDestinationFolder.Text.Trim()))
			{
				fbd.SelectedPath = txtDestinationFolder.Text.Trim();
			}
			fbd.Description = "Choose the root destination folder in which to create your MP3 disks.";
			fbd.ShowNewFolderButton = true;
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				txtDestinationFolder.Text = fbd.SelectedPath;
				if (!txtDestinationFolder.Text.EndsWith("\\"))
				{
					txtDestinationFolder.Text += "\\";
				}
			}

		}

		private void LoadFromFile()
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Filter = "XML Files|*.xml|All Files|*.*";
				ofd.InitialDirectory = Application.StartupPath;
				try
				{
					if (ofd.ShowDialog() != DialogResult.Cancel)
					{
						dsLibrary.ReadXml(ofd.FileName, XmlReadMode.IgnoreSchema);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Unable to load "
						+ ofd.FileName
						+ ".  The error is: "
						+ System.Environment.NewLine
						+ System.Environment.NewLine
						+ ex.Message,
						"Error opening XML Music Library file.");
					dsLibrary = new DSLibrary();
				}
			}
		}


		private void LoadFromDisk2()
		{
			Random random = new Random();
			string[] artists = Directory.GetDirectories(txtSourceFolder.Text);
			foreach (string artistDirectory in artists)
			{
				Application.DoEvents();
				if (stop)
				{
					ClearData();
					return;
				}
				DirectoryInfo artistInfo = new DirectoryInfo(artistDirectory);

				DSLibrary.ArtistsRow drArtist = (DSLibrary.ArtistsRow)dsLibrary.Artists.NewRow();
				drArtist.ArtistName = artistInfo.Name;
				dsLibrary.Artists.Rows.Add(drArtist);
				int artistID = drArtist.ArtistID;
				string[] albums = Directory.GetDirectories(artistDirectory);
				foreach (string albumDirectory in albums)
				{
					Application.DoEvents();
					if (stop)
					{
						ClearData();
						return;
					}
					DirectoryInfo albumInfo = new DirectoryInfo(albumDirectory);
					DSLibrary.AlbumsRow drAlbum = (DSLibrary.AlbumsRow)dsLibrary.Albums.NewRow();
					drAlbum.AlbumName = albumInfo.Name;
					drAlbum.ArtistID = artistID;
					dsLibrary.Albums.Rows.Add(drAlbum);
					int albumID = drAlbum.AlbumID;
					string[] tracks = Directory.GetFiles(albumDirectory, "*.mp3");
					EditTrackFilenameForm form = new EditTrackFilenameForm();

					for (int count = 0; count < tracks.Length; count++)
					{
						string track = tracks[count];

						Application.DoEvents();

						string fileName = Path.GetFileName(track);
						if (fileName.Contains("[") || fileName.Contains("]"))
						{
							form.SetFormData(track, EditTrackFilenameForm.GuessNewFileName(fileName));
							DialogResult result = form.ShowDialog();

							if (result == DialogResult.OK)
							{
								track = form.GetNewFullFileName();
								tracks[count] = track;
							}

							Application.DoEvents();
						}

						if (stop)
						{
							ClearData();
							return;
						}
						DSLibrary.TracksRow drTrack = (DSLibrary.TracksRow)dsLibrary.Tracks.NewRow();
						FileInfo trackInfo = new FileInfo(track);
						drTrack.TrackName = trackInfo.Name;
						drTrack.AlbumID = albumID;
						drTrack.ArtistID = artistID;
						drTrack.FileName = track;
						drTrack.FileSize = trackInfo.Length;
						drTrack.Sequence = random.Next(1000, 10000000);
						dsLibrary.Tracks.Rows.Add(drTrack);
						int trackID = drTrack.TrackID;
					}

					form.Close();
					form.Dispose();
				}
			}
		}

		private void LoadFromDisk()
		{
			Random random = new Random();
			string[] artists = Directory.GetDirectories(txtSourceFolder.Text);
			foreach (string artistDirectory in artists)
			{
				TreeNode artistNode = new ArtistNode();
				artistNode.Text = new DirectoryInfo(artistDirectory).Name;
				artistNode.Tag = artistDirectory;
				GetAlbums(artistNode, false);
				if (artistNode.Nodes.Count > 0)
				{
					artistsNode.Nodes.Add(artistNode);
				}
			}
		}

		private void GetAlbums(TreeNode artistNode, bool loadTracks)
		{
			artistNode.Nodes.Clear();
			string[] albumFolders = Directory.GetDirectories((string)artistNode.Tag);
			foreach(string albumFolder in albumFolders)
			{
				string[] files = Directory.GetFiles(albumFolder, "*.mp3");
				AlbumNode albumNode = new AlbumNode();
				if (files.Length > 0)
				{
					if (loadTracks)
					{
						for (int count = 0; count < files.Length; count++)
						{
							string file = files[count];
							TrackNode trackNode = new TrackNode();
							ID3Lib.TrackInfo info = new ID3Lib.TrackInfo(file);
							if (count == 0)
							{
								albumNode.Text = info.AlbumName;
							}
							albumNode.Tag = albumFolder;
							trackNode.Text = info.TrackName;
							trackNode.Tag = info;
							trackNode.ContextMenuStrip = cmsTreeView;
							albumNode.Nodes.Add(trackNode);
						}

						artistNode.Nodes.Add(albumNode);
					}
					else
					{
						artistNode.Nodes.Add(new TreeNode());
						return;
					}
				}
			}
		}

		private void LockForm(bool enable)
		{
			foreach (Control c in this.Controls)
			{
				if (c is Button)
				{
					((Button)c).Enabled = enable;
				}
				if (c is TextBox)
				{
					((TextBox)c).Enabled = enable;
				}
				if (c is RadioButton)
				{
					((RadioButton)c).Enabled = enable;
				}
				if (c is CheckBox)
				{
					((CheckBox)c).Enabled = enable;
				}
				if (c is NumericUpDown)
				{
					((NumericUpDown)c).Enabled = enable;
				}
				if (c is TreeView)
				{
					((TreeView)c).Enabled = enable;
				}
			}
		}

		private void btnLoad_Click2(object sender, EventArgs e)
		{
			Cursor cursor = this.Cursor;
			LockForm(false);
			this.Cursor = Cursors.WaitCursor;
			dsLibrary = new DSLibrary();
			this.InitializeTree();
			if (rbFromDisk.Checked)
			{
				LoadFromDisk();
			}
			else
			{
				LoadFromFile();
			}
			LoadTree();
			LockForm(true);
			this.Cursor = cursor;
		}


		private void btnLoad_Click(object sender, EventArgs e)
		{
			Cursor cursor = this.Cursor;
			LockForm(false);
			this.Cursor = Cursors.WaitCursor;
			dsLibrary = new DSLibrary();
			this.InitializeTree();

			LoadFromDisk();
			
			//LoadTree();

			LockForm(true);
			this.Cursor = cursor;
		}
		

		private void Mp3DiskMaker_Load(object sender, EventArgs e)
		{
			//this.cbPlayLists.DataSource = MediaPlayerAccessLayer.Player.GetPlayListsInfo();
			//cbPlayLists.DisplayMember = "Name";
			InitializeTree();
		}

		private void InitializeTree()
		{
			tvwLibrary.Nodes.Clear();
			rootNode = new TreeNode("Music Library");
			tvwLibrary.Nodes.Add(rootNode);

			artistsNode = new TreeNode("Artists");
			rootNode.Nodes.Add(artistsNode);

			albumsNode = new TreeNode("Albums");
			rootNode.Nodes.Add(albumsNode);

			tracksNode = new TreeNode("Tracks");
			rootNode.Nodes.Add(tracksNode);
		}

		private void LoadTree()
		{
			txtTrackList.Clear();
			int artistCount = 0;
			int totalTracks = 0;
			foreach (DSLibrary.ArtistsRow artistsrow in dsLibrary.Artists.Rows)
			{
				artistCount++;
				TreeNode node = new TreeNode (artistsrow.ArtistName);
				node.Tag = artistsrow.ArtistID;
				DataRow[] albumsRows = artistsrow.GetChildRows(dsLibrary.Relations["ArtistAlbums"]);
				int albumCount = 0;
				foreach (DSLibrary.AlbumsRow albumsrow in albumsRows) // artistsrow.GetChildRows(dsLibrary.Relations["ArtistAlbums"]))
				{
					albumCount++;
					TreeNode childnode = new TreeNode (albumsrow.AlbumName);
					childnode.Tag = albumsrow.AlbumID;
					node.Nodes.Add(childnode);
					DataRow[] trackRows = albumsrow.GetChildRows(dsLibrary.Relations["AlbumTrack"]);
					int trackCount = 0;
					foreach (DSLibrary.TracksRow tracksrow in trackRows) //albumsrow.GetChildRows(dsLibrary.Relations["AlbumTrack"]))
					{
						totalTracks++;
						trackCount++;
						TreeNode trackNode = new TreeNode(tracksrow.TrackName);
						trackNode.Tag = tracksrow.TrackID;
						trackNode.ContextMenuStrip = cmsTreeView;
						childnode.Nodes.Add(trackNode);
					}
					TreeNode albumNode = (TreeNode)childnode.Clone();
					albumNode.Text += "(" + trackCount + ")";
					albumsNode.Nodes.Add(albumNode);
				}
				node.Text += "(" + albumCount.ToString() + ")";
				artistsNode.Nodes.Add(node);
			}
			artistsNode.Text += "(" + artistCount.ToString() + ")";
			tracksNode.Text += "(" + totalTracks.ToString() + ")";
		}


		private void cmsTrack_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			ToolStripItem item = e.ClickedItem;
			string itemName = item.Name;
			cmsTreeView.Close();
			TrackNode trackNode = (TrackNode)tvwLibrary.SelectedNode;
			ID3Lib.TrackInfo info = (ID3Lib.TrackInfo)trackNode.Tag;
			switch (item.Name)
			{
				case "tsmiRenameTrack":
					itemName = tsmiRenameFile.Name;
					break;

				case "tsmiRenameFile":
					//ID3Lib.TrackInfo info = (ID3Lib.TrackInfo)tvwLibrary.SelectedNode.Tag;
					MusicDiskMaker.EditTrackFilenameForm form = new EditTrackFilenameForm();
					form.SetFormData(info.FilePath);
					DialogResult result = form.ShowDialog();
					if (result == DialogResult.OK)
					{
						if (form.GetNewFullFileName() != info.FilePath)
						{
							try
							{
								File.Move(info.FilePath, form.GetNewFullFileName());
								if (File.Exists(form.GetNewFullFileName()))
								{
									info = new TrackInfo(form.GetNewFullFileName());
									tvwLibrary.SelectedNode.Tag = info;
								}
							}
							catch (IOException ex)
							{
								MessageBox.Show(
									"Could not rename file.  An error occurred:\n\n" 
									+ ex.Message,
									"Erorr renaming file",
									MessageBoxButtons.OK,
									MessageBoxIcon.Error);
							}
						}
					}
					form.Close();
					form.Dispose();

					itemName = tsmiRenameTrack.Name;
					break;

				case "tsmiPlayTrack" :
					//AlbumArtForm playerForm = new AlbumArtForm(info);
					//playerForm.Show();
					//MediaPlayerAccessLayer.Play(info);
					break;

				default :
					itemName = item.Name;
					break;
			}
		}

		private void cmsTreeView_Opening(object sender, CancelEventArgs e)
		{
			TreeNode node = this.tvwLibrary.GetNodeAt(tvwLibrary.PointToClient(Cursor.Position));
			tvwLibrary.SelectedNode = node;
		}

		private void chkDuplicateFolders_CheckedChanged(object sender, EventArgs e)
		{
			chkCopyFolderImage.Enabled = chkDuplicateFolders.Checked;
		}

		private void tsbEmbedPicture_Click(object sender, EventArgs e)
		{
			EmbedPicturesForm form = new EmbedPicturesForm();
			form.ShowDialog();
		}

		private void tsbFixAlbumArtist_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(txtSourceFolder.Text))
			{
				MessageBox.Show("bad directory.");
				return;
			}
			updatedisplay = new UpdateStatusDisplay(updateTextBox);
			btnCancel.Enabled = true;
			backgroundWorker1.RunWorkerAsync(txtSourceFolder.Text);

			updateTextBox(" --- START ---");
		}

		private void btnCancel_Click(System.Object sender,
			System.EventArgs e)
		{
			// Cancel the asynchronous operation.
			this.backgroundWorker1.CancelAsync();

			// Disable the Cancel button.
			btnCancel.Enabled = false;
		}

		//private void UpdateAlbumArtist(string folderName, BackgroundWorker worker, DoWorkEventArgs e)
		//{
		//    UpdateAlbumArtist(folderName, worker, e);
		//}

		public void updateTextBox(string lineToAdd)
		{
			txtTrackList.Text += "\r\n" + lineToAdd;
			txtTrackList.SelectionStart = txtTrackList.Text.Length;
			txtTrackList.ScrollToCaret();
		}

		private void UpdateAlbumArtist(string folderName, BackgroundWorker worker, DoWorkEventArgs e)
		{
			if (worker.CancellationPending)
			{
				e.Cancel = true;
				return;
			}

			string[] files = Directory.GetFiles(folderName,"*.mp3");
			string[] folders = Directory.GetDirectories(folderName);

			string albumArtistName = Directory.GetParent(folderName).Name;

			if (files.Length > 0)
			{
				this.Invoke(this.updatedisplay,new object[] { folderName });
			}

			foreach (string file in files)
			{
				if (worker.CancellationPending)
				{
					e.Cancel = true;
					return;
				}
				UpdateAlbumArtist(albumArtistName, file);
			}

			foreach (string folder in folders)
			{
				if (worker.CancellationPending)
				{
					e.Cancel = true;
					return;
				}
				UpdateAlbumArtist(folder, worker, e);
			}
		}

		private void UpdateAlbumArtist(string albumArtistName, string fileName)
		{
			Mp3File mp3File = new Mp3File(fileName);
			V1Tag v1Tag = mp3File.GetV1Tag();
			List<V2Tag> v2Tags = mp3File.GetV2Tags();

			V2Tag tag = v2Tags[0];

			IEnumerator<V2Frame> ie = v2Tags[0].Frames["TPE2"];
			while (ie.MoveNext())
			{
				((TPE2TextFrame)ie.Current).Text = albumArtistName;
			}

			mp3File.SaveTags(v2Tags, v1Tag);
		}

		private void tsbBulkUpdateTags_Click(object sender, EventArgs e)
		{
			BulkUpdateTagsForm form = new BulkUpdateTagsForm();
			form.ShowDialog();
		}

		private void tsbCopyLibrary_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(this.txtSourceFolder.Text))
			{
				throw new Exception("bad folder in tsbCopyLibrary_Click.");
			}

			if (!Directory.Exists(this.txtDestinationFolder.Text))
			{
				Directory.CreateDirectory(this.txtDestinationFolder.Text);
			}

			CopyFolder(txtSourceFolder.Text);
		}

		private void CopyFolder(string source)
		{
			string[] files = Directory.GetFiles(source);
			string[] folders = Directory.GetDirectories(source);

			for (int count = 0; count < files.Length; count++)
			{
				string file = files[count];
				string destination = file.Replace(txtSourceFolder.Text, txtDestinationFolder.Text);

				if (count == 0)
				{
					string newFolder = Path.GetDirectoryName(destination);
					if (!Directory.Exists(newFolder))
						Directory.CreateDirectory(newFolder);
				}

				try
				{
					File.Copy(file, destination);
				}
				catch
				{
				}
			}

			foreach (string folder in folders)
			{
				CopyFolder(folder);
			}
			
		}


		private void tvwLibrary_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node is ArtistNode)
			{
				string folder = (string)e.Node.Tag;
				GetAlbums(e.Node, true);
			}
		}

		private void tsbSetAlbumFolderNames_Click(object sender, EventArgs e)
		{
			string sourcePath = txtSourceFolder.Text;
			if (!Directory.Exists(sourcePath))
			{
				throw new FileNotFoundException();
			}

			string[] artists = Directory.GetDirectories(sourcePath);
			foreach (string artist in artists)
			{
				Mp3File.SetArtistsAlbumFolderName(artist);
			}
		}

		//private void albumArtToolStripMenuItem_Click(object sender, EventArgs e)
		//{
		//    MediaPlayerAccessLayer.ShowArt();
		//}

		//private void playToolStripMenuItem_Click(object sender, EventArgs e)
		//{
		//    MediaPlayerAccessLayer.PlayLibrary(this.txtSourceFolder.Text);
		//}

		//private void btnPlay_Click(object sender, EventArgs e)
		//{
		//    MediaPlayerAccessLayer.PlayPlayList(((PlayListInfo)cbPlayLists.SelectedValue), chkRandomize.Checked);
		//}

		//private void chkRandomize_CheckedChanged(object sender, EventArgs e)
		//{
		//    MediaPlayerAccessLayer.SetRandomize(chkRandomize.Checked);
		//}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			UpdateAlbumArtist((string)e.Argument, (BackgroundWorker)sender, e);
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			string result = " **** DONE **** ";

			if (e.Cancelled)
			{
				result = result.Replace("DONE", "CANCELLED");
			}
			this.Invoke(updatedisplay, new string[] { result });
		}
	}

	public class ArtistNode : TreeNode
	{
	}

	public class AlbumNode : TreeNode
	{
	}

	public class TrackNode : TreeNode
	{
	}
}