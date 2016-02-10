using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
        {
            int lineLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int a = input.Length / lineLength;
            double row = (double)input.Length/lineLength;
            if (row > a)
            {
                a++;
            }
            char[,] matrix=new char [a,lineLength];
            int row2 = 0;
            int col2 = 0;
            for (int col = 0; col < lineLength*a; col++)
            {
                int counter = 0;
                if (col <= input.Length - 1)
                    matrix[row2, col2] = input[col];
                else
                    matrix[row2, col2] = ' ';
                col2++;
                if (col2 == lineLength)
                {
                    col2 = 0;
                    row2 ++;
                }
            }
        for (int k = 0; k < a; k++)
        {
            for (int i = a - 2; i > -1; i--)
            {
                for (int j = 0; j < lineLength; j++)
                {
                    if (matrix[i + 1, j] == ' ')
                    {
                        matrix[i + 1, j] = matrix[i, j];
                        matrix[i, j] = ' ';
                    }
                }
            }
        }
        Console.Write("<table>");
        for (int i = 0; i < a; i++)
        {
            Console.Write("<tr>");
            for (int j = 0; j < lineLength; j++)
            {
                Console.Write( "<td>{0}</td>",SecurityElement.Escape(matrix[i,j].ToString()));  
            }
            Console.Write("</tr>");
        }
        Console.Write("</table>");
        }
}

