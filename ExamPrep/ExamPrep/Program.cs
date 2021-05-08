using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int sum = 0;
            bool areCollected = true;
            for (int i = 0; i < n; i++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            int[] cordinates = new int[2];
            //
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] == 'S')
                    {
                        cordinates[0] = i;
                        cordinates[1] = j;
                    }
                }
            }
            //
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "up")
                {
                    if (isValid(cordinates[0]-1, cordinates[1], matrix) && sum < 50)
                    {
                        matrix[cordinates[0], cordinates[1]] = '-';
                        if (matrix[cordinates[0] - 1, cordinates[1]] == 'O')
                        {
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i, j] == 'O' && i != cordinates[0]-1 && j != cordinates[1])
                                    {
                                        matrix[cordinates[0] - 1, cordinates[1]] = '-';
                                        matrix[i, j] = 'S';
                                        cordinates[0] = i;
                                        cordinates[1] = j;
                                    }
                                }
                            }
                        }
                        else if (matrix[cordinates[0]-1, cordinates[1]] == '-')
                        {
                            matrix[cordinates[0] - 1, cordinates[1]] = 'S';
                            cordinates[0] = cordinates[0] - 1;
                            cordinates[1] = cordinates[1];
                        }
                        else
                        {
                            sum += int.Parse(matrix[cordinates[0] - 1, cordinates[1]].ToString());
                            
                            matrix[cordinates[0] - 1, cordinates[1]] = 'S';
                            cordinates[0] = cordinates[0] - 1;
                            cordinates[1] = cordinates[1];
                            if (sum >= 50)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        areCollected = false;
                        matrix[cordinates[0], cordinates[1]] = '-';
                        break;
                    }

                }
                else if (input == "down")
                {
                    if (isValid(cordinates[0] + 1, cordinates[1], matrix) && sum < 50)
                    {
                        matrix[cordinates[0], cordinates[1]] = '-';
                        if (matrix[cordinates[0] + 1, cordinates[1]] == 'O')
                        {
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(0); j++)
                                {
                                    if (matrix[i, j] == 'O' && i != cordinates[0] + 1 && j != cordinates[1])
                                    {
                                        matrix[cordinates[0] + 1, cordinates[1]] = '-';
                                        matrix[i, j] = 'S';
                                        cordinates[0] = i;
                                        cordinates[1] = j;
                                    }
                                }
                            }
                        }
                        else if (matrix[cordinates[0] + 1, cordinates[1]] == '-')
                        {
                            matrix[cordinates[0] + 1, cordinates[1]] = 'S';
                            cordinates[0] = cordinates[0] + 1;
                            cordinates[1] = cordinates[1];
                        }
                        else
                        {
                            sum += int.Parse(matrix[cordinates[0] + 1, cordinates[1]].ToString());
                            
                            matrix[cordinates[0] + 1, cordinates[1]] = 'S';
                            cordinates[0] = cordinates[0] + 1;
                            cordinates[1] = cordinates[1];
                            if (sum >= 50)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        areCollected = false;
                        matrix[cordinates[0], cordinates[1]] = '-';
                        break;
                    }
                }
                else if (input == "left")
                {
                    //
                    if (isValid(cordinates[0], cordinates[1]-1, matrix) && sum < 50)
                    {
                        matrix[cordinates[0], cordinates[1]] = '-';
                        if (matrix[cordinates[0], cordinates[1] - 1] == 'O')
                        {
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(0); j++)
                                {
                                    if (matrix[i, j] == 'O' && i != cordinates[0] && j != cordinates[1]-1)
                                    {
                                        matrix[cordinates[0], cordinates[1] - 1] = '-';
                                        matrix[i, j] = 'S';
                                        cordinates[0] = i;
                                        cordinates[1] = j;
                                    }
                                }
                            }
                        }
                        else if (matrix[cordinates[0], cordinates[1] - 1] == '-')
                        {
                            matrix[cordinates[0], cordinates[1] - 1] = 'S';
                            cordinates[0] = cordinates[0];
                            cordinates[1] = cordinates[1]-1;
                        }
                        else
                        {
                            sum += int.Parse(matrix[cordinates[0], cordinates[1] - 1].ToString());
                            
                            matrix[cordinates[0], cordinates[1] - 1] = 'S';
                            cordinates[0] = cordinates[0];
                            cordinates[1] = cordinates[1]-1;
                            if (sum >= 50)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        areCollected = false;
                        matrix[cordinates[0], cordinates[1]] = '-';
                        break;
                    }
                    //
                }
                else if (input == "right")
                {
                    if (isValid(cordinates[0], cordinates[1] + 1, matrix) && sum < 50)
                    {
                        matrix[cordinates[0], cordinates[1]] = '-';
                        if (matrix[cordinates[0], cordinates[1] + 1] == 'O')
                        {
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(0); j++)
                                {
                                    if (matrix[i, j] == 'O' && i != cordinates[0] && j != cordinates[1] + 1)
                                    {
                                        matrix[cordinates[0], cordinates[1] + 1] = '-';
                                        matrix[i, j] = 'S';
                                        cordinates[0] = i;
                                        cordinates[1] = j;
                                    }
                                }
                            }
                        }
                        else if (matrix[cordinates[0], cordinates[1] + 1] == '-')
                        {
                            matrix[cordinates[0], cordinates[1] + 1] = 'S';
                            cordinates[0] = cordinates[0];
                            cordinates[1] = cordinates[1] + 1;
                        }
                        else
                        {
                            sum += int.Parse(matrix[cordinates[0], cordinates[1] + 1].ToString());
                            matrix[cordinates[0], cordinates[1] + 1] = 'S';
                            cordinates[0] = cordinates[0];
                            cordinates[1] = cordinates[1] + 1;
                            if (sum >= 50)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        areCollected = false;
                        matrix[cordinates[0], cordinates[1]] = '-';
                        break;
                    }
                }
            }
            if (areCollected == true)
            {
                Console.WriteLine($"Good news! You succeeded in collecting enough money!");
            }
            else
            {
                Console.WriteLine($"Bad news, you are out of the bakery.");
            }
            Console.WriteLine($"Money: {sum}");
            Print(matrix);
        }


        private static bool isValid(int row, int col, char[,] matrix)
        {
            if (row < 0 || row >= matrix.GetLength(0))
            {
                return false;
            }
            if (col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }
            return true;
        }

        private static void Print(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
