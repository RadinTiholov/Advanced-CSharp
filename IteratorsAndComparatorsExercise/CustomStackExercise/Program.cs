using System;
using System.Linq;

namespace CustomStackExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            CustomStack<string> stack = new CustomStack<string>();
            while (input != "END")
            {
                var splitted = input.Split(new char[] {' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                //Console.WriteLine(string.Join(" ", splitted));
                if (splitted[0] == "Push")
                {
                    stack.Push(splitted.Skip(1).ToArray());
                }
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < 2; i++)
            {
                if (stack.Any())
                {
                    foreach (var item in stack)
                    {
                        Console.WriteLine(item);
                    }
                }
                
            }
        }
    }
}
