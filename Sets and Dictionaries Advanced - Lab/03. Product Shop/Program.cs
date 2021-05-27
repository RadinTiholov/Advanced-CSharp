using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, string>> dict = new SortedDictionary<string, Dictionary<string, string>>();
            string input = Console.ReadLine();
            while (input != "Revision")
            {
                var splitted = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string store = splitted[0];
                string product = splitted[1];
                double price = double.Parse(splitted[2]);
                if (!dict.ContainsKey(store))
                {
                    dict[store] = new Dictionary<string, string>();
                }
                dict[store].Add(product, price);

                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var pro in item.Value)
                {
                    Console.WriteLine($"Product: {pro.Key}, Price: {pro.Value}");
                }
            }
        }
    }
}
