using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] arr = new double[n][];
            for (int i = 0; i < n; i++)
            {
                double[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                arr[i] = input;
            }
            for (int i = 0; i < n-1; i++)
            {
                if (arr[i].Length == arr[i+1].Length)
                {
                    arr[i] = arr[i].Select(x => x * 2).ToArray();
                    arr[i+1] = arr[i + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    arr[i] = arr[i].Select(x => x / 2).ToArray();
                    arr[i + 1] = arr[i + 1].Select(x => x / 2).ToArray();
                }
            }
            string secondInput = Console.ReadLine();
            while (secondInput != "End")
            {
                string[] line = Console.ReadLine().Split();
                if (line[0] == "Add")
                {
                    int x = int.Parse(line[1]);
                    int y = int.Parse(line[2]);
                    double value = double.Parse(line[3]);
                    if (IsValid(x, y, arr))
                    {
                        arr[x][y] += value;
                    }
                }
                else if (line[0] == "Subtract")
                {
                    int x = int.Parse(line[1]);
                    int y = int.Parse(line[2]);
                    double value = double.Parse(line[3]);
                    if (IsValid(x, y, arr))
                    {
                        arr[x][y] -= value;
                    }
                }
                secondInput = Console.ReadLine();
            }
            PrintMatrix(arr);
        }

        private static bool IsValid(int x, int y, double[][] arr)
        {
            if (x < 0 || x >= arr.Length || y < 0 || y >= arr[x].Length)
            {
                return false;
            }
            return true;
        }

        private static void PrintMatrix(double[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
