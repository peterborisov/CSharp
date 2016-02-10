using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        var alphabet = new List<string> { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
        var input = Console.ReadLine();
        long decimalPresentation = 0;
        for (int i = 0; i < input.Length; i += 3)
        {
            var digitin13 = input.Substring(i, 3);
            var decimalValue = alphabet.IndexOf(digitin13);
            decimalPresentation *= 13;
            decimalPresentation += decimalValue;

        }
        Console.WriteLine(decimalPresentation);
    }
}
