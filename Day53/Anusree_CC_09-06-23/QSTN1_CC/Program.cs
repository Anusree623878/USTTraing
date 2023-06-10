using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSTN1_CC
{
    class Program
    {
        static void Main(string[] args)
        { 
            int N = int.Parse(Console.ReadLine().Trim());
            if (N % 2 != 0)
             {
                 Console.WriteLine("Weird");

             }
            else
            {
                if (N >= 2 && N <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (N >= 6 && N <= 20)
                {
                    Console.WriteLine("Weird");
                }
                else if (N > 20)
                {
                    Console.WriteLine("Not Weird");
                }
            }
        }
    }
}