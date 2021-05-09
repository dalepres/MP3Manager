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

    public partial class ImageFramesEditor : UserControl
    {
        public ImageFramesEditor()
        {
            InitializeComponent();
        }

        internal void LoadImages(object id3Tag)
        {
            if (id3Tag is V23Tag)
            {
                LoadV23Images((V23Tag)id3Tag);
            }
            else if (id3Tag is V22Tag)
            {
                LoadV22Images((V22Tag)id3Tag);
            }
        }

        private void LoadV22Images(V22Tag v22Tag)
        {
            PICFrame aFrame;
            tableLayoutPanel1.Controls.Clear();
            foreach (V22Frame frame in v22Tag.Frames)
            {
                if ((aFrame = frame as PICFrame) != null)
                {
                    AddFrame(aFrame);
                }
            }
        }

        private void LoadV23Images(V23Tag v23Tag)
        {
            APICFrame aFrame;
            tableLayoutPanel1.Controls.Clear();
            foreach (V2Frame frame in v23Tag.Frames)
            {
                if ((aFrame = frame as APICFrame) != null)
                {
                    AddFrame(aFrame);
                }
            }
        }

        private void AddFrame(object aFrame)
        {
            ImageFrameEditor editor = new ImageFrameEditor();
            editor.PicFrame = aFrame;
            editor.ReadOnly = true;
            tableLayoutPanel1.Controls.Add(editor);
            editor.Anchor = AnchorStyles.Left;
        }
    }
}
