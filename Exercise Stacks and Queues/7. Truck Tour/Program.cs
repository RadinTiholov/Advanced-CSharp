using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int amount = input[0];
                int distance = input[1];

            }
        }
    }
}
