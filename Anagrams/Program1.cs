using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution1
{

    static void Main(String[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        var count1 = getCharCount(a);
        var count2 = getCharCount(b);
        var result = RemovedCharCount(count1, count2);
        Console.WriteLine(result);
    }

    static int[] getCharCount(string word)
    {
        var charCount = new int[26];
        foreach(char wordChar in word)
        {
            var index = Convert.ToInt32(wordChar) - Convert.ToInt32('a');
            charCount[index] = charCount[index] + 1;
        }

        return charCount;
    }

    static int RemovedCharCount(int[] count1, int[] count2)
    {
        int result = 0;
        for (int index = 0; index<count1.Length;index++)
        {
            int diff = Math.Abs(count1[index] - count2[index]);
            result = result + diff;
        }

        return result;
    }
}
