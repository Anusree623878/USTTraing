using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqEmploy
{
    public class Program {

        static void Main(string[] args)
        {
            List<Employ> Emplist = new List<Employ>();

            Emplist.Add(new Employ("Ravi", "bombay"));
            Emplist.Add(new Employ("kavya", "kannur"));
            Emplist.Add(new Employ("arya", "tvm"));
            Emplist.Add(new Employ("lilly", "bombay"));
            Emplist.Add(new Employ("Rakesh", "allpy"));
            Emplist.Add(new Employ("zakaria", "kannur"));
            Emplist.Add(new Employ("alan", "malpuram"));

            var lquery = from Employ emp in Emplist
                         orderby emp.City
                         group emp by emp.City;
            foreach (var e in lquery) {
                Console.WriteLine("Employee with " + e.Key + "  city");

                foreach (var i in e) { Console.WriteLine(" "+i.Name); } }




        

        }
    }
}
