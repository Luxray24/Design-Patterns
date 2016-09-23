using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class Library
    {
        public static List<Album> library = new List<Album>()
        {
            new Album
            { 
                Songs = new List<Song>
                {
                    new Song { Name = "Papercut", Length = "3:04", TrackNum = "01" },
                    new Song { Name = "One Step Closer", Length = "2:35", TrackNum = "02" },
                    new Song { Name = "With You", Length = "3:23", TrackNum = "03" },
                    new Song { Name = "Points Of Authority", Length = "3:20", TrackNum = "04" },
                    new Song { Name = "Crawling", Length = "3:29", TrackNum = "05" },
                    new Song { Name = "Runaway", Length = "3:04", TrackNum = "06" },
                    new Song { Name = "By Myself", Length = "3:09", TrackNum = "07" },
                    new Song { Name = "In The End", Length = "3:36", TrackNum = "08" },
                    new Song { Name = "A Place For My Head", Length = "3:04", TrackNum = "09" },
                    new Song { Name = "Forgotten", Length = "3:14", TrackNum = "10" },
                    new Song { Name = "Cure For The Itch", Length = "2:37", TrackNum = "11" },
                    new Song { Name = "Pushing Me Away", Length = "3:11", TrackNum = "12" }
                },
                Name = "Hybrid Theory", Artist = "Linkin Park", Genre = "Nu Metal", Year = 2000, TrackTotal = "12", Length = "37:46"
            },
            new Album
            {
                Songs = new List<Song>
                {
                    new Song { Name = "Human Race", Length = "4:09", TrackNum = "01" },
                    new Song { Name = "Painkiller", Length = "2:58", TrackNum = "02" },
                    new Song { Name = "Fallen Angel", Length = "3:06", TrackNum = "03" },
                    new Song { Name = "Landmine", Length = "3:25", TrackNum = "04" },
                    new Song { Name = "Tell Me Why", Length = "3:30", TrackNum = "05" },
                    new Song { Name = "I Am Machine", Length = "3:21", TrackNum = "06" },
                    new Song { Name = "So What", Length = "2:57", TrackNum = "07" },
                    new Song { Name = "Car Crash", Length = "2:50", TrackNum = "08" },
                    new Song { Name = "Nothing's Fair in Love and War", Length = "3:44", TrackNum = "09" },
                    new Song { Name = "One Too Many", Length = "2:41", TrackNum = "10" },
                    new Song { Name = "The End Is Not the Answer", Length = "2:52", TrackNum = "11" },
                    new Song { Name = "The Real You", Length = "3:54", TrackNum = "12" }
                },
                Name = "Human", Artist = "Three Days Grace", Genre = "Alternative Metal", Year = 2015, TrackTotal = "12", Length = "39:27"
            },
            new Album
            {
                Songs = new List<Song>
                {
                    new Song { Name = "Dark", Length = "2:10", TrackNum = "01" },
                    new Song { Name = "Failure", Length = "3:34", TrackNum = "02" },
                    new Song { Name = "Angels Fall", Length = "3:48", TrackNum = "03" },
                    new Song { Name = "Breaking the Silence", Length = "3:01", TrackNum = "04" },
                    new Song { Name = "Hollow", Length = "3:51", TrackNum = "05" },
                    new Song { Name = "Close to Heaven", Length = "4:09", TrackNum = "06" },
                    new Song { Name = "Bury Me Alive", Length = "4:04", TrackNum = "07" },
                    new Song { Name = "Never Again", Length = "3:43", TrackNum = "08" },
                    new Song { Name = "The Great Divide", Length = "4:12", TrackNum = "09" },
                    new Song { Name = "Ashes of Eden", Length = "4:53", TrackNum = "10" },
                    new Song { Name = "Defeated", Length = "3:25", TrackNum = "11" },
                    new Song { Name = "Dawn", Length = "1:52", TrackNum = "12" }
                },
                Name = "Dark Before Dawn", Artist = "Breaking Benjamin", Genre = "Rock", Year = 2015, TrackTotal = "12", Length = "42:42"
            },
            new Album
            {
                Songs = new List<Song>
                {
                    new Song { Name = "Shepherd Of Fire", Length = "5:23", TrackNum = "01" },
                    new Song { Name = "Hail To The King", Length = "5:05", TrackNum = "02" },
                    new Song { Name = "Doing Time", Length = "3:27", TrackNum = "03" },
                    new Song { Name = "This Means War", Length = "6:09", TrackNum = "04" },
                    new Song { Name = "Requiem", Length = "4:23", TrackNum = "05" },
                    new Song { Name = "Crimson Day", Length = "4:57", TrackNum = "06" },
                    new Song { Name = "Heretic", Length = "4:55", TrackNum = "07" },
                    new Song { Name = "Coming Home", Length = "6:26", TrackNum = "08" },
                    new Song { Name = "Planets", Length = "5:56", TrackNum = "09" },
                    new Song { Name = "Acid Rain", Length = "6:38", TrackNum = "10" },
                    new Song { Name = "St. James", Length = "5:01", TrackNum = "11" }
                },
                Name = "Hail To The King", Artist = "Avenged Sevenfold", Genre = "Metalcore", Year = 2013, TrackTotal = "11", Length = "58:20"
            }
        };

        public static bool SongDoesExist(String song)
        {
            for (int i = 0; i < library.Count(); i++)
            {
                for (int j = 0; j < library[i].Songs.Count(); j++)
                {
                    if (song.ToLower() == library[i].Songs[j].Name.ToLower())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool AlbumDoesExist(String album)
        {
            for (int i = 0; i < library.Count(); i++)
            {
                if (album.ToLower() == library[i].Name.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
