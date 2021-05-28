using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
            string text = Console.ReadLine();
            foreach (char letter in text)
            {
                if (dict.ContainsKey(letter))
                {
                    dict[letter]++;
                }
                else
                {
                    dict.Add(letter, 1);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
