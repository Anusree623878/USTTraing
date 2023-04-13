using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public class Polymorphism
    {
        static void Main(string[] args)
        {
            // normal call
            Shape s1= new Shape();
            s1.DrawShap();

            // normal call
            Rectangle r1= new Rectangle();
            r1.DrawShap();
           
            // UPCASTING  circle
            Shape s2 = new Circle();
            s2.DrawShap();


            // UPCASTING rectangle 
            Shape s3=new Rectangle();
            s3.DrawShap();
            // Array of references of base class referencing 
            // Derived class object(UPCASTING)

            Shape[] p =
            {
                new Circle(),
                new Rectangle(),
                new Circle(),
                new Rectangle(),
                new Circle(),
            };
            for(int i=0;i<p.Length; i++)
            {
                p[i].DrawShap();
            }


            Shape t = null;
            Console.WriteLine("Enter shape");
            string shape=Console.ReadLine();
            if(shape.ToLower()=="circle")
            {
                t = new Circle();
            }
            else if (shape.ToLower() == "rectangle")
            {
                t = new Rectangle();
            }
            t.DrawShap();
        }
    }
}
