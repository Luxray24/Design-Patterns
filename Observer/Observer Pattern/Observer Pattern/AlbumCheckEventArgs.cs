using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class AlbumCheckEventArgs : EventArgs
    {
        private String _AlbumName;

        public String a_AlbumName
        {
            get { return _AlbumName; }
            set { _AlbumName = value; }
        }

        public AlbumCheckEventArgs()
        {

        }

        public AlbumCheckEventArgs(String Album)
        {
            a_AlbumName = Album;
        }
    }
}
