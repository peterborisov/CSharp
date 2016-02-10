using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
        {

            //3 4 2 3 4 2 1 12 2 3 4
//3 4 -> 30.00%
//4 2 -> 20.00%
//2 3 -> 20.00%
//2 1 -> 10.00%
//1 12 -> 10.00%
//12 2 -> 10.00%



            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int couples = numbers.Length-1;
            var couplefrek=new Dictionary<string,int>();
            for (int i = 1; i < numbers.Length; i++)
            {
                string currentCouple = String.Format("{0} {1}", numbers[i - 1], numbers[i]);
                if (!couplefrek.ContainsKey(currentCouple))
                {
                    couplefrek.Add(currentCouple,0);
                }              
                    couplefrek[currentCouple]++;                           
            }
            foreach (var i in couplefrek)
            {
                double value = i.Value*100.0/couples;
                Console.WriteLine("{0} -> {1:F2}%",i.Key,value);
            }
        }

}
