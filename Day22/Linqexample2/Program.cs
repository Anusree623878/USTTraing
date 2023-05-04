using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqexample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dalia", "rose", "lotus", "lilly", "hibiscusghtfdrg", "daffodil" };

            var fQuery=
                from flower in flowers
                let len=flower.Length  
                where len>2 && len<7
                select flower.ToUpper();

            foreach (string f in fQuery)
            {
                Console.WriteLine(f);
            }
        }
    }
}
