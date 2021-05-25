using System;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n,n];
            matrix = ReadMatrix(matrix);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] == 'K')
                    {
                        int danger = FindDanger(i, j ,matrix);
                        if (IsValid(i - 2, j - 1, matrix))
                        {
                            if (danger < FindDanger(i - 2, j - 1, matrix))
                            {
                                matrix[i - 2, j - 1] = '0';
                                count++;
                            }
                            else
                            {
                                matrix[i, j] = '0';
                                count++;
                            }
                        }
                        if (IsValid(i - 2, j + 1, matrix))
                        {
                            if (danger < FindDanger(i - 2, j + 1, matrix))
                            {
                                matrix[i - 2, j + 1] = '0';
                                count++;
                            }
                            else
                            {
                                matrix[i, j] = '0';
                                count++;
                            }
                        }
                        if (IsValid(i + 2, j - 1, matrix))
                        {
                            if (danger < FindDanger(i + 2, j - 1, matrix))
                            {
                                matrix[i + 2, j - 1] = '0';
                                count++;
                            }
                            else
                            {
                                matrix[i, j] = '0';
                                count++;
                            }
                        }
                        if (IsValid(i + 2, j + 1, matrix))
                        {
                            if (danger < FindDanger(i + 2, j + 1, matrix))
                            {
                                matrix[i + 2, j + 1] = '0';
                                count++;
                            }
                            else
                            {
                                matrix[i, j] = '0';
                                count++;
                            }
                        }
                        if (IsValid(i + 1, j - 2, matrix))
                        {
                            if (danger < FindDanger(i + 1, j - 2, matrix))
                            {
                                matrix[i + 1, j - 2] = '0';
                                count++;
                            }
                            else
                            {
                                matrix[i, j] = '0';
                                count++;
                            }
                        }
                        if (IsValid(i - 1, j - 2, matrix))
                        {
                            if (danger < FindDanger(i - 1, j - 2, matrix))
                            {
                                matrix[i - 1, j - 2] = '0';
                                count++;
                            }
                            else
                            {
                                matrix[i, j] = '0';
                                count++;
                            }
                        }
                        if (IsValid(i - 1, j + 2, matrix))
                        {
                            if (danger < FindDanger(i - 1, j + 2, matrix))
                            {
                                matrix[i - 1, j + 2] = '0';
                                count++;
                            }
                            else
                            {
                                matrix[i, j] = '0';
                                count++;
                            }
                        }
                        if (IsValid(i + 1, j + 2, matrix))
                        {
                            if (danger < FindDanger(i + 1, j + 2, matrix))
                            {
                                matrix[i + 1, j + 2] = '0';
                                count++;
                            }
                            else
                            {
                                matrix[i, j] = '0';
                                count++;
                            }
                        }
                    }
                    
                }
            }
            Console.WriteLine(count);

        }

        private static int FindDanger( int i , int j , char[,] matrix)
        {
            int danger = 0;
            if (IsValid(i - 2, j - 1, matrix))
            {
                danger++;
            }
            if (IsValid(i - 2, j + 1, matrix))
            {
                danger++;
            }
            if (IsValid(i + 2, j - 1, matrix))
            {
                danger++;
            }
            if (IsValid(i + 2, j + 1, matrix))
            {
                danger++;
            }
            //
            if (IsValid(i + 1, j - 2, matrix))
            {
                danger++;
            }
            if (IsValid(i - 1, j - 2, matrix))
            {
                danger++;
            }
            if (IsValid(i - 1, j + 2, matrix))
            {
                danger++;
            }
            if (IsValid(i + 1, j + 2, matrix))
            {
                danger++;
            }
            return danger;
        }

        private static char[,] ReadMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            return matrix;
        }
        private static bool IsValid(int row, int col, char[,] matrix)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1)|| matrix[row, col] != 'K')
            {
                return false;
            }
            return true;
        }
    }
}
