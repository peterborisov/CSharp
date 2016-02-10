using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] arr = input.Select(double.Parse).ToArray();
            List<double>roundet=new List<double>();
            List<double>floating=new List<double>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]% 1 != 0)
                {
                    floating.Add(arr[i]);
                }
                else
                {
                    roundet.Add(arr[i]);
                }
            }
        Console.Write("[");
        foreach (var floatpoint in floating)
        {
            Console.Write(floatpoint+" ");
        }
        Console.Write("] - >");
        Console.Write("min {0}=",floating.Min()+",");
        Console.Write("max {0}=", floating.Max() + ",");
        Console.Write("sum {0}=", floating.Sum() + ","); 
        Console.Write("average: {0:F2}", floating.Average());
        Console.WriteLine();
        Console.Write("[");
        foreach (var round in roundet)
        {
            Console.Write(round + " ");
        }
        Console.Write("] - >");
        Console.Write("min {0}=", roundet.Min() + ",");
        Console.Write("max {0}=", roundet.Max() + ",");
        Console.Write("sum {0}=", roundet.Sum() + ",");
        Console.Write("average {0:F2}=", roundet.Average());
        Console.WriteLine();
        }
}

