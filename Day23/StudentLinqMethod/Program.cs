using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinqMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> lstudent = new List<Student>();
            lstudent.Add(new Student(101, "kavya", 23));
            lstudent.Add(new Student(102, "kiran", 24));
            lstudent.Add(new Student(103, "hiya", 20));

            
            var teenage = lstudent.Where(s => s.Age >= 20 && s.Age < 24).ToList<Student>();

            foreach (var s in teenage)
            {
                Console.WriteLine(s.StudentName);
            }

        }

    }
}
