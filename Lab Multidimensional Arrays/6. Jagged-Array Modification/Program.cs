using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[i] = input;
            }
            string secondInput = Console.ReadLine();
            while (secondInput != "END")
            {
                var splitted = secondInput.Split();
                string command = splitted[0];
                if (command == "Add")
                {
                    int row = int.Parse(splitted[1]);
                    int col = int.Parse(splitted[2]);
                    int value = int.Parse(splitted[3]);
                    if (row >= 0 && row <= matrix.Length-1 && col >= 0 && col <= matrix[row].Length-1)
                    {
                        matrix[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (command == "Subtract")
                {
                    int row = int.Parse(splitted[1]);
                    int col = int.Parse(splitted[2]);
                    int value = int.Parse(splitted[3]);
                    if (row >= 0 && row <= matrix.Length - 1 && col >= 0 && col <= matrix[row].Length - 1)
                    {
                        matrix[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                secondInput = Console.ReadLine();
            }
            PrintMatrix(matrix);
        }
        private static void PrintMatrix<T>(T[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
