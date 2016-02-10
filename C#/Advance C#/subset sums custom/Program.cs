using System;
using System.Collections.Generic;
using System.Linq;

internal class SequenceOfGivenSum
{
    public static List<int> used = new List<int>();
    public static int currSum = 0;
    public static int pos = 0;
    public static int Sum(List<int> nums,int sum)
    {
        currSum += nums[pos];
        used.Add(nums[pos]);
        if (currSum >= sum)
        {
            return currSum;
        }
        else
        {
            pos++;
            return currSum + Sum(nums, sum);
        }
    }
    private static void Main()
    {
        int inputSum = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

    }
}
