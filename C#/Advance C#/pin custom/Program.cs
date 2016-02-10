using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
     static void Main()
     {
            string name = Console.ReadLine();
            string gender = Console.ReadLine();
            string pin = Console.ReadLine();
            var newarr = new List<int>();
            var sum = 0;
            List<int> blabla = new List<int>();
            for (var i = 0; i < pin.Length; i++)
            {
                newarr.Add(int.Parse(pin[i].ToString()));
            }
            int a = 0;
            int[] mul = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            for (int i = 0; i < newarr.Count - 1; i++)
            {
                a = newarr[i] * mul[i];
                blabla.Add(a);
            }
            foreach (var i in blabla)
            {
               sum+=i;
            }
            int sumAfterdevide = sum % 11;
            if(sumAfterdevide==newarr[9])
            {
                Console.WriteLine("{{\"name\":\"{0}\",\"gender\":\"{1}\",\"pin\":\"{2}\"}}", name, gender, pin);
            }
            else 
            {
                Console.WriteLine("<h2>Incorrect data</h2>");
            }
        }
        //if(sum/)

        //double r = newarr.Aggregate((a, x) => a * x);

    }

     

