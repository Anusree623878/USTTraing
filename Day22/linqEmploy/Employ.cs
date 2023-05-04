using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqEmploy
{
  
        public class Employ
        {

            private string _name ;
            private string _city;

            public string Name { get { return _name; } set { _name = value; } }
            public string City { get { return _city; } set { _city = value; } }


        public Employ() { }

        public Employ(string name, string city)
        {
            this._name = name;
            this._city = city;
        }
        }
    }
