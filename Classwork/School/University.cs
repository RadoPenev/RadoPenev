using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class University
    {
        private string name;
        private List<Student> students;
        public University(string name1)
        {
            Name = name1;
            Students = new List<Student>();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }



        public List<Student> Students { get; set; }



        public void AddStudent(string name, double grade)
        {
            Student student = new Student(name,grade);
            students.Add(student);
        }



        public double AverageResultInRange(int start, int end)
        {
            int br = 0;
            double avg = 0;
            for (int i = start; i <= end; i++)
            {
                avg = Students[i].Grade + avg;
                br++;
            }
            return avg / br;
        }





        public List<string> RemoveStudentsByGrade(double grade)
        {
            List<string> founded = new List<string>();
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Grade<grade)
                {
                    founded.Add(Students[i].Name);
                    Students.RemoveAt(i);
                }
            }

            return founded;
        }



        public List<Student> SortAscendingByName()
        {
            Students.OrderBy(s=>s.Name).ToList();
            return Students;
        }



        public List<Student> SortDescendingByGrade()
        {
            Students.OrderByDescending(s => s.Grade).ToList();
            return Students;
        }



        public bool CheckStudentIsInSchool(string name)
        {
            bool isIn= false;
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Name==name)
                {
                    isIn = true;
                }
            }

            return isIn;
        }



        public string[] ProvideInformationAboutAllStudents()
        {
            string[] info=new string[Students.Count];
            for (int i = 0; i < Students.Count; i++)
            {
                info[i] = Students[i].ToString();
            }
            return info;
        }
    }
}
