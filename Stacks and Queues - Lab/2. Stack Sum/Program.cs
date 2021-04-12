using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrinput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(arrinput);
            //stack.Reverse();
            string input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                if (input.Contains("add"))
                {
                    var splitted = input.Split(" ");
                    int a = int.Parse(splitted[1]);
                    int b = int.Parse(splitted[2]);
                    stack.Push(a);
                    stack.Push(b);
                }
                else if (input.Contains("remove"))
                {
                    string[] splitted = input.Split();
                    int a = int.Parse(splitted[1]);
                    if (stack.Count >= a)
                    {
                        for (int i = 0; i < a; i++)
                        {
                            if (stack.Any())
                            {
                                stack.Pop();
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
