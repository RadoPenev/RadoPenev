using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._11._23
{
    class Display
    {
        public double Ammount { get; set; }
        public double Percent { get; set; }
        public double Tipp { get; set; }
        public double Total { get; set; }

        public Display()
        {
            GetValues();
        } 

        public void GetValues()
        {
            Console.WriteLine("Please enter the ammount");
            Ammount = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the percent tip");
            Percent = double.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"The tip is: {Tipp}");
            Console.WriteLine($"The total ammount is: {Total}");
        }
    }
       
}
