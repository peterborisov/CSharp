using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var words = new List<string>();
        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            var word = words[i];
            var newindex = word.Length % (n + 1);
            words.Insert(newindex, word);
            if (newindex < i)
            {
                words.RemoveAt(i+1);
            }
            else
            {
                words.RemoveAt(i);
            }
        }
        var maxlength = 0;
        foreach (var word in words)
        {
            maxlength = Math.Max(maxlength, word.Length);
        }
        var result = new StringBuilder();
        for (int i = 0; i < maxlength; i++)
        {
            foreach (var word in words)
            {
                if (word.Length > 1)
                {
                    result.Append(word[i]);
                }

            }
        }
        Console.WriteLine(result.ToString());
    }
}

