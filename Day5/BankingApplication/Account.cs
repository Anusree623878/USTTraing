using System;
using System.Net.NetworkInformation;

namespace BankingApplication
{
    public class Account
    {
        int accno;
        string name;
        decimal amount;

        public void accountOpening(int accno, string name, decimal amount)
        {
            this.accno = accno;
            this.name = name;
            this.amount = amount;

            Console.WriteLine("Account Open Successfully");
            
        }
        public void displayInfo()
        {
            
            Console.WriteLine("Name is : {0}", name);
            Console.WriteLine("Account Number is: {0}", accno);
            Console.WriteLine("Initial Amount is :{0}", amount);
            Console.WriteLine();
            
        }
        public void balance(decimal amt) 
        {
            amount += amt;
            Console.WriteLine(" Current Balance :" + amount);
            Console.WriteLine();
         }
        public void withdraw(decimal wamt) 
        { 
            if(amount-wamt< 500)
            {
                //Console.WriteLine("Insuffient Balance");
                throw new ApplicationException("Insufficient Balance");
                //Console.WriteLine();
            }
            else
            {
                amount = amount - wamt;
                Console.WriteLine("After withdrow Current amount:{0}", amount);
                Console.WriteLine();
            }
        }
    }
}