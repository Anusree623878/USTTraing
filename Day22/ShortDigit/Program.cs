using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine($"The word {d} is shorter than its value.");
            }
        }
    }
}
