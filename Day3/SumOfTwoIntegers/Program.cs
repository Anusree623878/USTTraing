using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("Enter two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int c = SumOfNum(a, b);
            Console.WriteLine($"Sum of numbers are {c}");

        }
        static int SumOfNum(int a, int b)
        {
            if (a == b) {
                int sum = a + b;
                return sum * 3;
            }
            else
            {
                return a + b;
            }
        }
    }
}
