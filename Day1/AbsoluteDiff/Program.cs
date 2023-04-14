using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteDiff
{
    // Absolute difference of 2 numbers 
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            Console.WriteLine("Enter the value of n:");
            n=double.Parse(Console.ReadLine());
            double absdiff = Absdiff(n);
            Console.WriteLine($" Absolute difference is : {absdiff}");
        }
        static double Absdiff(double n)
        {
            if(n > 51)
            {
                double r = Math.Abs(n - 51);
                return r * 3;
            }
            else
            {
                return Math.Abs(n- 51);
            }
        }
    }
}
