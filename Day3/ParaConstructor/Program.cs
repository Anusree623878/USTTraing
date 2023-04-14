using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaConstructor
{
    public class ParameterizedConstructor
    {
        static void Main(string[] args)
        {
            String name;
            int id;
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Id");
            id= int.Parse(Console.ReadLine());

            Product p1= new Product();
            Product p2= new Product(name ,id);
            Console.WriteLine("Name is "+p2.Ename);
            Console.WriteLine("Id is " + p2.Eid);

        }
    }
}
