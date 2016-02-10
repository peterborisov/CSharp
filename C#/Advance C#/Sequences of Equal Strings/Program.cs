using System;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine();
            for (int i = 0; i < input.Length-1; i++)
            {
                Console.Write(input[i]+" ");
                if(!input[i].Equals(input[i+1]))
                    Console.WriteLine();
            }
            Console.WriteLine(input[input.Length-1]);
            Console.WriteLine();
        }
    }

