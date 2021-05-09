using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ID3Lib;

namespace Preston.Media
{
    public partial class EmbedPicturesForm : Form
    {
        private bool isExecuting;

        public EmbedPicturesForm()
        {
            InitializeComponent();
        }


        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result != DialogResult.OK || (!Directory.Exists(folderBrowserDialog1.SelectedPath)))
            {
                return;
            }

            this.lblSourceFolder.Text = folderBrowserDialog1.SelectedPath;
        }


        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (isExecuting)
                return;

            isExecuting = true;

            if (!Directory.Exists(this.lblSourceFolder.Text))
            {
                MessageBox.Show("Directory " 
                    + lblSourceFolder.Text 
                    + " could not be located.  Click Browse to select a valid directory to search.",
                    "Mp3Manager-Embed Pictures Form error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				isExecuting = false;
                return;
            }

            if (this.txtDescription.Text.Length > 64)
            {
                this.txtDescription.Text = this.txtDescription.Text.Substring(0, 64).Trim(); ;
            }

            Mp3File.EmbedFolderImage(this.lblSourceFolder.Text,this.txtImageName.Text,"*.mp3",(byte)cbPictureTypes.SelectedIndex,"image/jpeg",txtDescription.Text);
			
			isExecuting = false;

			MessageBox.Show("Done embedding images.");
        }

		void Mp3File_ImageLoaded(object sender, ImageLoadedEventArgs e)
		{
			listBox1.Items.Add(e.ImageName);
			pictureBox1.Image = e.Image;
		}

		private void EmbedPicturesForm_Load(object sender, EventArgs e)
		{
			Mp3File.ImageLoaded += new ImageLoadedEventHandler(Mp3File_ImageLoaded);
            Mp3File.ImageEmbedded += new ImageEmbeddedEventHandler(Mp3File_ImageEMbedded);
			cbPictureTypes.SelectedIndex = 3;
		}

        private void Mp3File_ImageEMbedded(object sender, ImageEmbeddedEventArgs e)
        {
            listBox1.Items.Add(e.TrackFileName);
        }

        private void EmbedPicturesForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Mp3File.ImageLoaded -= Mp3File_ImageLoaded;
		}
    }
}