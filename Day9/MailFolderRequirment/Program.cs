using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolderRequirment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "1002,gcsducgdc,ydcgduycjd,789";
            string[] entries= input.Split(',');
            int id = int.Parse(entries[0]);
            Console.WriteLine(entries[0]);
          
        }
    }
}
