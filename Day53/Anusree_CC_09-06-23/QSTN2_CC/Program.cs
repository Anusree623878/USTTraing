using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSTN2_CC
{
    class Animal
    {
        public void Walk()
        {
            Console.WriteLine("I am walking");
        }
    }
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("I am flying");
        }
        public void Sing()
        {
            Console.WriteLine("I am singing");
        }
    }
    class JavaInheritance1
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            bird.Walk();
            bird.Fly();
            bird.Sing();
        }
    }
}
