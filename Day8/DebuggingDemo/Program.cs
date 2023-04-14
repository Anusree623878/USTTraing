using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingDemo
{
    internal class DebuggingDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int j = int.Parse(Console.ReadLine());

            foo(i, j);
            Console.WriteLine("Debugging is over");

        }
        public static void foo(int x, int y) 
        {
            int t = 100;
            for(int i=x;i<=y;i++)
            {
                Console.WriteLine("India");
                t = t + 34;
            }
        }
    }
}
