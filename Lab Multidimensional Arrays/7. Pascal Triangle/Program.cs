using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] jagged = new long[n][];
            for (long i = 0; i < n; i++)
            {
                jagged[i] = new long[i+1];
                jagged[i][0] = 1;
                jagged[i][jagged[i].Length -1] = 1;
                for (long j = 1; j < i; j++)
                {
                    jagged[i][j] = jagged[i - 1][j] + jagged[i - 1][j - 1];
                }

                Console.WriteLine(string.Join(" ", jagged[i]));
            }
        }
    }
}
