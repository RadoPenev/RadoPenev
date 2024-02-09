using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Write down only positive numbers (to end write down 0):");

        while (true)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
                break;

            numbers.Add(number);
        }

        Console.WriteLine("All of the written numbers written for once:");
        numbers.Distinct().ToList().ForEach(number => Console.WriteLine(number));

        Console.WriteLine();

        Console.WriteLine("Numbers devideable by 5:");
        List<int> multiplesOfFive = numbers.Where(number => number % 5 == 0).ToList();
        multiplesOfFive.ForEach(number => Console.WriteLine(number));
        Console.WriteLine("The count of the numbers: " + multiplesOfFive.Count);

        Console.WriteLine();

        Console.WriteLine("The square of all numbers (sorted by descending):");
        List<int> squares = numbers.Select(number => number * number).OrderByDescending(number => number).ToList();
        squares.ForEach(number => Console.WriteLine(number));
    }
}
