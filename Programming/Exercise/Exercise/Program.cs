using System;
using System.Collections.Generic;
namespace Exercise
{
    class Program
    {
        private static Dictionary<string, string> info;

        static void Main(string[] args)
        {
            info = getData();

            Console.WriteLine(getDoctor("Ivan Ivanov")) ;

            List<string> students = getStudents("Petrov");

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

        }

        static Dictionary<string, string> getData()
        {
            Dictionary<string, string> info = new Dictionary<string, string>();

            string[] row = Console.ReadLine().Split('-');
            while (row[0] != "END")
            {
                if (info.ContainsKey(row[0]))
                {
                    info[row[0]] = row[1];
                }
                else
                {
                    info.Add(row[0].Trim(), row[1].Trim());
                }

                row = Console.ReadLine().Split('-');
            }

            return info;
        }

        static string getDoctor(string student)
        {
            return info[student];
        }

        static List<string> getStudents(string doctor)
        {
            List<string> keys = new List<string>();

            foreach (var item in info)
            {
                if (item.Value.Equals(doctor))
                {
                    keys.Add(item.Key);
                }
            }

            return keys;
        }
    }
}
