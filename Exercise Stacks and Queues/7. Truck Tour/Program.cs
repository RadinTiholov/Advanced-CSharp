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
            Queue<int[]> queue = new Queue<int[]>();

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(input);
            }
            while (true)
            {
                int totalFuel = 0;
                foreach (int[] petrolPump in queue)
                {
                    int petrol = petrolPump[0];
                    int distance = petrolPump[1];
                    totalFuel += petrol;
                    totalFuel -= distance;
                    if (totalFuel < 0)
                    {
                        count++;
                        queue.Enqueue(queue.Dequeue());
                        break;
                    }
                }
                if (totalFuel >= 0)
                {
                    break;
                }

            }
            Console.WriteLine(count);
        }
    }
}
