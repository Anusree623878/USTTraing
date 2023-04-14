using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCircle2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double r = 0.0 , area;
            Console.WriteLine("Enter the Radius:");
            r = double.Parse(Console.ReadLine());
            area = calArea(r);
            Console.WriteLine("Area of Circle having radius {0} is {1}", r, area);
        }
        static double calArea(double rr)
        {
            double area;

            area = 3.14 * rr * rr;
            return  area;
        }
    }
}
