using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirment5
{
    public class Member
    {
        
        string fname;
        string lname;
        string email;
       



       
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }
        

        public Member() { }

        public Member( string fname, string lname, string email)
        {
          
            Fname = fname;
            Lname = lname;
            Email = email;
            
           
        }

        public override string ToString()

        {

            return string.Format($"Member:{fname},{lname}{email}");

        }

        public void checking(string email)

        {

            if (email.Contains("@") && (email.EndsWith(".com"))||(email.EndsWith(".org")))

            {

                Console.WriteLine("valid mail");

            }

            else

            {

                throw new InvalidEmailException(email);

            }

        }
    }
}
