using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelePhoneInheritanceprgm
{
    public class TelePhone
    {
        protected string phonetype;
        public string Phonetype
        {
           get { return phonetype; }
            set { phonetype = value; }
        }

        public TelePhone() { }
        public TelePhone(string phoneType)
        {
            this.phonetype = phoneType;
        }
        public void Ring()
        {

            Console.WriteLine(" Rings the  " + phonetype);
        }
    }
    public class ElectronicPhone:TelePhone
    {
        
        public ElectronicPhone() {
           
        }
        public ElectronicPhone(string phoneType):base(phoneType)
        {
            phonetype = phoneType;
        }
       
        public void Run()
        {
            Ring();
        }
    }


     public  class Program
    {
        static void Main(string[] args)
        {
            ElectronicPhone ep=new ElectronicPhone( "Digital");
            ep.Run();
        }
    }
}
