using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class Solution
{
    static int MaxPad = 20;

    public static void Main(String[] args)
    {
        string a = string.Empty;
        string b = string.Empty;

        a = Console.ReadLine().ToLower();
        b = Console.ReadLine().ToLower();
        b = Anagram(a, b);

        /// Test Code

        //var testData = new List<(string, string, int)>();
        //testData.Add(("c", "abc", 2));
        //testData.Add(("cde", "abc", 4));
        //testData.Add(("cdeqq", "cde", 2));
        //testData.Add(("qqq", "aqb", 4));
        //testData.Add(("qqq", "bbbbb", 8));
        //testData.Add(("qqqqqq", "bb", 8));
        //testData.Add(("qqq", "", 3));
        //testData.Add(("", "qqq", 3));
        //testData.Add(("", "", 0));
        //testData.Add(("mak", "kam", 0));
        //testData.Add(("mak a", "kam", 2));
        //testData.Add(("makarand", " mak rand vi", 6));
        //testData.Add(("maka rand", " mak rand vi", 5));
        //testData.Add(("maka makmak", " mak", 7));

        //Console.WriteLine("First".PadRight(MaxPad) + " " + "Second".PadRight(MaxPad) + "  Actual  Expected  Succeed?");

        //foreach (var testItem in testData)
        //{
        //    b = Anagram(testItem.Item1, testItem.Item2, testItem.Item3);
        //}

        //Console.ReadLine();
        // Test code ends
    }

    private static string Anagram(string a, string b, int? expected = null)
    {

        if (expected != null)
        {
            Console.Write(a.PadRight(MaxPad) + " " + b.PadRight(MaxPad) + "   ");
        }

        var chars = new List<char>();
        var originalLength = b.Length;
        for (var index = 0; index < a.Length; index++)
        {
            var bIndex = b.IndexOf(a[index], index);
            if ((index >= b.Length) || (a[index] != b[index] && (bIndex < 0 || bIndex < index)))
            {
                b = b.Insert(index, "-");
                chars.Add(a[index]);
            }
            else if (a[index] != b[index] && bIndex > index)
            {
                var unmatchedChar = b[index];
                var matchedChar = b[bIndex];
                b = b.Remove(index, 1);
                b = b.Insert(index, matchedChar.ToString());
                b = b.Remove(bIndex, 1);
                b = b.Insert(bIndex, unmatchedChar.ToString());
            }
        }

        if (a.Length != b.Length)
        {
            var unMatchChars = b.Remove(0, a.Length);
            chars.AddRange(unMatchChars);
        }
        if (expected != null)
        {
            Console.WriteLine(chars.Count + "         " + expected + "      " + (chars.Count == expected));
        }
        else
        {
            Console.WriteLine(chars.Count);
        }
        return b;
    }
}
