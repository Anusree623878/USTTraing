using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MailFolferRequirment2
{
    public class MailFolder
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }



        private List<Mail> _mailList;

        public List<Mail> MailList
        {
            get { return _mailList; }
            set { _mailList = value; }
        }

        public MailFolder() { }

        public MailFolder(string _name, List<Mail> _mailList)
        {
            Name = _name;
            MailList = _mailList;
        }

        public void AddMailToFolder(Mail mail)
        {
            MailList.Add(mail);


        }
        public bool RemoveMailFromFolder(long id)
        {

            int count = 0;
            foreach (var item in MailList)
            {
                if (item.Id == id)
                {
                    MailList.Remove(item);
                    count = 1;
                    break;
                }
            }
            if (count == 1)
            {
                return true;

            }
            else
            {
                return false;
            }


        }

        public void DisplayMails()
        {
            if (MailList.Count != 0)
            {
                foreach (var item in MailList)
                {
                    
                    Console.WriteLine(item.ToString());
                }

            }
            else
            {
                Console.WriteLine("No Mails to show");
            }

        }
    }
}
