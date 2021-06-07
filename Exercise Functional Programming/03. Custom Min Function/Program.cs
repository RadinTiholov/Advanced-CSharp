using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string,int> func = (x) => x
            .Split()
            .Select(int.Parse)
            .Min();
            string help = Console.ReadLine();
            int a = func(help);
            Console.WriteLine(a);
        }
    }
}
