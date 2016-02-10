using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        const string smallArrow = ">----->";
        const string mediumArrow = ">>----->";
        const string largeArrow = ">>>----->>";

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 4; i++)
        {
            sb.AppendFormat(" {0}", Console.ReadLine());
        }
        string pattern = @"(>>>----->>)|(>>----->)|(>----->)";
        Regex arrow = new Regex(pattern);
        var arrows = arrow.Matches(sb.ToString());
        int large = 0;
        int medium = 0;
        int small = 0;
        foreach (Match i in arrows)
        {
            if (!string.IsNullOrEmpty(i.Groups[1].Value))
            {
                large++;
            }
            if (!string.IsNullOrEmpty(i.Groups[2].Value))
            {
                medium++;
            }
            if (!string.IsNullOrEmpty(i.Groups[3].Value))
            {
                small++;
            }
        }
        string resultAsString=String.Format("{0}{1}{2}",small,medium,large);
        long number = long.Parse(resultAsString);
        string binary = Convert.ToString(number, 2);
        string reversed =new string( binary.Reverse().ToArray());
        string fullDigit = binary + reversed;
        long total = Convert.ToInt32(fullDigit,2);
        Console.WriteLine(total);
    }
}

