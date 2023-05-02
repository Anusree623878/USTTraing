using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Requirment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> song = SongRepo.GetSong();

            Song s = new Song();

            SongBO sbo = new SongBO();

            // Print the details of each song to the console

            Console.WriteLine("Name\t\tArtist\t SongType\t Rating\t NumberofDownloads\t DateDownloaded");

            foreach (Song son in song)

            {

                Console.WriteLine(son);

            }

            //search

            int ch;

            do

            {

                Console.WriteLine();

                Console.WriteLine("Enter your choice :");

                Console.WriteLine("1: Song Type\n 2: Date of download \n 3: Rating \n 4: Exit");

                ch = int.Parse(Console.ReadLine());

                switch (ch)

                {

                    case 1:

                        Console.WriteLine();

                        Console.WriteLine("Enter Song Type");

                        Console.WriteLine();

                        s.SongType = Console.ReadLine();

                        Console.WriteLine("-----------------------");

                        List<Song> _songs = SongBO.FindSong(song, s.SongType);

                        foreach (Song son in _songs)

                        {

                            Console.WriteLine(son);

                        }

                        Console.WriteLine("-----------------------");

                        Console.WriteLine();

                        break;

                    case 2:

                        Console.WriteLine("Enter date");

                        Console.WriteLine();

                        s.DateDownloaded = DateTime.Parse(Console.ReadLine());

                        List<Song> _songs2 = sbo.FindSong(song, s.DateDownloaded);

                        Console.WriteLine("-----------------------");

                        foreach (Song son in _songs2)

                        {

                            Console.WriteLine(son);

                        }

                        Console.WriteLine("-----------------------");

                        Console.WriteLine();

                        break;

                    case 3:

                        Console.WriteLine();

                        Console.WriteLine("Enter rating");

                        s.Rating = double.Parse(Console.ReadLine());

                        List<Song> _songs3 = sbo.FindSong(song, s.Rating);

                        Console.WriteLine("-----------------------");

                        foreach (Song son in _songs3)

                        {

                            Console.WriteLine(son);

                        }

                        Console.WriteLine("-----------------------");

                        Console.WriteLine();

                        break;

                }

            }

            while (ch != 0);

            Console.ReadKey();

        }



    }
    
}
