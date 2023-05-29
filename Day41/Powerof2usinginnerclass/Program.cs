using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerof2usinginnerclass
{
    public class Program

    {

        public static void Main(string[] args)

        {

            int number = 8;

            PowerOfTwoChecker checker = new PowerOfTwoChecker(number);

            bool isPowerOfTwo = checker.IsPowerOfTwo();

            Console.WriteLine($"{number} is{(isPowerOfTwo ? "" : " not")} a power of 2.");

        }

    }





}
