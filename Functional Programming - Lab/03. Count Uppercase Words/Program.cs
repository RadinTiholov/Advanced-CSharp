using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> func = (a) => Char.IsUpper(a[0]);
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => func(x)).ToArray();
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
