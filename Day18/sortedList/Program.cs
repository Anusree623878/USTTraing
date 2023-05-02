using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s=new SortedList();
            s.Add("akila", "900");
            s.Add("vrindha", "500");
            s.Add("hani", "800");
            foreach(var item in s.Values)
            {
                Console.WriteLine(item);
            }
            foreach(var item in s.Keys)
            {
                Console.WriteLine(item);
            }


            s.Remove("vrindha");
            Console.WriteLine("The keys are:");
            ICollection k= s.Keys;
            foreach(object i  in k)
            {
                Console.WriteLine(i+" ");
            }
            Console.WriteLine("The values are:");
            ICollection j= s.Values;
            foreach (object i in j)
            {
                Console.WriteLine(i+" ");
            }
        }
    }
}
