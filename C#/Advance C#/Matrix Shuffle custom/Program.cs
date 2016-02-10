using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            char[,]matrix=new char[n,n];
            int index = 0;
            int direction = 1;
            int row = 0;
            int col = 0;
            for (int i = 0; i < n*n; i++)
            {
                if (direction == 1)//right
                {
                    matrix[row, col] = input[index];
                    if (col == n - 1 || matrix[row, col + 1] !='\0')
                    {
                        row++;
                        direction++;
                    }
                    else
                    {
                        col++;
                    }
                    index++;
                }
                else if(direction==2)//down
                {
                    matrix[row, col] = input[index];
                    if (row == n - 1 || matrix[row + 1, col] != '\0')
                    {
                        col--;
                        direction++;
                    }
                    else
                    {
                        row++;
                    }
                    index++;
                }
                else if(direction==3)//left
                {
                    matrix[row, col] = input[index];
                    if (col == 0 || matrix[row, col - 1] != '\0')
                    {
                        row--;
                        direction++;
                    }
                    else
                    {
                        col--;
                    }
                    index++;
                }
                else if(direction==4)//up
                {
                    matrix[row, col] = input[index];
                    if (row == 0 || matrix[row - 1, col] != '\0')
                    {
                        direction = 1;
                        col++;
                    }
                    else
                    {
                        row--;
                    }
                    index++;
                }
            }
            for (int row1 = 0; row1 < n; row1++)
            {
                for (int col1 = 0; col1 < n; col1++)
                {
                    Console.Write(matrix[row1,col1]);                  
                }
                Console.WriteLine();
            }
        }
    }

