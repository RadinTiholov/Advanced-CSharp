using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Predicate<int> filter = (number) => number % n != 0;
            Console.WriteLine(string.Join(" ", arr.Reverse().Where(x => filter(x))));
        }
    }
}
