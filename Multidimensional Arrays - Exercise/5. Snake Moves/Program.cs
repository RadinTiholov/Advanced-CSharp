using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[][] matrix = new char[input[0]][];
            string text = Console.ReadLine();
            int i = 0;
            for (int row = 0; row < input[0]; row++)
            {
                matrix[row] = new char[input[1]];
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row][col] = text[i];
                    i++;
                    if (i == text.Length)
                    {
                        i = 0;
                    }
                }
            }
            for (int j = 0; j < input[0]; j++)
            {
                if (j % 2 ==1)
                {
                    Array.Reverse(matrix[j]);
                }
            }
            PrintMatrix<char>(matrix, input[0], input[1]);

        }
        private static void PrintMatrix<T>(T[][] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i][j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
