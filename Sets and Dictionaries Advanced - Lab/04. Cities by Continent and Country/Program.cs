using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
               var splitted = Console.ReadLine().Split();
               string continent = splitted[0];
               string states = splitted[1];
               string city = splitted[2];
               if (!dict.ContainsKey(continent))
               {
                   dict[continent] = new Dictionary<string, List<string>>();
               }
               if (!dict[continent].ContainsKey(states))
               {
                   dict[continent].Add(states, new List<string>());
               }
               
            }
            
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"  {item2.Key} -> {string.Join(", ", item2.Value)}");
                }
            }
        }
    }
}
