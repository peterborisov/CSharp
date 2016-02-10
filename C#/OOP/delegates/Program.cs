using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
         delegate void Proba<T>(T prob);
        static void Proba1(string proba1)
        {
            Console.WriteLine("towa e proba");
        }
        static void int1(int probaint)
        {
            Console.WriteLine("5");
        }
        static void data(DateTime sega)
        {
            Console.WriteLine(DateTime.Now);
        }
        static void Main()
        {
            Proba<DateTime> a=new Proba<DateTime>(data);         
            a(DateTime.Now);
            Proba<int>b=new Proba<int>(int1);
            b(6);
            Proba<string>c=new Proba<string>(Proba1);
            c("test");
        }
    }
}
