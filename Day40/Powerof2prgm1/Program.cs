using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerof2prgm1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n=int.Parse(Console.ReadLine());

            bool check = isPowerOfTwo(n);

             
            Console.WriteLine($"{n} is{(check? "" : " not")} a power of 2");



            bool isPowerOfTwo(int x)

            {

                while (((x % 2) == 0) && x > 1)

                {

                    x /= 2;

                }

                return (x == 1);

            }

        }



    }
}

