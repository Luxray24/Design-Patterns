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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2 f2 = new Form2();
            f2.Location = new Point(
                            this.Location.X + this.Size.Width + 10,
                            this.Location.Y);
            f2.SongExists += new Form2.SongCheckEventHandler(SongExists);
            f2.SongDoesNotExist += new Form2.SongCheckEventHandler(SongDoesNotExist);
            f2.AlbumExists += new Form2.AlbumCheckEventHandler(AlbumExists);
            f2.AlbumDoesNotExist += new Form2.AlbumCheckEventHandler(AlbumDoesNotExist);
            f2.Show();
        }

        void SongExists(Object sender, SongCheckEventArgs e)
        {
            for (int i = 0; i < Library.library.Count(); i++)
            {
                for (int j = 0; j < Library.library[i].Songs.Count(); j++)
                {
                    if (e.s_SongName.ToLower() == Library.library[i].Songs[j].Name.ToLower())
                    {
                        songResultBox.Items.Add("Title: " + Library.library[i].Songs[j].Name);
                        songResultBox.Items.Add("Artist: " + Library.library[i].Artist);
                        songResultBox.Items.Add("Album: " + Library.library[i].Name);
                        songResultBox.Items.Add("Genre: " + Library.library[i].Genre);
                        songResultBox.Items.Add("Length: " + Library.library[i].Songs[j].Length);
                        songResultBox.Items.Add("Track: " + Library.library[i].Songs[j].TrackNum + " of " + Library.library[i].TrackTotal);
                        songResultBox.Items.Add("Year: " + Library.library[i].Year);
                    }
                }
            }
        }

        void SongDoesNotExist(Object sender, SongCheckEventArgs e)
        {
            songResultBox.Items.Clear();
        }

        void AlbumExists(Object sender, AlbumCheckEventArgs e)
        {
            for(int i = 0; i < Library.library.Count(); i++)
            {
                if(e.a_AlbumName.ToLower() == Library.library[i].Name.ToLower())
                {
                    albumResultBox.Items.Add("Name: " + Library.library[i].Name);
                    albumResultBox.Items.Add("Artist: " + Library.library[i].Artist);
                    albumResultBox.Items.Add("Genre: " + Library.library[i].Genre);
                    albumResultBox.Items.Add("Number of Tracks: " + Library.library[i].TrackTotal);
                    albumResultBox.Items.Add("Album Length: " + Library.library[i].Length);
                    albumResultBox.Items.Add("Year: " + Library.library[i].Year);
                    albumResultBox.Items.Add("Songs:");
                    for (int j = 0; j < Library.library[i].Songs.Count(); j++)
                    {
                        albumResultBox.Items.Add("    " + Library.library[i].Songs[j].TrackNum + " - " + Library.library[i].Songs[j].Name + " - " + Library.library[i].Songs[j].Length);
                    }
                }
            }
        }

        void AlbumDoesNotExist(Object sender, AlbumCheckEventArgs e)
        {
            albumResultBox.Items.Clear();
        }
    }
}
