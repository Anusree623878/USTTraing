using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirment4
{
    public class Sedan : Car

    {

        public bool _absEnabled;

        public Int32 _bootSpace;

        public bool AbsEnabled

        {

            get { return _absEnabled; }

            set { _absEnabled = value; }

        }

        public Int32 BootSpace

        {

            get { return _bootSpace; }

            set { _bootSpace = value; }

        }

        public Sedan()

        {

        }

        public Sedan(bool absEnabled, int bootSpace, long id, string name) : base(id, name)

        {
            Id=id; 
            Name=name;


            this.AbsEnabled = absEnabled;

            this.BootSpace = bootSpace;

        }
        public override double  CalculateDriveCost(double km) {
            double cost = 0;
            if (BootSpace > 600)
            {
                cost = 15 + (15 * 0.20);
            }
            else
            {
                cost = 15;

            }

        }
    }
}




