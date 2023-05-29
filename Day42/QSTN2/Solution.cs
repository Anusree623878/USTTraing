using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSTN2
{


   

    class Result
    {
        public static long solve(List<int> arr)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            long count = 0;

            foreach (int num in arr)
            {
                int complement = num;
                if (frequency.ContainsKey(complement))
                    count += frequency[complement];

                if (frequency.ContainsKey(num))
                    frequency[num]++;
                else
                    frequency[num] = 1;
            }

            return count;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            long result = Result.solve(arr);
            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }



}
