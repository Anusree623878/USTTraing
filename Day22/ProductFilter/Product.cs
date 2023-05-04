using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFilter
{
   public class Product
    {
        private int _unitsInStock;
        private string _name;
        private double _unitPrice;

        public int UnitsInStock
        {
            get { return _unitsInStock; }
            set { _unitsInStock = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
         public double UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
        public Product() { }
        public Product(int unitsinstock,string name,double unitprice)
        {
            _unitsInStock=unitsinstock;
            _name = name;
            _unitPrice = unitprice;
        }

        public static List<Product> GetProductList()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product(101, "shirt",3.00));
            list.Add(new Product(0, "mund", 4.00));
            list.Add(new Product(10, "shall", 8.00));

            return list;
        }
    }
}
