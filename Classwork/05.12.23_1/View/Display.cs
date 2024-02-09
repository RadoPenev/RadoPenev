using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._12._23_1
{
    internal class Display
    {
        public int N { get; set; }
        public string[] info;
        public double HearhStone { get; set; }
        public double Fortnite { get; set; }
        public double Overwatch { get; set; }
        public double Others { get; set; }

        public Display()
        {
            GetValues();
        }
        public void GetValues()
        {
            N = int.Parse(Console.ReadLine());
            info = new string[N];
            for (int i = 0; i < info.Length; i++) { info[i] = Console.ReadLine(); }
        }
        public void Print()
        {
            Console.WriteLine($"Hearthstone: {HearhStone:f2}%");
            Console.WriteLine($"Fortnite: {Fortnite:f2}%");
            Console.WriteLine($"Overwatch: {Overwatch:f2}%");
            Console.WriteLine($"Others: {Others:f2}%");

        }
    }
}