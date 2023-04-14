using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedConstructor
{
    public class Emp
    {
        public int EmpId;

        public Emp() 
        { 

        }
        public Emp(int empId)
        {
            EmpId = empId;
        }   
    }
}
