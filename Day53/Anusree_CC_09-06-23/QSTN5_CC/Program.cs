using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSTN5_CC
{
    interface IAdvancedArithmetic
    {
        int DivisorSum(int n);
    }
    class CSharpInterface : IAdvancedArithmetic
    {
        public int DivisorSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            CSharpInterface cSharpInterface = new CSharpInterface();
            int result = cSharpInterface.DivisorSum(n);
            Console.WriteLine(result);
        }
    }
}
