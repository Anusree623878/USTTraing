using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunctions
{
    internal class Program
    {
        static void Add(int i,int j)
        {
            Console.WriteLine("Sum :"+(i+j));
        }
        static void Sub(int i, int j)
        {
            Console.WriteLine("Sub :" + (i - j));
        }

        public delegate void reftomethod(int i, int j);
        static void Main(string[] args)
        {
            // Single delegation
            //Add(10, 90);
            //reftomethod r1 = Add;
            // r1(10, 90);
            // reftomethod r2 = Sub;
            //r2.Invoke(10, 90);


            // multiple delegation
            reftomethod multicast = Add;
            multicast += Sub;
            multicast(10, 90);

            Console.WriteLine("After removing Sub");
            multicast -= Sub;
            multicast(10, 90);


        }
    }
}
