using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSTN1
{
    

    class Solution
    {
        static void plusMinus(int[] arr)
        {
            int n = arr.Length;
            float positiveCount = 0;
            float negativeCount = 0;
            float zeroCount = 0;

            foreach (int num in arr)
            {
                if (num > 0)
                    positiveCount++;
                else if (num < 0)
                    negativeCount++;
                else
                    zeroCount++;
            }

            float positiveRatio = positiveCount / n;
            float negativeRatio = negativeCount / n;
            float zeroRatio = zeroCount / n;

            Console.WriteLine(positiveRatio.ToString("F6"));
            Console.WriteLine(negativeRatio.ToString("F6"));
            Console.WriteLine(zeroRatio.ToString("F6"));
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            plusMinus(arr);
        }
    }

}
