using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingchallenge30qstn1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            BitSet bs1 = new BitSet(n);
            BitSet bs2 = new BitSet(n);

            for (int i = 0; i < m; i++)
            {
                string[] operation = Console.ReadLine().Split(' ');
                string op = operation[0];
                int set = int.Parse(operation[1]);
                int index = int.Parse(operation[2]);

                if (op == "AND")
                {
                    if (set == 1)
                    {
                        bs1.And(bs2);
                    }
                    else
                    {
                        bs2.And(bs1);
                    }
                }
                else if (op == "OR")
                {
                    if (set == 1)
                    {
                        bs1.Or(bs2);
                    }
                    else
                    {
                        bs2.Or(bs1);
                    }
                }
                else if (op == "XOR")
                {
                    if (set == 1)
                    {
                        bs1.Xor(bs2);
                    }
                    else
                    {
                        bs2.Xor(bs1);
                    }
                }
                else if (op == "FLIP")
                {
                    if (set == 1)
                    {
                        bs1.Flip(index);
                    }
                    else
                    {
                        bs2.Flip(index);
                    }
                }
                else if (op == "SET")
                {
                    if (set == 1)
                    {
                        bs1.Set(index);
                    }
                    else
                    {
                        bs2.Set(index);
                    }
                }

                Console.WriteLine($"{bs1.Cardinality()} {bs2.Cardinality()}");
            }
        }
    }


}

