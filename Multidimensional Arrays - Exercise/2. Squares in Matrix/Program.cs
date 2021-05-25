using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 0;
            char[,] matrix = new char[input[0], input[1]];
            ReadMatrix(matrix);
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if (matrix[i,j+1] == matrix[i, j] && matrix[i+1, j] == matrix[i, j] && matrix[i+1, j+1] == matrix[i, j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
        static char[,] ReadMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            return matrix;
        }
    }
}
