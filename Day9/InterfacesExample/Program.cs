using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    interface IFigure
    {
        int Diamension { get; set; }
        double Area();
        double Perimeter();

    }
    class Circle: IFigure
    {
        private int _radius;
        public int Diamension
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public double Area()
        {
            return Math.PI*_radius*_radius;
        }
        public double Perimeter()
        {
            return 2*Math.PI*_radius; 
        }
    }
    public class Square:IFigure
    {
        private int _radius;
        public int Diamension
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public double Area()
        {
            return _radius * _radius;
        }
        public double Perimeter()
        {
            return 4 * _radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFigure fig = null;
            Console.WriteLine("Enter C for Circle and S for Square");
            string ch=Console.ReadLine();

            if (ch == "C")
            {
                fig=new Circle();

            }
            else if (ch == "S") {
                fig=new Square();
            }
            fig.Diamension = 10;
            Console.WriteLine("Area : " +fig.Area());
            Console.WriteLine( "Perimeter : "+fig.Perimeter());
        }
    }
}
