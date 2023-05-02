using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolderRequirment
{

    
    public class Program
    {
        static void Main(string[] args)
        {
            List<Mail> li= new List<Mail>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter the {0} mail details",i+1);
                string[] mail = Console.ReadLine().Split(',');
                DateTime dt = Convert.ToDateTime(mail[5]);
                Mail m1 = new Mail(long.Parse(mail[0]), mail[1], mail[2], mail[3], mail[4], dt, double.Parse(mail[6]));
                li.Add(m1);
                li.ToString();


            }

           

            if (li[0].Equals(li[1]))
            {
                Console.WriteLine("Mails are same");
            }

            else
            {
                Console.WriteLine("The Mails are different");
            }
           
          
        }
    }
}
