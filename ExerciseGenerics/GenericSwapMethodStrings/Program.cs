using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));

            }
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap<int>(list, commands[0], commands[1]);
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        private static void Swap<T>(List<T> list, int index1, int index2)
        {
            T help = list[index1];
            list[index1] = list[index2];
            list[index2] = help;
        }
    }
}
