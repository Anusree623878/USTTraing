using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSTN4_CC
{
    class Student { }
    class Rockstar { }
    class Hacker { }
    public class CSharpInstanceOf
    {
        static string Count(ArrayList mylist)
        {
            int a = 0, b = 0, c = 0;
            for (int i = 0; i < mylist.Count; i++)
            {
                object element = mylist[i];
                if (element is Student)
                    a++;
                if (element is Rockstar)
                    b++;
                if (element is Hacker)
                    c++;
            }
            string ret = $"{a} {b} {c}";
            return ret;
        }
        public static void Main(string[] args)
        {
            ArrayList mylist = new ArrayList();
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();
                if (s.Equals("Student")) mylist.Add(new Student());
                if (s.Equals("Rockstar")) mylist.Add(new Rockstar());
                if (s.Equals("Hacker")) mylist.Add(new Hacker());
            }
            Console.WriteLine(Count(mylist));
        }
    }
}
