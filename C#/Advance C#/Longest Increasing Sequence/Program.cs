using System;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main()
        {
            //2 3 4 1 50 2 3 4 5
            //2 3 4
            //1 50
            //2 3 4 5
            //Longest: 2 3 4 5


            string input = Console.ReadLine();
            int[] numbers = input.Split().Select(int.Parse).ToArray();

            int counter = 1;
            int maxLength = 1;
            int end = 0;

            Console.Write(numbers[0] + " ");
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    counter++;
                    Console.Write(numbers[i] + " ");
                }
                else
                {
                    counter = 1;
                    Console.WriteLine();
                    Console.Write(numbers[i] + " ");
                }
                if (counter > maxLength)
                {
                    maxLength = counter;
                    end = i;
                }
            }
            Console.WriteLine();
            Console.Write("Longest: ");
            for (int j = end - maxLength + 1; j <= end; j++)
            {
                Console.Write(numbers[j] + " ");
            }
            Console.WriteLine();
        }
    }

