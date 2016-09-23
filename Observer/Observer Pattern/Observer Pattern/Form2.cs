using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer_Pattern
{
    public partial class Form2 : Form
    {
        public delegate void SongCheckEventHandler(Object sender, SongCheckEventArgs e);
        public delegate void AlbumCheckEventHandler(Object sender, AlbumCheckEventArgs e);

        public SongCheckEventHandler SongExists;
        public SongCheckEventHandler SongDoesNotExist;

        public AlbumCheckEventHandler AlbumExists;
        public AlbumCheckEventHandler AlbumDoesNotExist;

        public Form2()
        {
            InitializeComponent();
        }

        private void songBox_TextChanged(object sender, EventArgs e)
        {
            if (Library.SongDoesExist(songBox.Text) && SongExists != null)
            {
                SongExists(this, new SongCheckEventArgs(songBox.Text));
            }
            else
            {
                SongDoesNotExist(this, new SongCheckEventArgs());
            }
        }

        private void albumBox_TextChanged(object sender, EventArgs e)
        {
            if(Library.AlbumDoesExist(albumBox.Text) && AlbumExists != null)
            {
                AlbumExists(this, new AlbumCheckEventArgs(albumBox.Text));
            }
            else
            {
                AlbumDoesNotExist(this, new AlbumCheckEventArgs());
            }
        }
    }
}
