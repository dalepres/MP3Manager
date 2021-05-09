using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ID3Lib;
using System.ComponentModel.Design;

namespace Preston.Media.ID3TagEditor
{
    public partial class ID3V2Editor : UserControl, IID3Editor
    {
        object id3Tag;
        ID3TagRawViewerUC id3TagRawViewer;
        //ID3Lib.ID3Genres genreList = new ID3Lib.ID3Genres();
        int id3Encoding = 0;  // TODO:  Add more robust encoding dependent on the user's OS language.

        public ID3V2Editor()
        {
            InitializeComponent();
            LoadGenres();

            Location = new Point(0, 0);
            id3TagRawViewer = new ID3TagRawViewerUC();
            id3TagRawViewer.Top = 9;
            id3TagRawViewer.Left = 0;
            tpRawView.Controls.Add(id3TagRawViewer);
            id3TagRawViewer.FrameDeleted += new FrameDeletedEventHandler(id3TagRawViewer_FrameDeleted);
        }

        void id3TagRawViewer_FrameDeleted(object sender, FrameDeletedEventArgs e)
        {
            DisplayId3Tag();
            if (e.Frame is V2Frame)
            {
                MessageBox.Show(((V2Frame)e.Frame).FrameId + " was deleted.");
            }
        }

        #region Event Handlers

        #endregion Event Handlers

        #region Properties

        #endregion Properties

        #region Private Methods

        private void LoadGenres()
        {
            cbGenre.DataSource = ID3Genres.Genres;
            cbGenre.DisplayMember = "Genre";
        }

        #endregion Private Methods

        private void ID3V2Editor_Load(object sender, EventArgs e)
        {
        }

        #region iId3Editor Members

        public object Id3Tag
        {
            get { return id3Tag; }
            set
            {
                id3Tag = value;
                DisplayId3Tag();
            }
        }

        private void DisplayId3Tag()
        {
            id3TagRawViewer.Id3Tag = id3Tag;

            if (id3Tag is V23Tag)
            {
                DisplayV23Tag();
            }
            else if (id3Tag is V22Tag)
            {
                DisplayV22Tag();
            }

            LoadComments();
            LoadImages();
        }

        private void DisplayV22Tag()
        {
            txtAlbumName.Text = GetV22TextFrameValue("TAL");
            txtArtistName.Text = GetV22TextFrameValue("TP1");
            txtSongName.Text = GetV22TextFrameValue("TT2");
            txtAlbumArtist.Text = GetV22TextFrameValue("TP2");

            txtYear.Text = GetV22TextFrameValue("TYE");
            txtTrackNumber.Text = GetV22TextFrameValue("TRK");
            txtSet.Text = GetV22TextFrameValue("TPA");

            cbGenre.SelectedItem = ID3Genres.GetGenreItem(GetV22TextFrameValue("TCO"));

        }

        private void DisplayV23Tag()
        {
            txtAlbumName.Text = GetV2TextFrameValue("TALB");
            txtArtistName.Text = GetV2TextFrameValue("TPE1");
            txtSongName.Text = GetV2TextFrameValue("TIT2");
            txtAlbumArtist.Text = GetV2TextFrameValue("TPE2");

            txtYear.Text = GetV2TextFrameValue("TYER");
            txtTrackNumber.Text = GetV2TextFrameValue("TRCK");
            txtSet.Text = GetV2TextFrameValue("TPOS");

            cbGenre.SelectedItem = ID3Genres.GetGenreItem(GetV2TextFrameValue("TCON"));
        }

        private void LoadImages()
        {
            imageFramesEditor1.LoadImages(id3Tag);
        }

        private void LoadComments()
        {
            commentFramesEditor1.LoadComments(id3Tag);
        }

        private string GetV22TextFrameValue(string frameId)
        {
            V22Tag tag = (V22Tag)id3Tag;
            V22Frame frame = tag.Frames.GetFrame(frameId);
            return (frame == null) ? string.Empty : ((V22TextFrame)frame).Text;
        }

        private string GetV2TextFrameValue(string frameId)
        {
            V23Tag tag = (V23Tag)id3Tag;
            V2Frame frame = tag.Frames.GetFrame(frameId);
            return (frame == null) ? string.Empty : ((V2TextFrame)frame).Text;
        }

        #endregion

        internal void UpdateId3Tag()
        {
            if (id3Tag is V22Tag)
            {
                UpdateV22TagFromForm();
            }
            else if (id3Tag is V23Tag)
            {
                UpdateV23TagFromForm();
            }
        }

        private void UpdateV23TagFromForm()
        {
            V23Tag tag = (V23Tag)id3Tag;
            tag.Frames.SetTextFrame("TPE2", txtAlbumArtist.Text.Trim(), id3Encoding);
            tag.Frames.SetTextFrame("TALB", txtAlbumName.Text.Trim(), id3Encoding);
            tag.Frames.SetTextFrame("TPE1", txtArtistName.Text.Trim(), id3Encoding);
            tag.Frames.SetTextFrame("TPOS", txtSet.Text.Trim(), id3Encoding);
            tag.Frames.SetTextFrame("TIT2", txtSongName.Text.Trim(), id3Encoding);
            tag.Frames.SetTextFrame("TYER", txtYear.Text.Trim(), id3Encoding);
            tag.Frames.SetTextFrame("TRCK", txtTrackNumber.Text.Trim(), id3Encoding);

            TCONTextFrame genreFrame = tag.Frames.GetFrame("TCON") as TCONTextFrame;

            if (genreFrame != null)
            {
                genreFrame.Text = cbGenre.Text;
            }
        }

        private void UpdateV22TagFromForm()
        {
            V22Tag tag = (V22Tag)id3Tag;
            tag.Frames.SetTextFrame("TP2", txtAlbumArtist.Text.Trim(), id3Encoding);
            tag.Frames.SetTextFrame("TAL", txtAlbumName.Text.Trim(), id3Encoding);
            tag.Frames.SetTextFrame("TP1", txtArtistName.Text.Trim(), id3Encoding);
            tag.Frames.SetTextFrame("TPA", txtSet.Text.Trim(), id3Encoding);
            tag.Frames.SetTextFrame("TT2", txtSongName.Text.Trim(), id3Encoding);
            tag.Frames.SetTextFrame("TYE", txtYear.Text.Trim(), id3Encoding);
            tag.Frames.SetTextFrame("TRK", txtTrackNumber.Text.Trim(), id3Encoding);

            TCOTextFrame genreFrame = tag.Frames.GetFrame("TCO") as TCOTextFrame;

            if (genreFrame != null)
            {
                genreFrame.Text = cbGenre.Text;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateId3Tag();
            if (tabControl1.SelectedTab.Name == "tpRawView")
            {
                id3TagRawViewer.ReloadTag();
            }
        }

        #region IId3Editor Members


        public void ClearTag()
        {
            id3Tag = null;
            txtAlbumArtist.Text
                = txtAlbumName.Text
                = txtArtistName.Text
                = txtSet.Text
                = txtSongName.Text
                = txtYear.Text
                = txtTrackNumber.Text
                = string.Empty;

            cbGenre.SelectedItem = ID3Genres.GetGenreItem(255);

            this.rbV23.Checked = true;

            this.Visible = false;
        }

        #endregion
    }
}
