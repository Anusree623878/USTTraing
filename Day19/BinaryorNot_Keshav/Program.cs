using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryorNot_Keshav
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n=int.Parse(Console.ReadLine());

            string result = booleann(n);

        }
        public string booleann(int n){
            if (n < 0)
            return "yes";

    }
}
