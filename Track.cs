#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

#endregion

namespace Preston.Media
{
    public class Track
    {
        private string trackName;
        private string albumName;
        private string artistName;
        private string fullFilePath;
        private int trackNumber;
        private string albumArtist;
        private int sequence;
        private long fileSize;


        public int TrackNumber
        {
            get { return trackNumber; }
            set { trackNumber = value; }
        }


        public string AlbumArtist
        {
            get { return albumArtist; }
            set { albumArtist = value; }
        }


        public long FileSize
        {
            get { return fileSize; }
            set { fileSize = value; }
        }


        public int Sequence
        {
            get { return sequence; }
            set { sequence = value; }
        }

        
        public string TrackName
        {
            get { return trackName; }
            set { trackName = value; }
        }


        public string AlbumName
        {
            get { return albumName; }
            set { albumName = value; }
        }


        public string ArtistName
        {
            get { return artistName; }
            set { artistName = value; }
        }

        
        public string FullFilePath
        {
            get { return fullFilePath; }
            set { fullFilePath = value; }
        }


        public string FileName
        {
            get
            {
                return Path.GetFileName(fullFilePath);
            }

            set
            {
                File.Move(FullFilePath, Path.Combine(FilePath, value));
            }
        }


        public string FilePath
        {
            get { return Path.GetDirectoryName(fullFilePath); }
        }
    }
}
