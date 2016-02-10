using _02.InterestCalculator;
using System;

namespace _02_Calculator
{

    class Program
    {
        static void Main()
        {
            Func<double, double, int, double> something = GetSimpleInterests;
            Func<double, double, int, double> something2 = GetCompoundInterest;

            InterestCalculator test = new InterestCalculator(500.5, 5.5, 5, something);

            Console.WriteLine(test);
        }

        public static double GetSimpleInterests(double money, double percent, int years)
        {
            double a = money * (1.0 + percent * years);
            return a;
        }

        public static double GetCompoundInterest(double money, double percent, int years)
        {
            double a = money * Math.Pow((1 + (percent / 100 / 12)), years * 12);
            return a;
        }
    }
}

