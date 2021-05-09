using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Preston.Media
{
    public partial class EditTrackFilenameForm : Form
    {
        public EditTrackFilenameForm()
        {
            InitializeComponent();
        }


        private string fullFileName = string.Empty;
        public string FullFileName
        {
            get { return fullFileName; }
            set { fullFileName = value; }
        }

        private string newFileName = string.Empty;
        public string NewFileName
        {
            get { return newFileName; }
            set { newFileName = value; }
        }

        private void EditTrackFilenameForm_Load(object sender, EventArgs e)
        {
            //SetFormData();
        }


        public void SetFormData(string fileName)
        {
            this.fullFileName = fileName;
            this.newFileName = Path.GetFileName(fileName);
            SetFormData();
        }


        public void SetFormData(string fileName, string newName)
        {
            this.fullFileName = fileName;
            this.newFileName = newName;
            SetFormData();
        }


        private void SetFormData()
        {
            this.lblFilename.Text = Path.GetFileName(fullFileName);
            this.txtNewFileName.Text = newFileName;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFormData();
        }


        private void ClearFormData()
        {
            this.fullFileName = string.Empty;
            this.newFileName = string.Empty;
            SetFormData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.newFileName = txtNewFileName.Text.Trim();
            if(UpdateFileName())
            {
                this.DialogResult = DialogResult.OK;
                return;
            }
        }


        public static string GuessNewFileName(string oldFileName)
        {
            // TODO: This should be a private or at least internal method.
            //       Instead of calling this from the form parent, call this from
            //       the constructor or some other fashion so it is not public.

            if (oldFileName == null) //|| oldFileName.Length == 0 || oldFileName.Length > 255)
            {
                throw new ArgumentException("Invalid oldFileName parameter.  Cannot be null, and length must be between 1 and 255.");
            }

            while (oldFileName.IndexOf("[") >= 0 && oldFileName.IndexOf("]") >= 0)
            {
                int startIndex = oldFileName.IndexOf("[");
                int count = (oldFileName.IndexOf("]") - startIndex) + 1;
                oldFileName = oldFileName.Remove(startIndex, count);
            }

            oldFileName = oldFileName
                .Replace("  ", " ")
                .Replace(" of ", " Of ")
                .Replace(" the ", " The ")
                .Replace(" with ", " With ")
                .Replace(" for ", " For ")
                .Replace(" in ", " In ")
                .Replace(" at ", " At ")
                .Replace(" to ", " To ")
                .Replace(" is ", " Is ");

            oldFileName = Path.GetFileNameWithoutExtension(oldFileName).Trim()
                + Path.GetExtension(oldFileName);
            return oldFileName;
        }
        


        public string GetNewFullFileName()
        {
            return Path.Combine(Path.GetDirectoryName(this.fullFileName), this.newFileName);
        }

        private bool UpdateFileName()
        {
            if (!File.Exists(this.fullFileName))
            {
                ShowError("The source file does not exist.");
                return false;
            }

            if (File.Exists(GetNewFullFileName()) && !AlertDestinationExists())
            {
                return false;
            }

            try
            {
                File.Move(this.fullFileName,
                    Path.Combine(Path.GetDirectoryName(this.fullFileName), this.newFileName));
            }
            catch (FileNotFoundException ex)
            {
                ShowError("File " + ex.FileName + " could not be found.");
            }
            catch (NotSupportedException)
            {
                ShowError("The new filename is not in a supported format.");
            }
            catch (ArgumentException)
            {
                ShowError("The new filename is not in a supported format.");
            }
            catch (PathTooLongException)
            {
                ShowError("The combination of the path and filename must be less than 260 characters.");
            }
            catch (DirectoryNotFoundException)
            {
                ShowError("The source directory does not exist.  Check to see if your mapped network drives are connected.");
            }
            catch (Exception ex)
            {
                ShowError("An unknown exception occurred while renaming the file.  The error message is: " + ex.Message);
            }
            return true;
        }


        private static void ShowError(string errorMessage)
        {
            MessageBox.Show(
                errorMessage,
                "File Rename Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }


        private bool AlertDestinationExists()
        {
            if ((MessageBox.Show(
                "File " + GetNewFullFileName()
                + " already exists.  Click OK to overwrite or Cancel to abort.",
                "Destination File Exists",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
                && (DeleteExistingNewFile()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private bool DeleteExistingNewFile()
        {
            if (!File.Exists(GetNewFullFileName()))
            {
                return true;
            }

            try
            {
                File.Delete(GetNewFullFileName());
            }
            catch (Exception ex)
            {
                ShowError(
                    "The existing file could not be overwritten.  The error messgae is: " 
                    + ex.Message);
                return false;
            }

            if (!File.Exists(GetNewFullFileName()))
            {
                return true;
            }
            else
            {
                ShowError("The existing file could not be overwritten.");
                return false;
            }
        }
    }
}