using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer_Pattern
{
    public class SongCheckEventArgs : EventArgs
    {
        private String _SongName;

        public String s_SongName
        {
            get { return _SongName; }
            set { _SongName = value; }
        }

        public SongCheckEventArgs()
        {

        }

        public SongCheckEventArgs(String Song)
        {
            s_SongName = Song;
        }
    }
}
