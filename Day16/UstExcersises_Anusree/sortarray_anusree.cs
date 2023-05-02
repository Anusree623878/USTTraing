using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortArray_keshav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size:");

            int N=int.Parse(Console.ReadLine());

            int[] arr = new int[N];
            Console.WriteLine("Enter elements");
            for(int i=0; i<N; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            int temp = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (arr[i] >= 3)
                    {
                        Console.WriteLine("0");
                    }
                    else if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
           Console.WriteLine("sorted array");
            foreach (int i in arr)
            {

                Console.WriteLine(i);
            }
        }
    }
}
