using System;

namespace _04_12_23_
{
    class Program
    {
         class Car
        {
           string color;


            static void Main(string[] args)
            {
                Car car = new Car();
                car.color = "red";
                Console.WriteLine( car.color);
            }
        }
    }
}