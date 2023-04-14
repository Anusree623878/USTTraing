
//Write a program in C# Sharp to separate the individual characters from a string
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndivindualChara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            


            Console.WriteLine("enter the String:");
            str = Console.ReadLine();
            Console.WriteLine("Indivindual Characters are:");
         

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }

            
            Console.WriteLine("  ");
        }
        }
}
