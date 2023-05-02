
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber_keshav
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number to check amstrong or not");
            int a=int.Parse(Console.ReadLine());

            int b = a;
            int temp = 0;
            int s = 0;
            while (a > 0)
            {
                s = a % 10;
                temp = (int)(temp +Math.Pow(s,3));
                a = a / 10;
            }
            if (b == temp)
            {
                Console.WriteLine(temp +" is a Amstrong number" );
            }
            else
            {
                Console.WriteLine(temp +" is not an Amstrong number");
            }
        }
    }
}
