using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 145, 198, 76, 99, 88, 123 };
            int temp;
            Console.WriteLine("Array Elements before Sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i +" ");
            }

            for (int i = 0; i <= arr.Length-2; i++)

            {
                for (int j = 0; j <= arr.Length-2; j++)
                {


                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine("\nSorted Array:");
            foreach(int p in arr)
            {
                Console.Write(p +" ");
            }
            Console.WriteLine("\n");

        }
    }
}
