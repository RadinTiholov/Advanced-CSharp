using System;
using System.Linq;

namespace _4._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(", ").Select(double.Parse).Select(x => x * 0.2 + x).ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine($"{item:F2}");
            }
        }
    }
}
