using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Student
    {
        private string name;
        private double grade;
   
        public Student(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        public string Name
        {
            get;set;
        }

        public double Grade
        {
            get;set;
        }



        public override string ToString()
        {
            return $"Student {Name} has {Grade}";
        }
    }
}
