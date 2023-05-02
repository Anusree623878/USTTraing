using System;


namespace Bank
{
    public class Class1
    {
        static void Main(string[] args)
        {

            customer c = new customer("Rahul", 2453, 5000);

            try

            {

                c.withdraw(300);

            }

            catch (bankexception e)

            {

                Console.WriteLine("Transaction Failed ");

                e.inform();

            }

        }

    }
}
   
