using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> li = new List<Member>();


            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Member {0}", i + 1);

                Console.WriteLine("Id:");
                long id=long.Parse(Console.ReadLine());

                Console.WriteLine("first name:");
                string firstName=Console.ReadLine();

                Console.WriteLine("last name:");
                string lastName=Console.ReadLine();

                Console.WriteLine("email:");
                string email=Console.ReadLine();

                Console.WriteLine("contact number:");
                string contactNumber=Console.ReadLine();

                Console.WriteLine("license number:");
                string licenseNumber=Console.ReadLine();

                Console.WriteLine("license start date:");
                DateTime licenseStartDate = DateTime.ParseExact(Console.ReadLine(),"dd-mm-yyyy",null);

                Console.WriteLine("license expiry date:");
                DateTime licenseExpiryDate = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", null);

                Member m1=new Member(id,firstName,lastName,email,contactNumber,licenseNumber,licenseStartDate,licenseExpiryDate);
                li.Add(m1);

            }

            if (li[0].Equals(li[1]))
            {
                Console.WriteLine("Member1 is same as Member2");
            }
            else
            {
                Console.WriteLine("Member1 and Member2 are different");
            }
            foreach (Member m in li)
            {
                Console.WriteLine(m.ToString());
            }
        }
    }
}
