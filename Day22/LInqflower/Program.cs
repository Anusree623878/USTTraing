using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInqflower
{
    public class Flower
    {
        
        static void Main(string[] args)
        {

            List<Flower> FlowerList = new List<Flower>();
            FlowerList.Add(new Flower("Dalhia",6));
            FlowerList.Add(new Flower("rose", 9));
            FlowerList.Add(new Flower("daffodil", 2));

            var fquery = from f in FlowerList
                         where f.petals > 4;
                          
        }
    }
}
