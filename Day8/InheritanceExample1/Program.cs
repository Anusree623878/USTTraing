using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample1
{

    public class Fruit
    {
        private int fno;
        private string fruitName;

        public int Fno
        {
            get
            {
                return fno;
            }
            set
            {
                fno = value;
            }
        }
        public string FruitName
        {
            get { return fruitName; }
            set
            {
                if (value != null)
                {
                    fruitName = value;
                }
                else
                {
                    Console.WriteLine("Name should not be empty");
                }
            }
        }

        public Fruit()
        {
        }
        public Fruit(int fnum, string fruitName1)
        {
            fno = fnum;
            fruitName = fruitName1;
        }
        public void display()
        {
            Console.WriteLine("Fruit no:" + fno);
            Console.WriteLine("Fruit name:" + fruitName);
        }


    }

        public class Orange : Fruit
        {
            string _origin;
            private string[] origins = { "Maharashtra", "Himachal", "Thelungana" };

            public string Origin
            {
                get
                {
                    return _origin;
                }
                set
                {
                    Array.Sort(origins);
                    if (origins.Contains(value))
                    {
                        _origin = value;

                    }
                    else
                    {
                        Console.WriteLine("Invalid State");
                    }
                }
            }
            public Orange()
            {

            }
            public Orange( int fnum, string name,string origin) 
            :base(fnum,name)
            {
                Origin = origin;
               
            }
            public new void display()
            {
                base.display();
                Console.WriteLine("Origin: " +Origin);

            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                Orange or=new Orange(102,"apple","Himachal");
              
                or.display();


                //Orange or2 = new Orange(103, "Orange", "Maharashtra");
                //or2.display();
            }
        }
    
}
