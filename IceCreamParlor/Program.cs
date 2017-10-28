using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            if(a.Length != n)
            {
                return;
            }
            var values = GetMatchingValues(m, a);
            var indexes = GetIndexes(a, values);
            Console.WriteLine(string.Join(" ", indexes));
        }

        Console.ReadLine();
    }

    private static int[] GetIndexes(int[] a, List<int> values)
    {
        var result = new List<int>();
        foreach (var val in values)
        {
            for (int index = 1; index <= a.Length; index++)
            {
                if(val == a[index-1] && !result.Contains(index))
                {
                    result.Add(index);
                }
            }
        }

        if(result.Count==1)
        {
            result.Add(result[0]);
        }

        return result.OrderBy(o => o).ToArray() ;
    }

    private static List<int> GetMatchingValues(int m, int[] a)
    {
        int[] clone = ((int[])a.Clone());
        var result = new List<int>();
        Array.Sort(clone);
        var otherIndex = 0;
        for (int index = 0; index < clone.Length; index++)
        {
            var remaining = m - clone[index];
            result.Add(clone[index]);

            if (remaining > 0 && clone.Contains(remaining))
            {
                otherIndex = Array.BinarySearch(clone, index +1, clone.Length-1, remaining);
                if (otherIndex >= 0 && otherIndex < clone.Length && clone[otherIndex] == remaining)
                {
                    result.Add(clone[otherIndex]);
                    break;
                }
            }          
        }

        return result;
    }
}
