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

    public partial class CommentFramesEditor : UserControl
    {
        public CommentFramesEditor()
        {
            InitializeComponent();
        }

        internal void LoadComments(object id3Tag)
        {
            if (id3Tag is V23Tag)
            {
                LoadV23Comments((V23Tag)id3Tag);
            }
            else if (id3Tag is V22Tag)
            {
                LoadV22Comments((V22Tag)id3Tag);
            }
        }

        private void LoadV22Comments(V22Tag v22Tag)
        {
            COMFrame cFrame;
            tableLayoutPanel1.Controls.Clear();
            foreach (V22Frame frame in v22Tag.Frames)
            {
                if ((cFrame = frame as COMFrame) != null)
                {
                    AddFrame(cFrame);
                }
            }
        }

        private void LoadV23Comments(V23Tag v23Tag)
        {
            COMMFrame cFrame;
            tableLayoutPanel1.Controls.Clear();
            foreach (V2Frame frame in v23Tag.Frames)
            {
                if ((cFrame = frame as COMMFrame) != null)
                {
                    AddFrame(cFrame);
                }
            }
        }

        private void AddFrame(object cFrame)
        {
            CommentFrameEditor editor = new CommentFrameEditor();
            editor.CommentFrame = cFrame;
            editor.ReadOnly = true;
            tableLayoutPanel1.Controls.Add(editor);
            editor.Anchor = AnchorStyles.Left;
        }
    }
}
