using System;
using System.Collections.Generic;
using System.Linq;
namespace English_Bulgarian_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split('-');
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            while (word[0]!="Stop")
            {
                if (dictionary.ContainsKey(word[0]))
                {
                    Console.WriteLine("The word is already in the dictionary");
                }
                else
                {
                    dictionary.Add(word[0], word[1]);
                }
                word = Console.ReadLine().Split('-');
            }
            foreach (KeyValuePair<string,string>item in dictionary)
            {
                Console.WriteLine($"ENG {item.Key} - BG {item.Value}");
            }
        }
    }
}
