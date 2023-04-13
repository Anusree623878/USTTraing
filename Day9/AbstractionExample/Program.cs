using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{


    abstract class Figure
    {
        public int Diamention;
        public abstract double Area();
        public abstract double  Perimeter();
    }

    class Square:Figure
    {
        public override double Area()
        {
            return Diamention * Diamention; 
        }
        public override double Perimeter()
        {
            return 4 * Diamention;
        }
    }
    class Circle: Figure
    {
        public override double Area()
        {
            return Math.PI * Diamention * Diamention;
        }
        public override double Perimeter()
        {
            return 2*Math.PI * Diamention;
        }
    }
   public class Program
    {
        static void Main(string[] args)
        {
            Figure f = new Square(); // new Circle()
            f Diamention = 10;
            Console.WriteLine(f.Area());
            Console.WriteLine(f.Perimeter());
        }
    }
}
