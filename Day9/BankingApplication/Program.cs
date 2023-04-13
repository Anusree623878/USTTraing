using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a = null;
            int ch;

            do
            {
                ch = 0;
                Console.WriteLine("**** Banking Application ****");

                Console.WriteLine("Enter your Choice:");
                Console.WriteLine();
                Console.WriteLine("1.Account Opening");
                Console.WriteLine("2.Account Information");
                Console.WriteLine("3.Deposit an Amount");
                Console.WriteLine("4.Withdrow an Amount");
                Console.WriteLine("5.Check Balance");
                Console.WriteLine("0.Exit");
                Console.WriteLine();
                ch = int.Parse(Console.ReadLine());


                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the account number");
                        int accno = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the opening amount:");
                        decimal amount = decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.accountOpening(accno, name, amount);
                        break;

                    case 2:
                        if (a != null)
                        {
                            Console.WriteLine("User infromation");
                            a.displayInfo();

                        }
                        else
                        {
                            Console.WriteLine("Open An Account First!!!");
                            Console.WriteLine();

                        }
                        break;
                    case 3:
                        if (a != null)
                        {
                            Console.WriteLine("Enter the amount");
                            decimal amt = decimal.Parse(Console.ReadLine());
                            a.balance(amt);
                        }
                        else
                        {
                            Console.WriteLine("Open an Account First!!!");
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        if (a != null)
                        {

                            Console.WriteLine("Enter the amount to withdraw:");
                            decimal wamt = decimal.Parse(Console.ReadLine());
                            a.withdraw(wamt);
                        }
                        else
                        {
                            Console.WriteLine("Open an account First!!!");
                            Console.WriteLine();
                        }
                        break;
                        case 5:
                            if(a != null)
                        {
                            Console.WriteLine(a.Amount);
                        }
                        else
                        {
                            Console.WriteLine("*** Open An Account First!!!!!");
                        }
                            break;

                    case 0:
                        a = null;
                        break;
                    default:
                        Console.WriteLine("***Wrong choice***");
                        break;



                }
            }
            while (ch != 0);
            {
                Console.WriteLine("Thank you for using banking Application");
            }

        }
    }
}
