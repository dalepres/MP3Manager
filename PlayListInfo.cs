namespace Preston.Media
{
    using System;
    using WMPLib;

    public class PlayListInfo
    {
        private string name;
        private IWMPPlaylist playList;
        private string playListType;

        public PlayListInfo(string name, string playListType, IWMPPlaylist playList)
        {
            this.playList = playList;
            this.name = name;
            this.playListType = playListType;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string PlayListType
        {
            get
            {
                return this.playListType;
            }
            set
            {
                this.playListType = value;
            }
        }

        public IWMPPlaylist PlayList
        {
            get
            {
                return this.playList;
            }
            set
            {
                this.playList = value;
            }
        }
    }
}

