using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Requirement5
{
   public class Program
    {
        static void Main(string[] args)
        {

            List<Song> ls = new List<Song>();
            Console.WriteLine("Enter the number of songs");
            int n=int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
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

                ls.Add(s);
            }

            SortedDictionary<string,int> sd=new SortedDictionary<string,int>();
            sd=Song.CalculateTypeCount(ls);

           
            
                Console.WriteLine("Songtype \t Count");

                foreach (var item in sd)

                {

                    Console.WriteLine(item.Key + "\t\t" + item.Value);

                }

            }
        
    }
}
