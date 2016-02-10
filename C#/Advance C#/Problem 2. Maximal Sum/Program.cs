using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(input[0]) ;
            int cols = int.Parse(input[1]) ;
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] currentNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] =int.Parse( currentNumbers[col]);
                }
            }
            int bestSum = int.MinValue;
            int currentSum = 0;
            int[,] maxSum = new int[3, 3];
            for (int row = 0; row < rows-2; row++)
            {
                for (int col = 0; col < cols-2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if(currentSum>bestSum)
                    {
                        bestSum = currentSum;
                        for (int i = 0; i < maxSum.GetLength(0); i++)
                        {
                            for (int j = 0; j < maxSum.GetLength(1); j++)
                            {
                                maxSum[i, j] = matrix[row + i, col + j];
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("best sum={0}",bestSum);
            for (int i = 0; i < maxSum.GetLength(0); i++)
            {
                for (int j = 0; j < maxSum.GetLength(1); j++)
                {
                      Console.Write("{0,2} ", maxSum[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

