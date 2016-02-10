using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] lines = Console.ReadLine().Split();
        int row = int.Parse(lines[0]);
        int col = int.Parse(lines[1]);
        int[,] matrix = new int[row, col];
        int maxSum = Int32.MinValue;
        int currentSum = 0;
        int[,] finalMatrix = new int[3, 3];
        //fill the matrix
        for (int i = 0; i < row; i++)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = arr[j];
            }
        }
        //find sub matrix
        for (int i = 0; i < row - 2; i++)
        {
            for (int j = 0; j < col - 2; j++)
            {
                currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] +
                                    matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    finalMatrix[0, 0] = matrix[i, j];
                    finalMatrix[0, 1] = matrix[i, j + 1];
                    finalMatrix[0, 2] = matrix[i, j + 2];

                    finalMatrix[1, 0] = matrix[i + 1, j];
                    finalMatrix[1, 1] = matrix[i + 1, j + 1];
                    finalMatrix[1, 2] = matrix[i + 1, j + 2];

                    finalMatrix[2, 0] = matrix[i + 2, j];
                    finalMatrix[2, 1] = matrix[i + 2, j + 1];
                    finalMatrix[2, 2] = matrix[i + 2, j + 2];
                }
                currentSum = 0;
            }
        }
        Console.WriteLine();
        Console.WriteLine(maxSum);

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(finalMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

