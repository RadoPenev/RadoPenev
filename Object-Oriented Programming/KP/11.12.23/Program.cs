using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11._12._23
{
    internal class Program
    {
        public static void Calculating(int x, int y)
        {
            int br = 1;
            int broiProstiChisla = 0;
            for (int i = x; i <= y; i++) 
            {
                for (int j = 2; j < y/2; j++)
                {
                    if (i%j==0)
                    {
                        br++;
                    }
                }
                if (br<2)
                {
                    broiProstiChisla++;
                    Console.WriteLine(i);

                }
            }
            Console.WriteLine(broiProstiChisla);

        }

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
           // int x1 = int.Parse(Console.ReadLine());
           // int y1 = int.Parse(Console.ReadLine());

            Thread thread = new Thread(() => Calculating(x, y));
            Thread thread1 = new Thread(() => Calculating(x, y));
            thread.Start();
            thread1.Start();
        }
    }
}
