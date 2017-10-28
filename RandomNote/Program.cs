using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] magazine = Console.ReadLine().Split(' ');
        string[] ransom = Console.ReadLine().Split(' ');
        var result = RansomeNoteCreated(magazine, ransom, m, n);
        Console.WriteLine((result) ? "Yes" : "No");
    }

    public static bool RansomeNoteCreated(string[] magazine, string[] ransom, int magazineCount , int ransomNoteCount)
    {
        var result = true;
        if(magazine.Count() > magazineCount || ransom.Count() > ransomNoteCount)
        {
            result = false;
            return result;
        }

        Hashtable hashSet1 = new Hashtable();
        foreach (string noteWord in magazine)
        {
            if (hashSet1.ContainsKey(noteWord.ToLower()))
            {
                hashSet1[noteWord.ToLower()] = Convert.ToInt32(hashSet1[noteWord.ToLower()]) + 1;
            }
            else
            {
                hashSet1.Add(noteWord.ToLower(), 1);
            }
        }

        foreach (string ransomNote in ransom)
        {
            if (hashSet1.ContainsKey(ransomNote.ToLower()) && Convert.ToInt32(hashSet1[ransomNote.ToLower()]) > 0)
            {
                hashSet1[ransomNote.ToLower()] = Convert.ToInt32(hashSet1[ransomNote.ToLower()]) - 1;
            }
            else
            {
                result = false;
                return result;
            }
        }
      
        return result;
    }
}
