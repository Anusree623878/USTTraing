using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc_Qstn3
{


    class Solution
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> pairs = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string first = input[0];
                string second = input[1];
                string pair = $"{first} {second}";

                pairs.Add(pair);

                Console.WriteLine(pairs.Count);
            }
        }
    }

}
