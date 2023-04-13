using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public class Shape
    {
        public  virtual void DrawShap()
        {
            Console.WriteLine("Drawing shape");
        }
    }
}
