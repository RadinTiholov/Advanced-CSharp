using System;
using System.Linq;
using System.Collections.Generic;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '('|| input[i] == '{'||input[i] == '[')
                {
                    stack.Push(input[i]);
                }
                else if (input[i] == ')' || input[i] == '}' || input[i] == ']')
                {
                    queue.Enqueue(input[i]);
                }
            }
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (stack.Peek() == '{')
                {
                    if (queue.Peek() == '}')
                    {
                        stack.Pop();
                        queue.Dequeue();
                    }
                }
            }
            if (input.Length == 1 || input.Length == 0)
            {
                Console.WriteLine("No");
                return;
            }
            if (IsItCorrect(stack, queue, input))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private static bool IsItCorrect(Stack<char> stack, Queue<char> queue, string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (stack.Peek() == '{')
                {
                    if (queue.Peek() != '}')
                    {
                        stack.Pop();
                        queue.Dequeue();
                        return false;
                    }
                }
                if (stack.Peek() == '}')
                {
                    if (queue.Peek() != '{')
                    {
                        stack.Pop();
                        queue.Dequeue();
                        return false;
                    }
                }
                if (stack.Peek() == '(')
                {
                    if (queue.Peek() != ')')
                    {
                        stack.Pop();
                        queue.Dequeue();
                        return false;
                    }
                }
                if (stack.Peek() == ')')
                {
                    if (queue.Peek() != '(')
                    {
                        stack.Pop();
                        queue.Dequeue();
                        return false;
                    }
                }
                if (stack.Peek() == '[')
                {
                    if (queue.Peek() != ']')
                    {
                        stack.Pop();
                        queue.Dequeue();
                        return false;
                    }
                }
                if (stack.Peek() == ']')
                {
                    if (queue.Peek() != '[')
                    {
                        stack.Pop();
                        queue.Dequeue();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
