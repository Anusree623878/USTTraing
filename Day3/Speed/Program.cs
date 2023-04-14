using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float distance, timesec, kph, mph, hour, sec, min;
            Console.WriteLine("Enter distance and time in hour min and sec");
            distance=int.Parse(Console.ReadLine()); 
            hour=int.Parse(Console.ReadLine()); 
            min=int.Parse(Console.ReadLine());
            sec=int.Parse(Console.ReadLine());
            timesec = (hour * 3600) + (min * 60) + sec;
            kph = (distance / 1000.0f) / (timesec / 3600.0f);
            mph = kph / 1.60344f;
            Console.WriteLine($" The kilometer per hour is {kph}");
            Console.WriteLine($"The miles per hour is {mph}");
            Console.ReadLine();
        }
    }
}
