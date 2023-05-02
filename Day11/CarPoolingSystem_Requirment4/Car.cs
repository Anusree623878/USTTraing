using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirment4
{
    public abstract class Car

    {

         public long _id;

        string _name;

        public long Id

        {

            get { return _id; }

            set { _id = value; }

        }

        public string Name

        {

            get { return _name; }

            set { _name = value; }

        }

        public Car()

        {

        }

        public Car(long id, string name)

        {

            Id = id;

            Name = name;

        }

        public abstract double CalculateDriveCost(double km);


       

    }

}



