using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Preston.Media
{
    class Album
    {
        private int albumID;
        public int AlbumID
        {
            get { return albumID; }
            set { albumID = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int artistID;
        public int ArtistID
        {
            get { return artistID; }
            set { artistID = value; }
        }

        private string filePath;
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
    }
}
