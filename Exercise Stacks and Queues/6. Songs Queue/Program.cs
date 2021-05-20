using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            var queue = new Queue<string>(input);
            while (queue.Count > 0)
            {
                string command = Console.ReadLine();
                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string song = command.Substring(4);
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
