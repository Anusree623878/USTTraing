using System;
using System.Collections.Generic;

namespace Swap2num_Keshav
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            list=swapping(a,b);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
          

        }

        public static List<int> swapping(int aa, int bb)
        {
            List<int> li = new List<int>();
            
            li.Add(bb);
            li.Add(aa);
            return li;
        }
    }
}
