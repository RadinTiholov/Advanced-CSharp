using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split().Where(x => x.Length <= n).ToList();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
