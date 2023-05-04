using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinqMethod
{
    public class Student
    {
        private int _studentId;
        private string _studentName;
        private int _age;

        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }
        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }
        public int Age { 
            get { return _age; }
            set { _age = value; }
        }

        public Student() { }

        public Student(int studentId, string studentName, int age)
        {
            StudentId = studentId;
            StudentName = studentName;
            Age = age;
           
        }
    }
}
