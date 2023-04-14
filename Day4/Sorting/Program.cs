using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "volvo", "bike", "Buffer", "zhafa" };
            Array.Sort(cars);
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}
