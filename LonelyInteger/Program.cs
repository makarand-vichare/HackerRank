using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        if(n != a.Length)
        {
            return;
        }

        //Method 1
        int result = 0;
        foreach(var item in a)
        {
            result ^= item;
        }

        Console.WriteLine(result);

        //Method 2

        var filtered = a.ToList().GroupBy(o => o).Select(o => new { key = o.Key, count = o.Count() }).Where(o => o.count == 1);

        foreach (var item in filtered.ToList())
        {
            Console.WriteLine(item.key);
        }
    }
}
