using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the value:");

            int b = int.Parse(Console.ReadLine());
            int[] a=new int[5];
            try
            {
                int i = 10 / b;
                a[14] = 9;
            }
            catch(DivideByZeroException e)
            { 

                Console.WriteLine("Divide by zero error");
            }

            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of bound");
            }
            finally
            {
                Console.WriteLine("finally");
            }

            Console.WriteLine("Remaining program");

        }
    }
}
