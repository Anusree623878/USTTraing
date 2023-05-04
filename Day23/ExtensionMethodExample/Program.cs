using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "get the word count of the string";
            int n = GetWordCount.GetWordCountstr(s);

            Console.WriteLine("word :"+s);
            Console.WriteLine("word count:" +n);
        }
    }
}
