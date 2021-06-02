using System;
using System.Linq;

namespace Functional_Programming___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).Where(x => x % 2 == 0).OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
