using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ID3Lib;
using Preston.Media.Properties;

namespace Preston.Media
{
    public partial class TrackTagEditor : Form
    {
        private string mp3FileName;
        //private ArrayList tagList = new ArrayList();
        //private ID3V2Editor id3V2Editor = new ID3V2Editor();
        //private ID3V1Editor id3V1Editor = new ID3V1Editor();
        private V1Tag v1Tag;
        private V22Tag v22Tag;
        private List<V2Tag> v2Tags;
        private object currentTag;

        public TrackTagEditor()
        {
            InitializeComponent();
        }

        private void TrackTagEditor_Load(object sender, EventArgs e)
        {
        }


#region Properties

        public string Mp3FileName
        {
            get { return mp3FileName; }
            set
            {
                btnChangeFileName.Enabled = true;
                cbTags.Items.Clear();
                cbTags.Enabled = false;
                button1.Enabled = false;
                mp3FileName = value;
                lblFileName.Text = value;
                GetID3Tags(value);
            }
        }

        #endregion Properties

        #region Private Methods


        //private void DisplayV2TagEditor()
        //{
        //    panel1.Controls.Clear();
        //    id3V2Editor = new ID3V2Editor();
        //    id3V2Editor.Location = new Point(0, 0);
        //    panel1.Controls.Add(id3V2Editor);
        //}

        //private void DisplayV1TagEditor()
        //{
        //    panel1.Controls.Clear();
        //    id3V1Editor = new ID3V1Editor();
        //    id3V1Editor.Location = new Point(0, 0);
        //    panel1.Controls.Add(id3V1Editor);
        //}


        private void GetID3Tags(string fileName)
        {
            //bool hasTags = false;
            Mp3File file = new Mp3File(fileName);
            v1Tag = file.GetV1Tag();
            v22Tag = file.GetV22Tag();
            v2Tags = file.GetV2Tags(false); //!rbNoCopyConvert.Checked);


            DisplayID3Tags();
        }

        private void DisplayID3Tags()
        {
            currentTag = null;
            cbTags.Items.Clear();

            if (v1Tag != null)
            {
                AddV1TagToList(v1Tag);
                id3V1Editor.Id3Tag = v1Tag;
                currentTag = v1Tag;
                //hasTags = true;
            }

            if (v22Tag != null)
            {
                AddV22TagToList(v22Tag);
                if (currentTag == null)
                {
                    currentTag = v22Tag;
                }
            }

            if (v2Tags.Count > 0)
            {
                AddV2TagsToList(v2Tags);
                iD3V2Editor.Id3Tag = v2Tags[0];

                if (currentTag == null)
                {
                    currentTag = v2Tags[0];
                }

            }

            if (v1Tag == null)
            {
                cbTags.Items.Add(Resources.NewV1TagPrompt);
            }

            if (v2Tags.Count == 0 && v22Tag == null)
            {
                cbTags.Items.Add(Resources.NewV2TagPrompt);
            }

            button1.Enabled = currentTag != null;

            cbTags.Enabled = true;
            cbTags.SelectedIndex = 0;
        }

        private void AddV22TagToList(V22Tag v22Tag)
        {
            //tagList.Add(v22Tag);
            cbTags.Items.Add(v22Tag); //.ToString());
        }

        private void AddV2TagsToList(List<V2Tag> v2Tags)
        {
            for (int count = 0; count < v2Tags.Count; count++)
            {
                V2Tag tag = v2Tags[count];

                //tagList.Add(tag);
                cbTags.Items.Add(tag); //.ToString());
            }
        }

        private void AddV1TagToList(V1Tag tagToAdd)
        {
            //tagList.Add(tagToAdd);
            cbTags.Items.Add(tagToAdd); //.ToString());
        }

        #endregion Private Methods

        private void cbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentTag != null)
            {
                UpdateTagFromForm();
                currentTag = null;
            }

