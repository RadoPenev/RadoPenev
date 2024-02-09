using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._11._23_1
{
    class Display
    {
        public double PricePerVeg { get; set; }
        public double PricePerFruit { get; set; }
        public int KillogramVeg { get; set; }
        public int KillogramFruit { get; set; }
        public double Cost { get; set; }

        public void GetValues()
        {
            Console.WriteLine("Write the price per killogram for the vegetables");
            PricePerVeg = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the price per killogram for the fruits");
            PricePerFruit= double.Parse(Console.ReadLine());
            Console.WriteLine("Write how much vegetables you want");
            KillogramVeg = int.Parse(Console.ReadLine());
            Console.WriteLine("Write how much fruits you want");
            KillogramFruit = int.Parse(Console.ReadLine());
        }

        public Display()
        {
            GetValues();
        }

        public void Print()
        {
            Console.WriteLine($"The price is {Cost}");
        }
    }
}
