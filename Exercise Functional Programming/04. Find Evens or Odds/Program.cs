using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var querry = Console.ReadLine();

            Predicate<int> predicate = querry == "odd"
                ? n => n % 2 != 0
                : new Predicate<int>((n) => n % 2 == 0);
            var result = new List<int>();
            for (int i = arr[0]; i <= arr[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));

        }

        
    }
}
