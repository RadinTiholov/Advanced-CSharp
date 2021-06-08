using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();
            while(input != "Party!")
            {
                var splitted = input.Split();
                if (input.Contains("Remove StartsWith"))
                {
                    names = names.Where(x => !x.StartsWith(splitted[2])).ToList();
                }
                else if(input.Contains("Remove Length"))
                {
                    names = names.Where(x => x.Length != int.Parse(splitted[2])).ToList();
                }
                else if (input.Contains("Remove EndsWith"))
                {
                    names = names.Where(x => !x.EndsWith(splitted[2])).ToList();
                }
                else if (input.Contains("Double EndsWith"))
                {
                    string[] help = names.Where(x => x.EndsWith(splitted[2])).ToArray();
                    foreach (var item in help)
                    {
                        names.Add(item);
                    }
                }
                else if (input.Contains("Double Length"))
                {
                    string[] help = names.Where(x => x.Length == int.Parse(splitted[2])).ToArray();
                    foreach (var item in help)
                    {
                        names.Add(item);
                    }
                }
                else if (input.Contains("Double StartsWith"))
                {
                    string[] help = names.Where(x => x.StartsWith(splitted[2])).ToArray();
                    foreach (var item in help)
                    {
                        names.Add(item);
                    }
                }
                input = Console.ReadLine();
            }
            names.Sort();
            if (names.Any())
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
                return;
            }
            Console.WriteLine("Nobody is going to the party!");
        }
    }
}
