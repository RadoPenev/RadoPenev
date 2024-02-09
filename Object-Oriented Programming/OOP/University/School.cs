using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class School
    {
        private string name;
        private List<Student> students;

        public School(string name)
        {
            Name = name;
            Students = new List<Student>();
        }



        public string Name{ get;set; }



        public List<Student> Students
        {get;set;
        }



        public void AddStudent(string name, double grade)
        {
            Student student = new Student(name,grade);
            Students.Add(student);

        }



        public double AverageResultInRange(int start, int end)
        {
            double avg = 0;
            int count = end - start + 1 ;
            for (int i = start; i <= end; i++)
            {
                avg += Students[i].Grade;
            }
            return avg / count;
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
            return Students.OrderBy(s=>s.Name).ToList();
        }



        public List<Student> SortDescendingByGrade()
        {
            return Students.OrderByDescending(x=> x.Grade).ToList();
        }



        public bool CheckStudentIsInSchool(string name)
        {
            bool isIn = false;
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
            string[] info = new string[Students.Count];

            for (int i = 0; i < info.Length; i++)
            {
                info[i] = Students[i].Name;
            }


            return info;
        }
    }
}
