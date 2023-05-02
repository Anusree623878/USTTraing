using Song_Requirment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongRequirement4
{
  
        public class RatingComparer : IComparer<Song>

        {

            int IComparer<Song>.Compare(Song x, Song y)

            {

                return y.Rating.CompareTo(x.Rating);

            }
        }
}
