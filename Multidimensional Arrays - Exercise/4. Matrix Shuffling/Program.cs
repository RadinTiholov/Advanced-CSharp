using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[input[0], input[1]];
            ReadMatrix(matrix);
            string stringInput = Console.ReadLine();
            while (stringInput != "END")
            {
                var splitted = stringInput.Split();
                if (!stringInput.Contains("swap")|| splitted.Length > 5|| splitted.Length < 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    if (IsValid(int.Parse(splitted[1]), int.Parse(splitted[2]), matrix) 
                        && IsValid(int.Parse(splitted[3]), int.Parse(splitted[4]), matrix))
                    {
                        matrix = Swap(matrix, splitted);
                        PrintMatrix(matrix);
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }


                stringInput = Console.ReadLine();
            }


        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        private static string[,] Swap(string[,] matrix, string[] splitted)
        {
            string help = matrix[int.Parse(splitted[1]), int.Parse(splitted[2])];
            matrix[int.Parse(splitted[1]), int.Parse(splitted[2])] = matrix[int.Parse(splitted[3]), int.Parse(splitted[4])];
            matrix[int.Parse(splitted[3]), int.Parse(splitted[4])] = help;
            return matrix;
        }

        private static bool IsValid(int row, int col, string[,] matrix)
        {
            if (row < 0 || row >= matrix.GetLength(0)|| col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }
            return true;
        }

        static string[,] ReadMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            return matrix;
        }
    }
}
