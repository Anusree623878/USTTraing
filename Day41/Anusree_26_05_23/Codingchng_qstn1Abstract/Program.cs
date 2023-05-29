
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingchng_qstn1Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the title");

            string a = Console.ReadLine();

            MyBook new_novel = new MyBook();

            new_novel.setTitle(a);

            Console.WriteLine("The title is:" + new_novel.getTitle());
        }
    }
}
