using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_FindsInArraySequenceOfGivenSum
{
    class FindsInArraySequenceOfGivenSum
    {
        static void Main()
        {
            //Write a program that finds in given array of integers a sequence of given sum S (if present). 
            //Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	
            int sumS = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = input.Select(int.Parse).ToArray();       
            int startIndex = 0;
            int endIndex = 0;
            int CurrSum = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                CurrSum += array[i];
                startIndex = i;
                for (int p = i + 1; p < array.Length; p++)
                {
                    CurrSum += array[p];
                    endIndex = p;
                    if (CurrSum == sumS)
                    {
                        for (int k = startIndex; k <= endIndex; k++)
                        {
                            Console.WriteLine(array[k]);
                        }
                        return;
                    }
                }
                CurrSum = 0;
            }
            Console.WriteLine("The sumS is not present in the array.");
        }
    }
}