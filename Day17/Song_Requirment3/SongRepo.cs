using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Requirment3
{
    public class SongRepo

    {

        public static List<Song> song = new List<Song>

    {

      new Song{Name="Shape of you",Artist="Ed Sheeran",SongType="Pop",Rating=4.8,NumberOfDownloads=100000,DateDownloaded=DateTime.Parse("12-01-2018")},

      new Song{Name="Perfect",Artist="Ed Sheeran",SongType="Pop",Rating=4.5,NumberOfDownloads=12000,DateDownloaded=DateTime.Parse("04-05-2016")},

      new Song{Name="Something ",Artist="Coldplay",SongType="Melody",Rating=4.5,NumberOfDownloads=105421,DateDownloaded=DateTime.Parse("05-07-1997")},

      new Song{Name="Mercy AAA",Artist="Shawn Mendes",SongType="Jazz",Rating=4.8,NumberOfDownloads=214500,DateDownloaded=DateTime.Parse("04-05-2016")}

    };

        public static List<Song> GetSong()

        {

            return song;

        }

    }


}
