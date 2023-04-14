    // area of circle
using System;
namespace MyNamespace1
{
    class Area
    {
        static void Main(string[] args)
        {
            double r = 0;
            double area = 0;

            Console.WriteLine("Enter Radious:");
            r= double.Parse(Console.ReadLine());
            area = CalcArea(r);
            Console.WriteLine($"Area is {area}");

        }
        static double CalcArea(double r)
        {
            double cirarea = 3.14*r*r;
            return cirarea;
        }
    }
}