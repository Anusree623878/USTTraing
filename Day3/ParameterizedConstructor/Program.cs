using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedConstructor
{
    public class Employee
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            Emp e2 = new Emp(1); 
            Emp e3 = new Emp(2);
            Console.WriteLine(e2.EmpId);
            Console.WriteLine();
            Console.WriteLine(e3.EmpId);

        }
    }
}
