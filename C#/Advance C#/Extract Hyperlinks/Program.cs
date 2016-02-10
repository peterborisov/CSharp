using System;
using System.Text;
using System.Text.RegularExpressions;

public class ExtractHyperlinks
{
    public static void Main()
    {
        //<a href="http://softuni.bg" class="new"></a>      //http://softuni.bg
//END



        StringBuilder html = new StringBuilder();

        string input = Console.ReadLine();

        while (input != "END")
        {
            html.AppendLine(input);
            input = Console.ReadLine();
        }

        const string pattern = @"<\s*a\s+(?:[^<>]*\s+)?href\s*=\s*(?:(?:'([^'>]+)')|(?:""([^"">]+)"")|([^\s>]+))[^>]*>";

        var matches = Regex.Matches(html.ToString(), pattern);

        foreach (Match match in matches)
        {
            if (match.Groups[1].ToString() != string.Empty)
            {
                Console.WriteLine(match.Groups[1].ToString());
            }
            else if (match.Groups[2].ToString() != string.Empty)
            {
                Console.WriteLine(match.Groups[2].ToString());
            }
            else if (match.Groups[3].ToString() != string.Empty)
            {
                Console.WriteLine(match.Groups[3].ToString());
            }
        }
    }
}