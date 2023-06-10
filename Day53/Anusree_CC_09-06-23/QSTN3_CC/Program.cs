using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSTN3_CC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Adder object

            Adder a = new Adder();

            // Print the name of the superclass on a new line

            Console.WriteLine("My superclass is: " + a.GetType().BaseType.Name);

            // Print the result of 3 calls to Adder's `add(int,int)` method as 3 space-separated integers:

            Console.WriteLine(a.Add(10, 32) + " " + a.Add(10, 3) + " " + a.Add(10, 10));
        }
    }
    class Arithmetic
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    class Adder: Arithmetic

    {

    }

}

