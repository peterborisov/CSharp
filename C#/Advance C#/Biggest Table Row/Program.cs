using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class BiggestTableRow
{
    static void Main()
    {
//        <table>
//<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>
//<tr><td>Sofia</td><td>26.2</td><td>8.20</td><td>-</td></tr>
//<tr><td>Varna</td><td>11.2</td><td>18.00</td><td>36.10</td></tr>
//<tr><td>Plovdiv</td><td>17.2</td><td>12.3</td><td>6.4</td></tr>
//<tr><td>Bourgas</td><td>-</td><td>24.3</td><td>-</td></tr>
//</table>


        string input = Console.ReadLine();
        input = Console.ReadLine();
        var regex = new Regex(@"(-?[0-9\.]+)");
        double sum = double.MinValue;
        double maxSum = double.MinValue;
        var list = new List<string>();
        var maxList = new List<string>();
        while (input != "</table>")
        {
            var matches = regex.Matches(input);
            if (matches.Count == 0)
            {
                sum = double.MinValue;
            }
            foreach (Match match in matches)
            {
                sum += Convert.ToDouble(match.ToString());
                list.Add(match.ToString());
            }
            input = Console.ReadLine();
            if (sum > maxSum)
            {
                maxSum = sum;
                maxList = list.ToList();
            }
            sum = 0;
            list.Clear();
        }

        if (maxList.Count == 0)
        {
            Console.WriteLine("no data");
        }
        else
        {
            Console.Write("{0} = ", maxSum);
            Console.WriteLine(string.Join(" + ", maxList));
        }
    }
}