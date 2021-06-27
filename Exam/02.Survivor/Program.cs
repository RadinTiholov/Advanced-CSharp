using System;
using System.Linq;

namespace _02.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            char[][] matrix = new char[row][];
            int myTokens = 0;
            int opponentsTokens = 0;
            for (int i = 0; i < row; i++)
            {
                char[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                matrix[i] = line;
            }

            string input = Console.ReadLine();
            while (input != "Gong")
            {
                var splitted = input.Split();
                if (input.Contains("Find"))
                {
                    int rowX = int.Parse(splitted[1]);
                    int colY = int.Parse(splitted[2]);
                    if (IsValid(rowX, colY, matrix))
                    {
                        if (matrix[rowX][colY] == 'T')
                        {
                            myTokens++;
                            matrix[rowX][colY] = '-';
                        }
                    }
                }
                else if (input.Contains("Opponent"))
                {
                    int rowX = int.Parse(splitted[1]);
                    int colY = int.Parse(splitted[2]);
                    string direction = splitted[3];
                    if (IsValid(rowX, colY, matrix))
                    {
                        if (matrix[rowX][colY] == 'T')
                        {
                            opponentsTokens++;
                            matrix[rowX][colY] = '-';
                        }

                        if (direction == "up")
                        {
                            if (IsValid(rowX-1, colY, matrix))
                            {
                                if (matrix[rowX - 1][colY] == 'T')
                                {
                                    opponentsTokens++;
                                    matrix[rowX - 1][colY] = '-';
                                }
                            }
                            if (IsValid(rowX - 2, colY, matrix))
                            {
                                if (matrix[rowX - 2][colY] == 'T')
                                {
                                    opponentsTokens++;
                                    matrix[rowX - 2][colY] = '-';
                                }
                            }
                            if (IsValid(rowX - 3, colY, matrix))
                            {
                                if (matrix[rowX - 3][colY] == 'T')
                                {
                                    opponentsTokens++;
                                    matrix[rowX - 3][colY] = '-';
                                }
                            }
                        }
                        else if (direction == "down")
                        {
                            if (IsValid(rowX + 1, colY, matrix))
                            {
                                if (matrix[rowX + 1][colY] == 'T')
                                {
                                    opponentsTokens++;
                                    matrix[rowX + 1][colY] = '-';
                                }
                            }
                            if (IsValid(rowX + 2, colY, matrix))
                            {
                                if (matrix[rowX + 2][colY] == 'T')
                                {
                                    opponentsTokens++;
                                    matrix[rowX + 2][colY] = '-';
                                }
                            }
                            if (IsValid(rowX + 3, colY, matrix))
                            {
                                if (matrix[rowX + 3][colY] == 'T')
                                {
                                    opponentsTokens++;
                                    matrix[rowX + 3][colY] = '-';
                                }
                            }
                        }
                        else if (direction == "left")
                        {
                            if (IsValid(rowX, colY-1, matrix))
                            {
                                if (matrix[rowX][colY - 1] == 'T')
                                {
                                    opponentsTokens++;
                                    matrix[rowX][colY - 1] = '-';
                                }
                            }
                            if (IsValid(rowX, colY - 2, matrix))
                            {
                                if (matrix[rowX][colY - 2] == 'T')
                                {
                                    opponentsTokens++;
                                    matrix[rowX][colY - 2] = '-';
                                }
                            }
                            if (IsValid(rowX, colY-3, matrix))
                            {
                                if (matrix[rowX][colY-3] == 'T')
                                {
                                    opponentsTokens++;
                                    matrix[rowX][colY - 3] = '-';
                                }
                            }
                        }
                        else if (direction == "right")
                        {
                            if (IsValid(rowX, colY + 1, matrix))
                            {
                                if (matrix[rowX][colY + 1] == 'T')
                                {
                                    opponentsTokens++;
                                    matrix[rowX][colY + 1] = '-';
                                }
                            }
                            if (IsValid(rowX, colY + 2, matrix))
                            {
                                if (matrix[rowX][colY + 2] == 'T')
                                {
                                    opponentsTokens++;
                                    matrix[rowX][colY + 2] = '-';
                                }
                            }
                            if (IsValid(rowX, colY + 3, matrix))
                            {
                                if (matrix[rowX][colY + 3] == 'T')
                                {
                                    opponentsTokens++;
                                    matrix[rowX][colY + 3] = '-';
                                }
                            }
                        }

                    }
                }
                input = Console.ReadLine();
            }
            PrintMatrix(matrix);
            Console.WriteLine($"Collected tokens: {myTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentsTokens}");
        }
        private static bool IsValid(int rowX, int colY, char[][] matrix)
        {
            if (rowX < 0 || rowX >= matrix.GetLength(0))
            {
                return false;
            }
            if (colY < 0 || colY >= matrix[rowX].Length)
            {
                return false;
            }
            return true;
        }

        private static void PrintMatrix(char[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
