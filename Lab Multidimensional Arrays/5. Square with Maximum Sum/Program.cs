using System;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int n = firstInput[0];
            int m = firstInput[1];

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int biggestSum = int.MinValue;
            int[] cordinates = new int[2];
            for (int i = 0; i < n -1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (matrix[i, j] + matrix[i, j +1] + matrix[i + 1, j] + matrix[i + 1, j + 1] > biggestSum)
                    {
                        biggestSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                        cordinates[0] = i;
                        cordinates[1] = j;
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix[cordinates[0] + i, cordinates[1] + j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(biggestSum);

        }
        private static void PrintMatrix<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
