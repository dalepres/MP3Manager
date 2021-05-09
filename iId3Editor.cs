using System;
using System.Collections.Generic;
using System.Text;

namespace Preston.Media
{
    internal interface IId3Editor
    {
        object Id3Tag { get; set; }
        void ClearTag();
    }
}
