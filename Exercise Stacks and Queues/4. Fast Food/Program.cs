using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            var queue = new Queue<int>(input);
            Console.WriteLine(queue.Max());
            while (queue.Count > 0)
            {
                int first = queue.Peek();

                sum += first;

                if (sum <= quantity)
                {
                    queue.Dequeue();
                }
                else
                {
                    int[] arr = queue.ToArray();
                    Console.WriteLine("Orders left: " + string.Join(" ", arr));
                    return;
                }
            }
            
            Console.WriteLine("Orders complete");
            
        }
    }
}
