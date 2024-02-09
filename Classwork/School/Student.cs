using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        private string name;
        private double grade;
        public string Name { get { return name; } set { name = value; } }
        public double Grade { get { return grade; } set { grade = value; } }

        public Student(string _name, double _grade)
        {
            Name = _name;
            Grade = _grade;
        }

        public override string ToString()
        {
            return $"Sudent:{Name} has {Grade}.";
        }

    }
}
