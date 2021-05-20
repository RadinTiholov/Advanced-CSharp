using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var builder = new StringBuilder();

            Stack<string> stack = new Stack<string>();
            stack.Push(builder.ToString());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int comm = int.Parse(input[0]);
                if (comm == 1)
                {
                    builder.Append(input[1]);
                    stack.Push(builder.ToString());
                }
                else if (comm == 2)
                {
                    stack.Push(builder.ToString());

                    int number = int.Parse(input[1]);
                    builder.Remove(builder.Length - number, number);
                }
                else if (comm == 3)
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(builder[index - 1]);

                }
                else if (comm == 4)
                {
                    stack.Pop(); 
                    builder = new StringBuilder();
                    builder.Append(stack.Peek());
                }
            }
        }
    }
}
