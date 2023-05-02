using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Requirment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                List<Song> songs = new List<Song>();

                for (int i = 0; i < 2; i++)

                {

                    Console.WriteLine("enter name,artist,songtype,rating ,number of downloads,date of download");

                    string input = Console.ReadLine();

                    string[] arr = input.Split(',');

                    string name = arr[0];

                    string artist = arr[1];

                    string songtype = arr[2];

                    double rating = double.Parse(arr[3]);

                    int numofdownloads = int.Parse(arr[4]);

                    DateTime dateofdownloads = Convert.ToDateTime(arr[5]);

                    Song s = new Song(name, artist, songtype, rating, numofdownloads, dateofdownloads);

                    songs.Add(s);

                }

                foreach (Song s in songs)

                {

                    Console.WriteLine(s);

                }

                if (songs[0].Equals(songs[1]))

                {

                    Console.WriteLine("songs are same");

                }

                else

                {

                    Console.WriteLine("Different songs");

                }

            }

        
    }
    
}
