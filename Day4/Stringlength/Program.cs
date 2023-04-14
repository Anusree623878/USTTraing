using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringlength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int l = 0;

            System.Console.WriteLine("Write your string at here");

            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l = l + 1;
            }
            Console.WriteLine("length {0}", l);
        }
    }
    }

