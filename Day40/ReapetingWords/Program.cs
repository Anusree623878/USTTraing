using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReapetingWords
{
    internal class Program
    {

        public static string[] removeDupli(string[] stms, int n)
        {
            for (int i = 0; i < n; i++)
            {

                string sentence = stms[i];

                string result = Regex.Replace(sentence, @"\b(\w+)(\s+\1)+\b", "$1", RegexOptions.IgnoreCase);

                stms[i] = result;

            }
            return stms;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size:");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sentences");
            string[] stms=new string[n];
            for(int i = 0; i < n; i++)
            {
                stms[i] = Console.ReadLine();
            }

            string[] result = removeDupli(stms, n);
            foreach(string s in result) 
            {
                Console.WriteLine(s);
            }
        }
    }
}
