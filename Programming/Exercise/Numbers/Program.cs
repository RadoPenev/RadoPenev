using System;
using System.Collections.Generic;
namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> info = new SortedDictionary<int, int>();
            int n = int.Parse(Console.ReadLine());
            while (n!=0)
            {
                if (!info.ContainsKey(n))
                {
                    info.Add(n,1);
                }
                else
                {
                    info[n]++;
                }
                n = int.Parse(Console.ReadLine());
            }
            foreach (KeyValuePair<int,int> item in info)
            {
                Console.WriteLine(item);
            }
        }
    }
}
