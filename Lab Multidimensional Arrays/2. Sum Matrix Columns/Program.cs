using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];
            List<int> result = new List<int>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = array[j];
                }
            }

            for (int i = 0; i < cols; i++)
            {
                int currenSum = 0;
                for (int j = 0; j < rows; j++)
                {
                    currenSum += matrix[j, i];
                }
                Console.WriteLine(currenSum);
            }
        }
    }
}
