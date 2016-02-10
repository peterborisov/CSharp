using System;
using System.Collections.Generic;

namespace _01_CustomLinq
{
    class Program
    {
        static void Main()
        {
            List<int> test = new List<int>();

            test.Add(3);
            test.Add(124);
            test.Add(2341);
            test.Add(6);
            test.Add(7);
            test.Add(10);

            var testList = test.WhereNot(x => (x % 2 == 0));

            foreach (var item in testList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
