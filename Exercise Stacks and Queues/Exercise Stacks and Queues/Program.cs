using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise_Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] splitted = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int pushTimes = splitted[0];
            int poptimes = splitted[1];
            int numberToBeFound = splitted[2];
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < pushTimes; i++)
            {
                stack.Push(input[i]);
            }
            for (int i = 0; i < poptimes; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(numberToBeFound))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
