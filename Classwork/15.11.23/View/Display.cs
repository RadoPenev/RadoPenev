using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._11._23
{
    class Display
    {
        public int Killometers { get; set; }
        public string Time { get; set; }
        public double Cost { get; set; }
        public Display()
        {
            GetValues();
        }

        public void GetValues()
        {
            Console.WriteLine("Please enter the killometers you want to travel");
            Killometers = int.Parse(Console.ReadLine());
            Console.WriteLine("Day/Night");
            Time = Console.ReadLine();
            
        }

        public void Print()
        {
            
            Console.WriteLine($"Cheapest: {Cost}");
        }
    }
}
