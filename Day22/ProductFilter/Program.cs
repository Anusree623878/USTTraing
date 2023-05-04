using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = Product.GetProductList();

            var soldOutProducts = from prod in products
                                  where prod.UnitsInStock == 0
                                  select prod;

            Console.WriteLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                Console.WriteLine($"{product.Name} is sold out!");
            }

            Console.WriteLine();

            var expensiveInStockProducts = from prod in products
                                           where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00
                                           select prod;

            Console.WriteLine("In-stock products that cost more than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                Console.WriteLine($"{product.Name} is in stock and costs more than 3.00:");
            }
        }
    }
}
