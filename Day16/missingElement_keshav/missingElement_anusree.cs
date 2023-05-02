using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missingElement_keshav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[100];
            int total = 0,element;
            Console.WriteLine("Enter the size:");
            int N =int.Parse(Console.ReadLine());
            int sum = N * (N + 1) / 2;
          
            Console.WriteLine("Enter the elements");
            for(int i = 0; i < N-1; i++)
            {
              arr[i] =int.Parse(Console.ReadLine());
                total=total+arr[i];
                
            }
            
            element = sum - total;
            Console.WriteLine("Missing element :" + element);
        }
    }
}
