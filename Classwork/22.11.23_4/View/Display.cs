using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11._23_4
{
    class Display
    {
        public double Budget { get; set; }
        public string Season { get; set; }
        public string PrintEvrt { get; set; }

        public void GetValues()
        {
            Console.WriteLine("Budget:");
            Budget = double.Parse(Console.ReadLine());
            Console.WriteLine("Season between summer and winter");
            Season = Console.ReadLine();
        }

        public Display()
        {
            GetValues();
        }

        public void Print()
        {
            Console.WriteLine(PrintEvrt);
        }
    }
}
