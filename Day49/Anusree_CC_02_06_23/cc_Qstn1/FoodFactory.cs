using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc_Qstn1
{
    interface Food
    {
        void GetType();
    }

    class Pizza : Food
    {
        public void GetType()
        {
            Console.WriteLine("The factory returned class Pizza");
            Console.WriteLine("Someone ordered Fast Food");
        }
    }

    class Cake : Food
    {
        public void GetType()
        {
            Console.WriteLine("The factory returned class Cake");
            Console.WriteLine("Someone ordered a Dessert!");
        }
    }

    class FoodFactory
    {
        public Food GetFood(string type)
        {
            if (type.Equals("pizza", StringComparison.OrdinalIgnoreCase))
            {
                return new Pizza();
            }
            else if (type.Equals("cake", StringComparison.OrdinalIgnoreCase))
            {
                return new Cake();
            }
            else
            {
                return null;
            }
        }
    }
}
