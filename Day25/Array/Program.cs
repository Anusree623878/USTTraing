using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[10];
            Console.WriteLine("Enter the size:");

            int n=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the elements");
            for(int i=0; i<n; i++) {

                arr[i]=int.Parse(Console.ReadLine());
            }

            
        }
    }
}
