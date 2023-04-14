// Program to sort an array using Selection Sort 

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int size = 0;
            Console.WriteLine("Enter the Array Size:");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the elements ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            arraySort(arr);
            Console.WriteLine("Sorted Array :");
            printarray(arr);

        }
        static void arraySort(int[] arr)
        {
            for (int i = 0; i <= arr.Length; i++)
            {
                int min_index = i;
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[min_index])
                    {
                        min_index = j;
                    }
                    int temp = arr[j];
                    arr[j] = arr[min_index];
                    arr[min_index] = temp;
                }
            }

        }
        static void printarray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }




    }
}
