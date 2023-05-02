using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowApplication
{
   
        class MangoEventArgs : EventArgs
        {
            public MangoEventArgs(string type, int number)
            {
                MangoInfo = type;
                Number = number;
            }
            public string MangoInfo { get; private set; }
            public int Number { get; private set; }
        }
    
}
