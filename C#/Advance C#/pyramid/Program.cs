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
            for (int i = 0; i < n; i++)
            {
             string[] input=Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = new int[input.Length];
                for (int j = 0; j <input.Length; j++)
                {
                    numbers[i] = int.Parse(input[i]);
                }
            }
        }
    }

