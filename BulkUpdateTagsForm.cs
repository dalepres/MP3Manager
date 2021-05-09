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
    public partial class BulkUpdateTagsForm : Form
    {
        private bool isExecuting;

        public BulkUpdateTagsForm()
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
			Cursor originalCursor = this.Cursor;
			this.Cursor = Cursors.WaitCursor;
            if (isExecuting)
                return;

            isExecuting = true;
            if (!Directory.Exists(this.lblSourceFolder.Text))
            {
                MessageBox.Show("Directory " 
                    + lblSourceFolder.Text 
                    + " could not be located.  Click Browse to select a valid directory to search.",
                    "Mp3Manager-Bulk Update Tags Form error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            Mp3File.UpdateFolderTagFormatting(this.lblSourceFolder.Text,"*.mp3",chkRecursive.Checked, false);

            isExecuting = false;
			this.Cursor = originalCursor;
        }
    }
}