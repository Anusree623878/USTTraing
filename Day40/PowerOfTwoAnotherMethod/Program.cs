using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwoAnotherMethod
{
    public class PowerOfTwo
    {

        public static void Main(string[] args)

        {

            int number = int.Parse(Console.ReadLine());

            bool isPowerOf2 = IsPowerOf2(number);

            Console.WriteLine($"{number} is{(isPowerOf2 ? "" : " not")} a power of 2");

        }

        private static bool IsPowerOf2(int number)

        {

            if (number <= 0)

                return false;

            return (number & (number - 1)) == 0;

        }

    }
}










