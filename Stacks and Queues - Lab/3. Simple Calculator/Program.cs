using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ")
                .ToArray();
            Stack<string> stack = new Stack<string>(input.Reverse());
            while (stack.Count > 1)
            {
                int firstElemet = int.Parse(stack.Pop());
                string opert = stack.Pop();
                int secondElement = int.Parse(stack.Pop());
                int help = 0;
                if (opert == "+")
                {
                    help = firstElemet + secondElement;
                }
                else if (opert == "-")
                {
                    help = firstElemet - secondElement;
                }
                stack.Push(help.ToString());
            }
            Console.WriteLine(stack.Pop());


        }
    }
}
