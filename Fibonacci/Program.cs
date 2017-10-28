using System;
using System.Collections.Generic;
using System.IO;

class Solution
{

    public static int Fibonacci(int n)
    {
        if(n<=1)
        {
            return n;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
        // Write your code here.
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fibonacci(n));
    }
}
