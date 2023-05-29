using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDiamensionalArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size:");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elemets :");
            int[] arr= new int[n];
            for(int i=0; i<n; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The elements are ");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
