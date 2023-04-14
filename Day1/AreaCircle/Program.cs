// Finding the area of the circle
using System;


namespace AreaCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 0.0;
            double pi = 3.14;
            double area = 0.0;
            // get the radius from user
            Console.WriteLine("Enter the Radius: ");
            // Reading from console
            r = double.Parse(Console.ReadLine());
            area = pi * r * r;
            // area finding 
            Console.WriteLine("Area:");
            Console.WriteLine(area);
            

        }
    }
}
