using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirment4
{


    class UtilityCar : Car

    {

        private bool _rearCoolingVents

        {

            get { return _rearCoolingVents; }

            set { _rearCoolingVents = value; }

        }

        public UtilityCar()

        {

        }

        public UtilityCar(bool rearCoolingVents, long id, string name) : base(id, name)

        {

            _rearCoolingVents = rearCoolingVents;

        }




    }
}
