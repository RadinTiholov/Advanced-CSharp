using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, int> family = new SortedDictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person personToAdd = new Person(input[0], int.Parse(input[1]));
                if (personToAdd.Age > 30)
                {
                    family.Add(personToAdd.Name, personToAdd.Age);
                }
            }
            foreach (var item in family)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            
            
        }
    }
}
