using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirment2
{
    public class Car
    {
        long _id;
        public long Id { 
            get { return _id; }
            set { _id = value; }
        
        }

        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        Int32 _makeYear;
        public Int32 MakeYear
        {
            get { return _makeYear; }
            set
            {
                _makeYear = value;
            }
        }

        string _company;
        public string Company
        {
            get { return _company; }
            set
            {
                _company = value;
            }
        }

        Int32 _comfortLevel;
        public Int32 ComfortLevel
        {
            get { return _comfortLevel; }
            set
            {
                _comfortLevel = value;
            }
        }

        private List<Car> _cars;
        public List<Car> Cars
        {
            get { return _cars; }
            set { _cars = value; }
        }


        public Car() {
            _cars = new List<Car>();

        }

        public Car(long id, string name, string model, int makeYear, string company, int comfortLevel)
        {
            Id = id;
            Name = name;
            Model = model;
            MakeYear = makeYear;
            Company = company;
            ComfortLevel = comfortLevel;
           
        }

        public static Car FindCar(long id,List<Car> cars) 
        {
            foreach (Car car in cars)
            {
                if (car.Id == id)
                {
                    return car;
                }
            }
            return null;
        }

    }
}
