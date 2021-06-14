using System;
using System.Collections.Generic;

namespace ExerciseGenerics
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> list = new List<Box<int>>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(new Box<int> {Value = input });
            }
            foreach (var box in list)
            {
                Console.WriteLine(box.ToString());
            }
        }
    }
}
