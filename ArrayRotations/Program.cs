using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        // int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        var list = a.ToList();
        var rotatedPart = list.GetRange(0, k);
        list.RemoveRange(0, k);
        list.AddRange(rotatedPart);

        Console.WriteLine(string.Join(" ", list));

    }
}
