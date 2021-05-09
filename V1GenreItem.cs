using System;
using System.Collections.Generic;
using System.Text;

namespace Preston.Media
{
    internal class V1GenreItem : IComparable
    {
        private byte genreId = 255;
        private string genre;

        public V1GenreItem(byte genreId, string genre)
        {
            this.genreId = genreId;
            this.genre = genre;
        }


        public override string ToString()
        {
            return genre;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is int)
            {
                return genreId == (int)obj;
            }

            V1GenreItem item = obj as V1GenreItem;
            if (obj != null)
            {
                return genreId == item.GenreId;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return genre.GetHashCode();
        }




        public byte GenreId
        {
            get { return genreId; }
            set { genreId = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (obj is V1GenreItem)
            {
                return string.Compare(genre, ((V1GenreItem)obj).Genre, true);
            }
            else
            {
                throw new ArgumentException("Only V1GenreItem objects can be compared using V1GenreItem.CompareTo().");
            }
        }

        #endregion
    }
}
