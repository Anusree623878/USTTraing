 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedConstructor2
{
   
        public class Exercise1
        {
            public static void Main()
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
