using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaConstructor
{
    public class Product
    {
       public String Ename;
       public int Eid;
        public Product()
        { 
        }
        public Product( String Pname,int Pid)
        {
            Ename = Pname;
            Eid=Pid;

        }

    }
}
