using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramCodingChallengeqstn2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");

            string str1 = Console.ReadLine();

            Console.WriteLine("enter anagram");

            string anagram = Console.ReadLine();

            check(str1, anagram);

        }

        public static void check(string str1, string anagram)

        {

            str1 = str1.ToLower();

            anagram = anagram.ToLower();

            char[] arr1 = str1.ToCharArray();

            char[] arr2 = anagram.ToCharArray();

            Array.Sort(arr1);

            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length;i++)

            {

                if (arr1[i] == arr2[i])

                {

                    Console.WriteLine("anagram");

                    break;

                }

                else
                {

                    Console.WriteLine("not anagram");

                    break;

                }
            }
        }
    }
}
