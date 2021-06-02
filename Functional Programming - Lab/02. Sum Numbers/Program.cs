using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine(input.Length);
            Console.WriteLine(input.Sum());
        }
    }
}
