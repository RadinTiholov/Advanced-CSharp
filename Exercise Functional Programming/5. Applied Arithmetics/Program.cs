using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            while (input != "end")
            {
                arr = input == "add" ? AddOne(arr)
                    : input == "multiply" ? Multiply(arr)
                    : input == "print" ? Print(arr) : Subtract(arr);
                input = Console.ReadLine();
            }
        }

        private static int[] AddOne(int[] arr)
        {
            arr = arr.Select(x => x + 1).ToArray();
            return arr;
        }
        private static int[] Multiply(int[] arr)
        {
            arr = arr.Select(x => x *2).ToArray();
            return arr;
        }
        private static int[] Subtract(int[] arr)
        {
            arr = arr.Select(x => x - 1).ToArray();
            return arr;
        }
        private static int[] Print(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
            return arr;
        }
    }
}
