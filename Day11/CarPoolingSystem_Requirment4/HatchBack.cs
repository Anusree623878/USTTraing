using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirment4
{
        public class HatchBack : Car

        {

            private bool _powerWindowsEnabled;

            private bool _automaticGear;

            public bool PowerWindowsEnabled

            {

                get { return _powerWindowsEnabled; }

                set { _powerWindowsEnabled = value; }

            }

            public bool AutomaticGear

            {

                get { return _automaticGear; }

                set { _automaticGear = value; }

            }

            public HatchBack()

            {

            }

            public HatchBack(bool powerWindowsEnabled, bool automaticGear, long id, string name) : base(id, name)

            {
                 Id = id;
                Name= name; 

                PowerWindowsEnabled = powerWindowsEnabled;

                AutomaticGear = automaticGear;

            }
        
        public override double CalculateDriveCost(double km)
        {
            double cost = 0;
            if (AutomaticGear)
            {
                cost = 12;
            }
            else
            {
                cost = 10;
            }
            return cost * km;
        }
        }




   
}
