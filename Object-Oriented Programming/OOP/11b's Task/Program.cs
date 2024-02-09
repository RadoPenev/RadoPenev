using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11b_s_Task
{
    internal class Program
    {
        public class ComparingByAvgSuccess : IComparer<Student>
        {
            int IComparer<Student>.Compare(Student x, Student y)
            {
                if (x.AvgSuccess==y.AvgSuccess)
                {
                    return x.Name.CompareTo(y.Name);
                }
                return x.AvgSuccess.CompareTo(y.AvgSuccess);
            }
        }

        public class ComparingByTypeOfEducation : IComparer<Student>
        {
            int IComparer<Student>.Compare(Student x, Student y)
            {
                return x.TypeOfEducation.CompareTo(y.TypeOfEducation);
            }
        }

        public class Student:IEnumerable<Student>
        {
            List<Student> students=new List<Student>();

            public Student(string name, double avgSuccess, string typeOfEducation)
            {
                Name = name;
                AvgSuccess = avgSuccess;
                TypeOfEducation = typeOfEducation;
            }

            public Student()
            {

            }

            public string Name { get; set; }
            public double AvgSuccess { get; set; }
            public string TypeOfEducation { get; set; }

            public void Add(Student student)
            {
                students.Add(student);
            }

            public void Remove(Student student)
            {
                if (students.Contains(student))
                {
                    students.Remove(student);
                }
                else
                {
                    throw new ArgumentException("There is no such a student");
                }
            }
            public IEnumerator GetEnumerator()
            {
                students.Sort(new ComparingByAvgSuccess());
                students.Sort(new ComparingByTypeOfEducation());
                return students.GetEnumerator();
            }
            IEnumerator<Student> IEnumerable<Student>.GetEnumerator()
            {
                students.Sort(new ComparingByAvgSuccess());
                students.Sort(new ComparingByTypeOfEducation());
                return students.GetEnumerator();
            }

          
            public override string ToString()
            {
                return $"{Name} {AvgSuccess} {TypeOfEducation}";
            }
        }

        static void Main(string[] args)
        {
            Student student=new Student();
            string[] input = Console.ReadLine().Split(' ');
            try
            {
                while (input[0].ToLower() != "end")
                {
                    if (input[0].ToLower() == "add")
                    {
                        Student student1 = new Student(input[1], Convert.ToDouble(input[2]), input[3]);
                        student.Add(student1);
                    }
                    if (input[0].ToLower() == "remove")
                    {
                        Student student1 = new Student(input[1], Convert.ToDouble(input[2]), input[3]);
                        student.Remove(student1);
                    }
                    if (input[0].ToLower() == "print")
                    {
                        foreach (var item in student)
                        {
                            Console.WriteLine(item);
                        }
                    }

                    input = Console.ReadLine().Split(' ');
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
           

        }
    }
}
