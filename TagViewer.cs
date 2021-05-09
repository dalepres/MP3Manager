using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Preston.Media
{
    public partial class TagViewer : UserControl
    {
        private byte[] frameValue;

        public TagViewer()
        {
            InitializeComponent();
        }


        #region Properties

        public byte[] FrameValue
        {
            set
            {
                frameValue = value;
                string[] display = ByteArrayToDisplayString(value);
                rtbHexDisplay.Text = display[0];
                rtbCharDisplay.Text = display[1];
            }
        }

        #endregion Properties

        private string[] ByteArrayToDisplayString(byte[] bytes)
        {
            int wordCount = 0;
            int lineCount = 0;
            string hexDisplay = "";
            string charDisplay = "";
            string hexWord = "";
            string charWord = "";
            string hexLine = "";
            string charLine = "";

            for (int count = 0; count < bytes.Length; count++)
            {
                hexWord += bytes[count].ToString("X2") + " ";
                charWord += (char)bytes[count];
                wordCount++;
                if (wordCount % 8 == 0)
                {
                    wordCount = 0;
                    hexLine += hexWord + " ";
                    charLine += charWord;
                    hexWord = charWord = "";
                    lineCount++;
                    if (lineCount % 4 == 0)
                    {
                        lineCount = 0;
                        hexDisplay += hexLine.Trim() + "\r\n";
                        charDisplay += charLine.Trim() + "\r\n";
                        hexLine = charLine = "";
                    }
                }
            }

            return new string[] { hexDisplay, charDisplay };
        }
    }
}
