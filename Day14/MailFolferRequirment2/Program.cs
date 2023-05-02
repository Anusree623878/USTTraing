using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolferRequirment2
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            List<Mail> ls = new List<Mail>();
            Console.WriteLine("Enter the name of the folder:");
            string name = Console.ReadLine();

            
            MailFolder mf = new MailFolder(name, ls);
            Mail m = new Mail();
            bool the = true;

            while (the)
            {
                Console.WriteLine("1.Add mail \n 2.Delete mail \n 3.Display mail \n 4.Exit");
                Console.WriteLine("Enter your choice:");
                int ans = int.Parse(Console.ReadLine());

                switch (ans)
                {
                    case 1:
                        Console.WriteLine("Enter the details of the mail in CVS format:");
                        string s = Console.ReadLine();
                        m = Mail.CreateMail(s);
                        mf.AddMailToFolder(m);
                        Console.WriteLine("Mail successfully added");
                        break;
                    case 2:
                        Console.WriteLine("Enter the id of the mail to be deleted");
                        long id = long.Parse(Console.ReadLine());
                        if (mf.RemoveMailFromFolder(id))
                        {
                            Console.WriteLine(" Mail successfully deleted");
                        }
                        else
                        {
                            Console.WriteLine("Mail not found in the folder");
                        }
                        break;
                    case 3:
                        mf.DisplayMails();

                        break;
                    case 4:
                       
                        break;
                    default:
                        Console.WriteLine("Wrong choice!!!!");
                        break;




                }
            }

        }

    }
}
