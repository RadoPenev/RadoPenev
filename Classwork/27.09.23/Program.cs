   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._09._23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> info = new List<Student>();
            string[] input = Console.ReadLine().Split(' ');
            while (input[0]!="end")
            {
                Student student = new Student(input[0],double.Parse(input[1]));
                info.Add(student);
                input = Console.ReadLine().Split(' ');
            }
            Console.WriteLine("ToSting");
            foreach (var item in info)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Info");
            foreach (var item in info)
            {
                Console.WriteLine(item.Info());
            }
        }
    }
}
