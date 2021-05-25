using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 0;
            int[,] matrix = new int[input[0], input[1]];
            ReadMatrix(matrix);
            int max = int.MinValue;

            int x = 0;
            int y = 0;
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > max)
                    {
                        max = sum;
                        x = i;
                        y = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {max}");
            Console.WriteLine(matrix[x, y] + " "+ matrix[x, y+1] + " " + matrix[x, y + 2]);
            Console.WriteLine(matrix[x+1, y] + " " + matrix[x + 1, y + 1] + " " + matrix[x + 1, y + 2]);
            Console.WriteLine(matrix[x + 2, y] + " " + matrix[x + 2, y + 1] + " " + matrix[x + 2, y + 2]);

        }

        

        static int[,] ReadMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            return matrix;
        }
    }
}
