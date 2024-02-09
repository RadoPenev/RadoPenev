using System;

namespace Lesons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            double v=double.Parse(Console.ReadLine());
            if (n>5)
            {
                Console.WriteLine("da");
                if (v>0)
                {
                    Console.WriteLine("miur");
                }
                else
                {
                    Console.WriteLine("2 lea");
                }
            }
            else
            {
                Console.WriteLine("ne");
            }
        }
    }
}
