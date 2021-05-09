using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Preston.Media.Properties;

namespace Preston.Media
{
    public partial class MdmProperties : Form
    {
        public MdmProperties()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            this.Text = Settings.Default.LibraryPath;
        }
    }
}