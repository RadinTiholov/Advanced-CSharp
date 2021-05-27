using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_and_Dictionaries_Advanced___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> dict = new Dictionary<double, int>();
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]))
                {
                    dict[input[i]]++;
                }
                else
                {
                    dict.Add(input[i], 1);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
