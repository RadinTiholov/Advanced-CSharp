using System;
using System.Linq;
using System.Collections.Generic;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ingredientsInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] freshnessInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> ingredients = new Queue<int>(ingredientsInput);
            Stack<int> freshness = new Stack<int>(freshnessInput);
            Dictionary<string, int> dict = new Dictionary<string, int>();

            int count = 0;
            while (ingredients.Any() && freshness.Any())
            {
                if (ingredients.Peek() == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }
                int freshnessLevel = ingredients.Peek() * freshness.Peek();
                if (freshnessLevel == 150 || freshnessLevel == 250 || freshnessLevel == 300 || freshnessLevel == 400)
                {
                    ingredients.Dequeue();
                    freshness.Pop();
                    count++;
                    if (freshnessLevel == 150)
                    {
                        if (dict.ContainsKey("Dipping sauce"))
                        {
                            dict["Dipping sauce"]++;
                        }
                        else
                        {
                            dict.Add("Dipping sauce", 1);
                        }
                    }
                    else if (freshnessLevel == 250)
                    {
                        if (dict.ContainsKey("Green salad"))
                        {
                            dict["Green salad"]++;
                        }
                        else
                        {
                            dict.Add("Green salad", 1);
                        }
                    }
                    else if (freshnessLevel == 300)
                    {
                        if (dict.ContainsKey("Chocolate cake"))
                        {
                            dict["Chocolate cake"]++;
                        }
                        else
                        {
                            dict.Add("Chocolate cake", 1);
                        }
                    }
                    else if (freshnessLevel == 400)
                    {
                        if (dict.ContainsKey("Lobster"))
                        {
                            dict["Lobster"]++;
                        }
                        else
                        {
                            dict.Add("Lobster", 1);
                        }
                    }
                }
                else
                {
                    freshness.Pop();
                    ingredients.Enqueue(ingredients.Dequeue() + 5);
                }
            }
            if (count >= 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }
            //
            if (ingredients.Any())
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }
            //
            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($" # {item.Key} --> {item.Value}");
            }
        }
    }
}
