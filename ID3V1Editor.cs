using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ID3Lib;

namespace Preston.Media
{
    public partial class ID3V1Editor : UserControl, IId3Editor
    {
        private string commentHolder = string.Empty;
        private object id3Tag;
        //private ID3Lib.ID3Genres genreList = new ID3Lib.ID3Genres();

        public ID3V1Editor()
        {
            InitializeComponent();
            LoadGenres();
            Location = new Point(0, 0);
        }

        #region Event Handlers

        private void version_CheckedChanged(object sender, EventArgs e)
        {
            if (rbV11.Checked)
            {
                this.nudTrackNumber.Enabled = true;
                commentHolder = txtComment.Text;
                txtComment.Text = commentHolder.Substring(0, commentHolder.Length > 28 ? 28 : commentHolder.Length);
                txtComment.MaxLength = 28;
            }
            else
            {
                this.nudTrackNumber.Enabled = false;
                txtComment.MaxLength = 30;
                if (txtComment.Text == commentHolder.Substring(0, commentHolder.Length > 28 ? 28 : commentHolder.Length))
                {
                    txtComment.Text = commentHolder;
                }
            }
        }

        #endregion Event Handlers

        #region Properties


        public object Id3Tag
        {
            get { return id3Tag; }
            set
            {
                if (value == null)
                {
                    id3Tag = value;
                    ClearTag();
                    return;
                }

                if (!(value is V1Tag))
                    throw new ArgumentException("ID3V1Editor.Id3Tag must be an object of type ID3Lib.V1Tag");
                id3Tag = value;
                V1Tag v1Tag = (V1Tag)id3Tag;
                txtSongName.Text = v1Tag.Title;
                txtAlbumName.Text = v1Tag.Album;
                txtArtistName.Text = v1Tag.Artist;
                txtComment.Text = v1Tag.Comment;
                txtYear.Text = v1Tag.Year;
                cbGenre.SelectedItem = ID3Genres.GetGenreItem(v1Tag.Genre); // new V1GenreCollection().GetGenreItem(v1Tag.Genre);

                if (v1Tag.MajorVersion == 0)
                {
                    rbV10.Checked = true;
                    nudTrackNumber.Enabled = false;
                }
                if (v1Tag.MajorVersion == 1)
                {
                    this.rbV11.Checked = true;
                    this.nudTrackNumber.Enabled = true;
                    this.nudTrackNumber.Value = (int)v1Tag.TrackNumber;
                }
            }
        }

        public void UpdateId3Tag()
        {
            V1Tag tag = (V1Tag)id3Tag;

            if (rbV11.Checked)
            {
                tag.MajorVersion = 1;
                tag.TrackNumber = (byte)nudTrackNumber.Value;
            }
            else
            {
                tag.MajorVersion = 0;
            }

            tag.Title = txtSongName.Text.Trim();
            tag.Album = txtAlbumName.Text.Trim();
            tag.Artist = txtArtistName.Text.Trim();
            tag.Comment = txtComment.Text.Trim();
            tag.Year = txtYear.Text.Trim();
            tag.Genre = ((ID3GenreItem)cbGenre.SelectedItem).GenreId;
        }

        #endregion Properties


        #region Private Methods

        private void LoadGenres()
        {
            //ID3GenreItem[] itemList = genreList.GetGenreList();

            //cbGenre.Items.AddRange(itemList);

            cbGenre.DataSource = ID3Genres.Genres; //GetGenreList(); // new V1GenreCollection();
            cbGenre.DisplayMember = "Genre";
        }

        #endregion Private Methods

        private void ID3V1Editor_Load(object sender, EventArgs e)
        {

        }

        #region IId3Editor Members


        public void ClearTag()
        {
            id3Tag = null;
            txtSongName.Text
                = txtAlbumName.Text
                = txtArtistName.Text
                = txtComment.Text
                = txtYear.Text
                = string.Empty;

            cbGenre.SelectedItem = ID3Genres.GetGenreItem(255);

            rbV11.Checked = true;
            nudTrackNumber.Enabled = true;
            this.nudTrackNumber.Value = 0;
            this.Visible = false;
        }

        #endregion
    }
}
