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
            int rows = int.Parse(lines[0]);
            int cols = int.Parse(lines[1]);
            string[,] arr=new string[rows,cols];
            for (int i = 0; i < rows; i++)
            {
                string[] line = Console.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = line[j];
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    
                } 
            }
        }
    }

