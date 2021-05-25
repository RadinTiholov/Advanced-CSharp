using System;
using System.Linq;

namespace Multidimensional_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            matrix = ReadMatrix(matrix);
            int leftDi = 0;
            int rightDi = 0;
            for (int i = 0; i < n; i++)
            {
                leftDi += matrix[i, i];
            }
            for (int i = n - 1; i >= 0; i--)
            {
                rightDi += matrix[i, n-1 - i];
            }
            if (leftDi>rightDi)
            {
                Console.WriteLine(leftDi-rightDi);
            }
            else if (rightDi > leftDi)
            {
                Console.WriteLine(rightDi-leftDi);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        private static int[,] ReadMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            return matrix;
        }
    }
}
