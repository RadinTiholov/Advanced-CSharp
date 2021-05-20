using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] splitted = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int enqueueTimes = splitted[0];
            int dequeueTimes = splitted[1];
            int numberToBeFound = splitted[2];
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < enqueueTimes; i++)
            {
                queue.Enqueue(input[i]);
            }
            for (int i = 0; i < dequeueTimes; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(numberToBeFound))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count > 0)
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
