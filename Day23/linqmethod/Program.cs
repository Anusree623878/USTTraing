using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string collection 
            List<string> slist = new List<string>();
            slist.Add("c sharp ");
            slist.Add("c sharp 2");
            slist.Add("c sharp 3");


            // linq method syntax
            var lresult = slist.Where(s => s.Contains("sharp"));

           foreach (var s in lresult)
            {
                Console.WriteLine(s);
            }
        }
    }
}
