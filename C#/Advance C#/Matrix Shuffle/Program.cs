using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
    class Program
    {
        static void Main()
        {
            var numbers = Regex.Split(Console.ReadLine(), @"[^0-9]+")
           .Where(x => x != string.Empty)
           .Select(number => string.Format("0x{0:X4}", int.Parse(number)));

            Console.WriteLine(string.Join("-", numbers));
            
        }
    }

