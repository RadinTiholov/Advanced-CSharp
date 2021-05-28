using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            HashSet<int> nNumber = new HashSet<int>();
            HashSet<int> mNumber = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                nNumber.Add(a);
            }
            for (int i = 0; i < m; i++)
            {
                int b = int.Parse(Console.ReadLine());
                mNumber.Add(b);
            }
            if (nNumber.Count >= mNumber.Count)
            {
                foreach (var item in nNumber)
                {
                    if (mNumber.Contains(item))
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
            else
            {
                List<int> list = new List<int>();
                foreach (var item in mNumber)
                {
                    if (mNumber.Contains(item))
                    {
                        list.Add(item);
                    }
                }
                foreach (var nitem in nNumber)
                {
                    if (list.Contains(nitem))
                    {
                        Console.Write($"{nitem} ");
                    }
                }
            }
        }
    }
}
