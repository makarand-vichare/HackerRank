using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution2
{

    static void Main(String[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int a1 = 0;
        int b1 = 0;
        var original = b.Clone().ToString();
        foreach (var c in a)
        {

            if (!b.Contains(c))
            {
                a1++;
            }
            else
            {
               var index = b.IndexOf(c);
                b = b.Remove(index,1);
            }
        }

        b = original;
        foreach (var c in b)
        {
            if (!a.Contains(c))
            {
                b1++;
            }
            else
            {
                var index = a.IndexOf(c);
                a = a.Remove(index,1);
            }

        }

        Console.WriteLine(a1 + b1);
    }
}
