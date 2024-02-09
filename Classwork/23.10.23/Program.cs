using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _23._10._23
{
    class Program
    {
        static Random k = new Random();
        static void CountBack()
        {
           
            
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(k.Next(1,11)*1000);
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(CountBack);
            Thread thread1 = new Thread(CountBack);
            thread.Start();
            thread1.Start();
        }
    }
}
