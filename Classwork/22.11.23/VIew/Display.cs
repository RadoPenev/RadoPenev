using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11._23
{
    class Display
    {
        public List<double> Info = new List<double>();
        public double Volume { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double H { get; set; }
        public Display()
        {
            GetValues();
        }
        public void GetValues()
        {
            Console.WriteLine("Volume = ");
            Volume = double.Parse(Console.ReadLine());
            Console.WriteLine("P1 = ");
            P1 = double.Parse(Console.ReadLine());
            Console.WriteLine("P2 = ");
            P2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Hours = ");
            H = double.Parse(Console.ReadLine());
        }
        public void Print()
        {
            if (P1 + P2 < Volume)
            {
                Info.Add(P1 + P2);
                Info.Add(P1);
                Info.Add(P2);
                Console.WriteLine($"The pool is {Info[0]}% full. Pipe 1: {Info[1]:f0}%. Pipe 2: {Info[2]:f0}%");
            }
            else
            {
                Info.Add(H);
                Info.Add((P1 + P2) - Volume);
                Console.WriteLine($"For {Info[0]} hours the pool overflows with {Info[1]} liters.");
            }
        }
    }
}
