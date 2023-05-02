using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Subarrayprgm_keshav
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the size:");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            Console.WriteLine("Enter the sum");
            int total = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the array elements");
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

           // foreach (int i in arr)
            //{
               // Console.WriteLine(i);
            //}

            ArrayList subarr = new ArrayList();
            for (int i = 0; i <= N; i++)
            {
                int sum = 0;
                for (int j = i; j < N; j++)
                {
                    if ((sum + arr[j]) <= total)
                    {
                        sum = sum + arr[j];
                    }
                    else
                    {
                        break;
                    }

                    if (sum == total)
                    {

                        subarr.Add(i + 1);
                        subarr.Add(j + 1);
                        
                    }
                    
                }
               
            }
            foreach (int t in subarr)
            {
                Console.WriteLine(t);
            }
            subarr.Add(-1);
            
            
        }
    }
}
