using System;
using System.Collections.Generic;

namespace UniversitySpecialties
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> universitySpecialties = new Dictionary<string, List<string>>();

            while (true)
            {
                Console.Write("Enter university specialty or type 'exit' to finish: ");
                string specialty = Console.ReadLine();

                if (specialty.ToLower() == "exit")
                {
                    break;
                }

                Console.Write("Enter student's faculty number: ");
                string facultyNumber = Console.ReadLine();

                Console.Write("Enter student's grade point average: ");
                double grade = double.Parse(Console.ReadLine());

                if (!universitySpecialties.ContainsKey(specialty))
                {
                    universitySpecialties[specialty] = new List<string>() { $"{facultyNumber}, {grade}" };
                }
                else
                {
                    universitySpecialties[specialty].Add($"{facultyNumber}, {grade}");
                }
            }

            foreach (KeyValuePair<string, List<string>> specialty in universitySpecialties)
            {
                Console.Write($"{specialty.Key}: ");
                Console.WriteLine(string.Join("; ", specialty.Value));
            }
        }
    }
}
