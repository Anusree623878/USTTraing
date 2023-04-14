using System;
using System.Net.NetworkInformation;

namespace BankingApplication 
{
    public class Account
    {
        int accno;
        private string _name;
        public string Name
        {
            get { 
                return _name; 
            }
            set
            {
                if (value.Length < 5)
                {
                    throw new ApplicationException("Name is tooo big U Should Have to change");
                   
                }
                else
                {
                   _name = value;

                }

            }
        }
       
        private decimal _amount;
        public decimal Amount
        {
            get
            {
                return _amount; 
            }
        }

        public void accountOpening(int accno, string name, decimal amount)
        {
                 this.accno = accno;
                _name = name;
                _amount = amount;

            Console.WriteLine("Account Open Successfully");
            
        }
        public void displayInfo()
        {
            
            Console.WriteLine("Name is : {0}", _name);
            Console.WriteLine("Account Number is: {0}", accno);
            Console.WriteLine("Initial Amount is :{0}", _amount);
            Console.WriteLine();
            
        }
        public void balance(decimal amt) 
        {
            _amount += amt;
            Console.WriteLine(" Current Balance :" + _amount);
            Console.WriteLine();
         }
        public void withdraw(decimal wamt) 
        { 
            if(_amount-wamt< 500)
            {
                //Console.WriteLine("Insuffient Balance");
                throw new ApplicationException("Insufficient Balance");
                //Console.WriteLine();
            }
            else
            {
                _amount = _amount - wamt;
                Console.WriteLine("After withdrow Current amount:{0}", _amount);
                Console.WriteLine();
            }
        }
    }
}