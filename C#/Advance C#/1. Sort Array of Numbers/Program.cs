using System;
using System.Linq;
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            int[] nums = input.Select(int.Parse).ToArray();
            Array.Sort(nums);
            foreach (var i in nums)
            {
                Console.Write(i+" ");
            }
        }
    }

