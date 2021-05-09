using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ID3Lib;

namespace Preston.Media.ID3TagEditor
{
    public partial class CommentFrameEditor : UserControl
    {
        private object commentFrame;
        private bool readOnly;



        public CommentFrameEditor()
        {
            InitializeComponent();
        }

        #region Properties

        public bool ReadOnly
        {
            get { return readOnly; }
            set
            {
                readOnly = value;
                txtDescription.Enabled = !value;
                txtComment.Enabled = !value;
            }
        }

        public string Description
        {
            get { return txtDescription.Text.Trim(); }
            set { txtDescription.Text = value; }
        }

        public string Comment
        {
            get { return txtComment.Text.Trim(); }
            set { txtComment.Text = value; }
        }

        public object CommentFrame
        {
            get { return commentFrame; }
            set
            {
                if (value is COMMFrame)
                {
                    COMMFrame cFrame = (COMMFrame)value;
                    Comment = cFrame.Comment;
                    Description = cFrame.Description;
                 }
                else if (value is COMFrame)
                {
                    COMFrame cFrame = (COMFrame)value;
                    Comment = cFrame.Comment;
                    Description = cFrame.Description;
                }
                else if (value == null)
                {
                    Comment = string.Empty;
                    Description = string.Empty;
                }
                else
                {
                }

                commentFrame = value;
            }
        }

        #endregion Properties


        public void CopyFromCommentFrameEditor(CommentFrameEditor editor)
        {
            CommentFrame = editor.CommentFrame;
        }


        private void CommenFrameEditor_Load(object sender, EventArgs e)
        {

        }

        private void CommentFrameEditor_Enter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void ImageFrameEditor_Leave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
