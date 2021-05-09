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
    public partial class ID3V1EditorG : UserControl
    {
        private string commentHolder = string.Empty;
        private object id3Tag;

        public ID3V1EditorG()
        {
            InitializeComponent();

            LoadGenres();
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
                if ((id3Tag = value as V1Tag) == null)
                    throw new ArgumentException("ID3V1Editor.Id3Tag must be an object of type ID3Lib.V1Tag");

                V1Tag v1Tag = (V1Tag)id3Tag;
                txtSongName.Text = v1Tag.Title;
                txtAlbumName.Text = v1Tag.Album;
                txtArtistName.Text = v1Tag.Artist;
                txtComment.Text = v1Tag.Comment;
                txtYear.Text = v1Tag.Year;
                cbGenre.SelectedItem = new V1GenreCollection().GetGenreItem(v1Tag.Genre);

                if (v1Tag.MajorVersion == 0)
                {
                    rbV10.Checked = true;
                    nudTrackNumber.Enabled = false;
                }
                if (v1Tag.MajorVersion == 1)
                {
                    this.rbV11.Checked = true;
                    this.nudTrackNumber.Enabled = true;
                    this.nudTrackNumber.Value = (int)v1Tag.Genre;
                }
            }
        }

        public V1Tag V1Tag
        {
            get
            {
                V1Tag tag = new V1Tag();
                tag.Title = txtSongName.Text.Trim();
                tag.Album = txtAlbumName.Text.Trim();
                tag.Artist = txtArtistName.Text.Trim();
                tag.Comment = txtComment.Text.Trim();
                tag.Year = txtYear.Text.Trim();
                tag.Genre = ((V1GenreItem)cbGenre.SelectedItem).GenreId;

                return tag;
            }
        }

        #endregion Properties


        #region Private Methods
        private void LoadGenres()
        {
            cbGenre.DataSource = new V1GenreCollection();
            cbGenre.DisplayMember = "Genre";
        }

        #endregion Private Methods
    }
}
