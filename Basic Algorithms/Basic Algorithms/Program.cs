using System;
using System.Linq;

namespace Basic_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = Recursion(arr, 0);
            Console.WriteLine(sum);

        }

        private static int Recursion(int[] arr, int index)
        {
            if (index == arr.Length -1)
            {
                return arr[index];
            }
            return arr[index] + Recursion(arr, index + 1);
        }
    }
}
