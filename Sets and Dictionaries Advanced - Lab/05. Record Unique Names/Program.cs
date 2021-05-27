using System;
using System.Collections.Generic;
using System.Linq;


namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hasSet = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                hasSet.Add(name);
            }
            foreach (var item in hasSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
