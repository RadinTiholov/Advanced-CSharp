using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                List<string> clothes = input[1].Split(',').ToList();
                if (!dict.ContainsKey(color))
                {
                    dict[color] = new Dictionary<string, int>();
                }
                foreach (var item in clothes)
                {
                    if (dict[color].ContainsKey(item))
                    {
                        dict[color][item]++;
                    }
                    else
                    {
                        dict[color].Add(item, 1);
                    }
                }
            }
            var toBeFound = Console.ReadLine().Split(" ");
            string colorToBeFound = toBeFound[0];
            string dressTobefound = toBeFound[1];
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloth in item.Value)
                {
                    if (item.Key == colorToBeFound && cloth.Key == dressTobefound)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }

        }
    }
}
