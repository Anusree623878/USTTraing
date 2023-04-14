
//Write a program in C# Sharp to count a total number of vowel or consonant in a string.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlphabetsAndConsonents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int count = 0;
            int len = 0;

            Console.WriteLine("Enter the String");
            str = Console.ReadLine();
            Char[] strr = str.ToCharArray();

            for (int i = 0; i < strr.Length; i++)
            {

                if (strr[i] == 'A' || strr[i] == 'E' || strr[i] == 'I' || strr[i] == 'O' || strr[i] == 'U' || strr[i] == 'a' || strr[i] == 'e' || strr[i] == 'i' || strr[i] == 'o' || strr[i] == 'u')
                {
                    count += 1;

                }
                else if (strr[i] > 'a' || strr[i] < 'z' || strr[i] > 'A' || strr[i] < 'Z')
                {
                    len += 1;
                }
            }
            Console.WriteLine("Number of Vowels: {0}", count);
            Console.WriteLine("Number of Consonents:{0}", len);
        }
    }
}


