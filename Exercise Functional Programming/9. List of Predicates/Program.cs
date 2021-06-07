using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._List_of_Predicates
{
    class Program
    {
        public static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<int> deviders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToList();

            List<int> numbers = new List<int>();
            for (int i = 1; i <= length; i++)
            {
                if (IsDivisible(i, deviders))
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool IsDivisible(int n, List<int> deviders)
        {
            bool isTrue = true;
            foreach (int divaider in deviders)
            {
                if (n % divaider != 0)
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
    }
}
