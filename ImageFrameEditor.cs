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
    public partial class ImageFrameEditor : UserControl
    {
        private object picFrame;
        private bool readOnly;
        private Image picture;


        public ImageFrameEditor()
        {
            InitializeComponent();
            cbImageTypes.DataSource = ID3PictureTypes.GetPictureTypes();
            cbImageTypes.DisplayMember = "PictureType";
        }

        #region Properties

        public bool ReadOnly
        {
            get { return readOnly; }
            set
            {
                readOnly = value;
                cbImageTypes.Visible = !value;
                txtImageType.Enabled = !value;
                txtDescription.Enabled = !value;
                cbImageTypes.Enabled = !value;
                txtImageType.Visible = value;
            }
        }

        public Image Picture
        {
            get { return picture; }
        }

        public object PicFrame
        {
            get { return picFrame; }
            set
            {
                picFrame = value;

                if (picFrame is APICFrame)
                {
                    APICFrame aFrame = (APICFrame)picFrame;
                    pictureBox.Image = aFrame.GetPicture(pictureBox.Size);
                    this.picture = pictureBox.Image;
                    txtDescription.Text = aFrame.Description;
                    txtImageType.Text = ID3Lib.ID3PictureTypes.GetPictureType(aFrame.PictureType).PictureType;
                    cbImageTypes.Text = ID3Lib.ID3PictureTypes.GetPictureType(aFrame.PictureType).PictureType;
                }
                else if (picFrame is PICFrame)
                {
                }
            }
        }

        #endregion Properties


        public void CopyFromImageFrameEditor(ImageFrameEditor editor)
        {
            this.picFrame = editor.PicFrame;
            this.pictureBox.Image = editor.picture;
            this.cbImageTypes.SelectedItem = editor.cbImageTypes.SelectedItem;
            this.txtDescription.Text = editor.txtDescription.Text;
        }


        private void cbImageTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtImageType.Text = ID3PictureTypes.GetPictureType(cbImageTypes.Text).PictureType;
        }

        private void ImageFrameEditor_Load(object sender, EventArgs e)
        {

        }

        private void ImageFrameEditor_Enter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ImageFrameEditor_Leave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }
    }
}
