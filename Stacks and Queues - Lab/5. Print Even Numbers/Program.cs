using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .ToArray();
            Queue<int> queue = new Queue<int>(input);

            Console.WriteLine(string.Join(", ", input));

        }
    }
}
