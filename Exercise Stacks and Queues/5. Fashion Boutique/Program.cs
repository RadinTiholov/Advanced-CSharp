using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(input);

            int sum = 0;
            int count = 1;
            while (stack.Count > 0)
            {
                sum += stack.Peek();

                if (sum <= n)
                {
                    stack.Pop();
                }
                else
                {
                    count++;
                    sum = 0;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
