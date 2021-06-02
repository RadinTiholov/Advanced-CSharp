using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Filter_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<(string name, int age), int, bool> younger = (person, age) => person.age < age;
            Func<(string name, int age), int, bool> older = (person, age) => person.age >= age;
            int n = int.Parse(Console.ReadLine());
            List<(string name, int age)> list = new List<(string name, int age)>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                list.Add((input[0], int.Parse(input[1])));
            }
            string setting = Console.ReadLine();
            int condition = int.Parse(Console.ReadLine());
            string[] printFormat = Console.ReadLine().Split(" ");
            if (setting == "older")
            {
                list = list.Where(x => older(x, condition)).ToList();
            }
            else
            {
                list = list.Where(x => younger(x, condition)).ToList();
            }
            foreach (var person in list)
            {
                List<string> output = new List<string>();
                if (printFormat.Contains("name"))
                {
                    output.Add(person.name);
                }
                if (printFormat.Contains("age"))
                {
                    output.Add(person.age.ToString());
                }

                Console.WriteLine(string.Join(" - ", output));
            }


        }
    }
}
