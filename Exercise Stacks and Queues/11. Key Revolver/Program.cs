using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceForBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfIntell = int.Parse(Console.ReadLine());

            Queue<int> locksQueue = new Queue<int>(locks);
            Stack<int> bulletStack = new Stack<int>(bullets);

            int bulletCount = 0;
            int count = 0;

            while (locksQueue.Any() && bulletStack.Any())
            {
                if (bulletStack.Peek() <= locksQueue.Peek())
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                bulletStack.Pop();

                count++;

                if (count == sizeOfGunBarrel && bulletStack.Any())
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }

                bulletCount++;
            }

            if (bulletStack.Count >= 0 && locksQueue.Count == 0)
            {

                int earned = valueOfIntell - (bulletCount * priceForBullet);
                Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${earned}");

            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
        }
    }
}
