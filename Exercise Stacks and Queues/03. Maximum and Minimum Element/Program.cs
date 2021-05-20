using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int comm = input[0];
                if (comm == 1)
                {
                    int element = input[1];
                    stack.Push(element);
                }
                else if (comm == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (comm == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
