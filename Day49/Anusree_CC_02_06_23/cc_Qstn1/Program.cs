using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace cc_Qstn1
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodFactory factory = new FoodFactory();

            string foodType = Console.ReadLine();

            Food food = factory.GetFood(foodType);

            if (food != null)
            {
                food.GetType();
            }
        }
    }
}
