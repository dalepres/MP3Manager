#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

#endregion

namespace MusicDiskMaker
{
	partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			string[] artists = Directory.GetDirectories(textBox1.Text);
			foreach (string artistDirectory in artists)
			{
				DirectoryInfo artistInfo = new DirectoryInfo(artistDirectory);

				DataRow drArtist = dsLibrary.Tables["Artists"].NewRow();
				drArtist["ArtistName"] = artistInfo.Name;
				dsLibrary.Tables["Artists"].Rows.Add(drArtist);
				int artistID = (int)drArtist["ArtistID"];
				string[] albums = Directory.GetDirectories(artistDirectory);
				foreach (string albumDirectory in albums)
				{
					Application.DoEvents();
					DirectoryInfo albumInfo = new DirectoryInfo(albumDirectory);
					DataRow drAlbum = dsLibrary.Tables["Albums"].NewRow();
					drAlbum["AlbumName"] = albumInfo.Name;
					drAlbum["ArtistID"] = artistID;
					dsLibrary.Tables["Albums"].Rows.Add(drAlbum);
					int albumID = (int)drAlbum["AlbumID"];
					string[] tracks = Directory.GetFiles(albumDirectory);
					foreach (string track in tracks)
					{
						DataRow drTrack = dsLibrary.Tables["Tracks"].NewRow();
						FileInfo trackInfo = new FileInfo(track);
						drTrack["TrackName"] = trackInfo.Name;
						drTrack["AlbumID"] = albumID;
						drTrack["Artist"] = artistID;
						drTrack["FileName"] = track;
						drTrack["FileSize"] = trackInfo.Length;
						drTrack["Sequence"] = random.Next(1000, 10000000);
						dsLibrary.Tables["Tracks"].Rows.Add(drTrack);
						int trackID = (int)drTrack["TrackID"];
//						txtTrackList.AppendText(trackID.ToString() 
//							+ ": " 
//							+ trackInfo.Name 
//							+ "\r\n");
					}
				}
			
			
			}

			int diskcount = 1;
			long maxDiskSize = 610L * 1024L * 1024L;
			long diskSize = 0L;

			DataView dv = dsLibrary.Tables["Tracks"].DefaultView;
			dv.AllowEdit = true;
			dv.Sort = "Sequence DESC";
			foreach (DataRowView drv in dv)
			{
				DataRow dr = drv.Row;

				dr["DiskID"] = "Disk" + diskcount.ToString();
				diskSize += (long)dr["FileSize"];
				if (diskSize > maxDiskSize)
				{
					diskSize = 0L;
					diskcount++;
				}

				int id = (int)dr["TrackID"];
				int sequence = (int)dr["Sequence"];
				string trackName = (string)dr["TrackName"];
				txtTrackList.AppendText(id.ToString()
		+ ": "
		+ sequence.ToString() + ": "
		+ dr["DiskID"] + ": "
		+ trackName
		+ "\r\n");
				if (!Directory.Exists(textBox2.Text + (string)dr["DiskID"]))
				{
					Directory.CreateDirectory(textBox2.Text + (string)dr["DiskID"]);
				}
				string newPath = textBox2.Text + (string)dr["DiskID"] + "\\"
					+ sequence.ToString() + "[-]" + (string)dr["TrackName"];
				File.Move((string)dr["FileName"], newPath);
			}
//			dsLibrary.Relations.Add(new DataRelation(
//				"ArtistAlbums",
//				dsLibrary.Tables["Artists"].Columns["ArtistID"],
//				dsLibrary.Tables["Albums"].Columns["ArtistID"]
//				));
//			dsLibrary.Relations.Add(new DataRelation(
//				"AlbumTrack",
//				dsLibrary.Tables["Albums"].Columns["AlbumID"],
//				dsLibrary.Tables["Tracks"].Columns["AlbumID"]
//				));
		}

		private void button2_Click(object sender, EventArgs e)
		{
//			dsLibrary.AcceptChanges();
			dsLibrary.WriteXml("Library.xml",XmlWriteMode.WriteSchema);
			MessageBox.Show("Done exportint to XML");
		}
	}
}