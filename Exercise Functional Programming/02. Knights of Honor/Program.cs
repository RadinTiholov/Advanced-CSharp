using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> func = (x) => x
                .Split()
                .ToList()
                .ForEach(x => Console.WriteLine("Sir "+x));
            func(Console.ReadLine());
        }
    }
}
