using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._12._23
{
    internal class Display
    {
        public int N { get; set; }
        public double[] Input { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }

        public Display() { GetValues(); }
        public void GetValues()
        {
            Console.WriteLine("Times");
            N = int.Parse(Console.ReadLine());
            Input = new double[N];
            Console.WriteLine("Write the numbers");
            for (int i = 0; i < Input.Length; i++)
            {
                Input[i]=double.Parse(Console.ReadLine());
            }
        }

        public void Print()
        {
            Console.WriteLine($"By 2: {P1:f2}");
            Console.WriteLine($"By 3: {P2:f2}");
            Console.WriteLine($"By 4: {P3:f2}");
        }
    }
}
