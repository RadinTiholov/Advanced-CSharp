using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> func = (x) => x
                .Split()
                .ToList()
                .ForEach(x => Console.WriteLine(x));
            func(Console.ReadLine());
        }
    }
}
