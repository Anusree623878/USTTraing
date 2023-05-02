using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Requirment3
{
    public class SongBO

    {

        public static List<Song> FindSong(List<Song> songList, string type)

        {

            return songList.Where(song => song.SongType == type).ToList();

        }

        public List<Song> FindSong(List<Song> SongList, DateTime dateCreated)

        {

            return SongList.Where(song => song.DateDownloaded == dateCreated).ToList();

        }

        public List<Song> FindSong(List<Song> SongList, double rating)

        {

            return SongList.Where(song => song.Rating == rating).ToList();

        }

    }

}

