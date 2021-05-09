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
    public partial class ID3TagBackupForm : Form
    {
        private bool isExecuting;

        public ID3TagBackupForm()
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
            btnExecute.Enabled = false;
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
                btnExecute.Enabled = true;
                return;
            }

            Mp3File.BackupFolderId3Tags(this.lblSourceFolder.Text, "*.mp3", chkRecursive.Checked, chkRemoveTag.Checked);
			
			isExecuting = false;
            btnExecute.Enabled = true;

			MessageBox.Show("Done backing up track tags.");
        }

		void Mp3File_TrackTagBackedUp(object sender, TagBackedUpEventArgs e)
		{
			listBox1.Items.Add(e.BackupPath);
		}

		private void ID3TagBackupForm_Load(object sender, EventArgs e)
		{
			Mp3File.TrackTagBackedUp += new TrackTagBackedUpEventHandler(Mp3File_TrackTagBackedUp);
		}

		private void EmbedPicturesForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Mp3File.TrackTagBackedUp -= Mp3File_TrackTagBackedUp;
		}
    }
}