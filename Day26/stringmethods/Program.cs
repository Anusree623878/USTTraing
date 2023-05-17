using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringmethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the string ");
            string str=Console.ReadLine();
            Console.WriteLine("Length: ");
            Console.WriteLine(str.Length);
            Console.WriteLine("Upper: ");
            Console.WriteLine(str.ToUpper());
            Console.WriteLine("Lower: ");
            Console.WriteLine(str.ToLower());
            Console.WriteLine("Enter another string to replace ");
            string str2=Console.ReadLine();
            Console.WriteLine("Replace: ");
            Console.WriteLine(str.Replace(str, str2));
            str2=str2.Remove(7);
            Console.WriteLine(str2);
            char[] chars = str2.ToCharArray();
            foreach(char c in chars)
            {
                Console.WriteLine(c);
            }

            str2 = str2.Substring(1,4);
            Console.WriteLine(str2);

            bool isContains = str2.StartsWith("n");
            Console.WriteLine(isContains);
        }
    }
}
