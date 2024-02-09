using System;
using System.Collections.Generic;
namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split(' ');
            Dictionary<string, string> menu = new Dictionary<string, string>();
            Console.WriteLine("Press 1 for: Writing a contact");
            Console.WriteLine("Press 2 for: Redaction");
            Console.WriteLine("Press 3 for: Searching");
            Console.WriteLine("Press 4 for: All");
            Console.WriteLine("Press 5 for: Exit");
            while (Convert.ToInt32(info[0])!=5)
            {
                int command = Convert.ToInt32(info[0]);
                if (command==1)
                {
                    if (!menu.ContainsKey(info[0]))
                    {
                        menu.Add(info[0],info[1]);
                    }
                    else
                    {
                        Console.WriteLine("This name exist");
                        Console.WriteLine("Change it");
                        menu[info[0]] = info[0];
                    }
                }
            }
        }
    }
}
