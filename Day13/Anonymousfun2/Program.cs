using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Anonymousfun2
{
    public class Program
    {
        public delegate int delemethod(int i,int j);
        static void Main(string[] args)
        {
            int sum;
           delemethod result= delegate(int i, int j)
            {
                return i + j;
            };

            sum = result(20, 9);
            Console.WriteLine(sum);
        }
    }
}
