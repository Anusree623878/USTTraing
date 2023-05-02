using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirment5
{
    public class InvalidEmailException:Exception
    {
        private string email;

        public InvalidEmailException() { }

        public InvalidEmailException(string email)

        {

            this.email = email;

        }

        public void inform()

        {

            Console.WriteLine("invalid mailid");

        }
    }
}
