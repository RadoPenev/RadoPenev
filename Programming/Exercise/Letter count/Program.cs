using System;
using System.Collections.Generic;

namespace LetterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            SortedDictionary<char, int> letterCounts = new SortedDictionary<char, int>();

            foreach (char letter in word)
            {
                if (letterCounts.ContainsKey(letter))
                {
                    letterCounts[letter]++;
                }
                else
                {
                    letterCounts.Add(letter, 1);
                }
            }

            foreach (char letter in letterCounts.Keys)
            {
                Console.WriteLine($"Letter '{letter}' appears {letterCounts[letter]} time(s) in the word.");
            }
        }
    }
}
