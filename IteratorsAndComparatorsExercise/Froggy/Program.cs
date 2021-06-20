using System;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Lake lake = new Lake(input);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
