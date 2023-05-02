using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the diviser:");
            int k = 10;
            int i=int.Parse(Console.ReadLine());
            try
            {
                k = k / i;
                Console.WriteLine(k);

            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
