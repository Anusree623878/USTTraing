using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DecimalNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0,i;
            int[] arr = new int[10];
            
            Console.WriteLine("Enter the decimal number");
            n=int.Parse(Console.ReadLine());

            for(i = 0; n>0; i++)
            {
                arr[i] = n%2;
                n = n / 2;
            }
            Console.Write("Binary number: ");
            for(i = i-1; i >= 0; i--)
            {
                Console.Write(arr[i]);
                
            }



        }
    }
}
