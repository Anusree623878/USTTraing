using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1qstn
{
    internal class Program
    {
        // doubles and triples

        public static int buggyfun(List<int> list,int n)
        {
            int score = 0;
            for(int i = 0; i < n - 1; i++)
            {
                if ((list[i] + list[i+1])%2==0)
                {
                    score += 5; ;
                }
            }
            for (int i = 0; i < n -2; i++)
            {
                if ((list[i] + list[i + 1] + list[i+2]) % 2 != 0 && (list[i] * list[i + 1] * list[i + 2]) % 2 == 0)
                {
                    score +=10;
                }
            }

            return score;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the array elements:");
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int t =int.Parse(Console.ReadLine());
                list.Add(t);
            }

            int result = buggyfun(list, n);
            Console.WriteLine("The score:"+result);
        }
    }

}
