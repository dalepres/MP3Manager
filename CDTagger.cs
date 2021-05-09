using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ID3Lib;

namespace Preston.Media
{
	public sealed class CDTagger
	{
		private static CDTagger instance;

		private CDTagger()
		{
		}

		public static CDTagger Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new CDTagger();
				}
				return instance;
			}
		}

		public static long TagForCD(Track track, string destinationPath, string newFileName)
		{
			return TagForCD(track, destinationPath, newFileName, false, false);
		}


		public static long TagForCD(Track track, string destinationPath, string newFileName, bool addCoverArt, bool keepExistingTags)
		{
			Mp3File mp3File = new Mp3File(track.FullFilePath);

			ReadOriginalTags(track, mp3File);

			long fileSize = mp3File.SaveTags(CreateNewV2Tag(track, addCoverArt), null, destinationPath, newFileName); // v1Tag is null because for Truck CDs, I only use V2.3.0
			mp3File.Dispose();

			return fileSize;
		}


		private static void ReadOriginalTags(Track track, Mp3File mp3File)
		{
			List<V2Tag> oldV2Tags = mp3File.GetV2Tags();

			IEnumerator<V2Frame> ie = oldV2Tags[0].Frames["TALB"];
			while (ie.MoveNext())
			{
				track.AlbumName = ((TALBTextFrame)ie.Current).Text;
				break;
			}

			ie = oldV2Tags[0].Frames["TIT2"];
			while (ie.MoveNext())
			{
				track.TrackName = ((TIT2TextFrame)ie.Current).Text;
				break;
			}

			ie = oldV2Tags[0].Frames["TPE1"];
			while (ie.MoveNext())
			{
				track.ArtistName = ((TPE1TextFrame)ie.Current).Text;
				break;
			}

			ie = oldV2Tags[0].Frames["TRCK"];
			while (ie.MoveNext())
			{
				int trackNumber;
				int.TryParse(((TRCKTextFrame)ie.Current).Text, out trackNumber);
				track.TrackNumber = trackNumber;
				break;
			}
		}

		private static List<V2Tag> CreateNewV2Tag(Track track, bool addCoverArt)
		{
			List<V2Tag> newV2Tags = new List<V2Tag>();
			V23Tag newV2Tag = new V23Tag();
			newV2Tag.MajorVersion = 3;
			newV2Tag.MinorVersion = 0;
			newV2Tag.Flags = 0;

            if (!String.IsNullOrEmpty(track.AlbumName)) newV2Tag.Frames.Add(new TALBTextFrame(track.AlbumName));
            if (!String.IsNullOrEmpty(track.TrackName)) newV2Tag.Frames.Add(new TIT2TextFrame(track.TrackName));
            if (!String.IsNullOrEmpty(track.AlbumArtist)) newV2Tag.Frames.Add(new TPE2TextFrame(track.AlbumArtist));
			if (!String.IsNullOrEmpty(track.ArtistName)) newV2Tag.Frames.Add(new TPE1TextFrame(track.ArtistName));
			newV2Tag.Frames.Add(new TRCKTextFrame(track.TrackNumber.ToString()));

			if (addCoverArt)
			{
				EmbedFolderImage(track, newV2Tag);
			}

			newV2Tags.Add(newV2Tag);
			return newV2Tags;
		}

		private static void EmbedFolderImage(Track track, V23Tag newV2Tag)
		{
            string picturePath = Path.Combine(track.FilePath, "Folder.jpg");
            if (File.Exists(picturePath))
            {
                try
                {
                    APICFrame picFrame = new APICFrame();
                    picFrame.Description = "Dales scanned cover art";
                    picFrame.MimeType = "image/jpeg";
                    picFrame.PictureType = 3; // Front Cover
                    picFrame.PictureData = Mp3File.LoadPicureFromFile(picturePath);
                    newV2Tag.Frames.Add(picFrame);
                }
                catch
                {
                    throw;
                }
            }
		}
	}
}
