using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter a Number");

            //read number from user

            int number = Convert.ToInt32(Console.ReadLine());

            //invoke the static method

            double factorial = Factorial(number);

            //print the factorial result

            Console.WriteLine("factorial of" + number + "=" + factorial.ToString());

        }

        public static double Factorial(int number)

        {

            if (number == 0)

                return 1;

            return number * Factorial(number - 1);//Recursive call

        }

    }

}