            DisplaySelection();
        }

        private void DisplaySelection()
        {
            if (cbTags.SelectedItem is string)
            {
                lblTteNoFileSelected.Visible = true;
                id3V1Editor.Visible = false;
                iD3V2Editor.Visible = false;
                button1.Text = "Create";
            }
            else
            {
                if (cbTags.SelectedItem is V1Tag)
                {
                    lblTteNoFileSelected.Visible = false;
                    id3V1Editor.Id3Tag = cbTags.SelectedItem;
                    currentTag = cbTags.SelectedItem;
                    id3V1Editor.Visible = true;
                    iD3V2Editor.Visible = false;
                }
                else if (cbTags.SelectedItem is V23Tag || cbTags.SelectedItem is V22Tag)
                {
                    lblTteNoFileSelected.Visible = false;
                    iD3V2Editor.Id3Tag = cbTags.SelectedItem;
                    currentTag = cbTags.SelectedItem;
                    iD3V2Editor.Visible = true;
                    id3V1Editor.Visible = false;
                }

                button1.Text = "Delete Tag";
            }
        }

        private void UpdateTagFromForm()
        {
            if (currentTag == null)
            {
                return;
            }
            else if (currentTag is V1Tag)
            {
                UpdateV1TagFromForm();
            }
            else if (currentTag is V22Tag || currentTag is V23Tag)
            {
                UpdateV2TagFromForm();
            }
        }

        private void UpdateV2TagFromForm()
        {
            iD3V2Editor.UpdateId3Tag();
        }

        private void UpdateV1TagFromForm()
        {
            id3V1Editor.UpdateId3Tag();
        }

        private void AddNewV2Tag()
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }

        private void AddNewV1Tag()
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }

        private void lblFileName_DragEnter(object sender, DragEventArgs e)
        {
            // If the data is a file or a bitmap, display the copy cursor.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void lblFileName_DragDrop(object sender, DragEventArgs e)
        {
            lblFileName.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            Mp3FileName = lblFileName.Text;
            btnChangeFileName.Left = lblFileName.Left + lblFileName.Width + 4;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = cbTags.SelectedIndex;
            string newCommand;
            if ((newCommand = cbTags.Items[index] as string) != null)
            {
                CreateNewTag(index, newCommand);
            }
            else
            {
                DeleteTag(cbTags.Items[index]);
            }

            DisplayID3Tags();
        }

        private void DeleteTag(object tag)
        {
            if (tag is V1Tag)
            {
                v1Tag = null;
                id3V1Editor.ClearTag();
            }
            else if (tag is V22Tag)
            {
                v22Tag = null;
                iD3V2Editor.ClearTag();
            }
            else if (tag is V23Tag)
            {
                v2Tags.Clear();
                iD3V2Editor.ClearTag();
            }
        }

        private void CreateNewTag(int index, string newCommand)
        {
            if (newCommand == Properties.Resources.NewV1TagPrompt)
            {
                CreateNewV1Tag(index);
            }
            else if (newCommand == Properties.Resources.NewV2TagPrompt)
            {
                CreateNewV2Tag(index);
            }
        }

        private void CreateNewV2Tag(int index)
        {
            object sourceTag;
            if (v1Tag != null)
                sourceTag = v1Tag;
            else
                sourceTag = null;

            v2Tags.Add(V23Tag.FromTag(sourceTag, 0));
            cbTags.Items[index] = v2Tags[0];
            cbTags.SelectedIndex = index;
            DisplaySelection();
        }

        private void CreateNewV1Tag(int index)
        {
            object sourceTag;

            if (v2Tags.Count > 0)
                sourceTag = v2Tags[0];
            else if (v22Tag != null)
                sourceTag = v22Tag;
            else
                sourceTag = null;

            v1Tag = V1Tag.FromTag(sourceTag);
            cbTags.Items[index] = v1Tag;
            cbTags.SelectedIndex = index;
            DisplaySelection();
        }

        
        
        /*
         * TODO:    add elements for editing popular track tags.
         *          add a list of other track tags, such as PRIV in a grid or something
         *          add a hex editor or some kind of viewer for data of unknown or unhandled tag types such as PRIV, etc.
         *          add a view of embedded images including image types
         *          add help and information about the various track tags
         *          add functionality to change file name based on track name information
         *              including capitalization of the first letter of each word
         *          perhaps add a tree view to select multiple files for editing at once like
         *          done in media player.
         */
    }
}