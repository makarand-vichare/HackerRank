using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        var expressions = new List<string>();
        for (int a0 = 0; a0 < t; a0++)
        {
            string expression = Console.ReadLine();
            expressions.Add(expression);
        }

        foreach (var expression in expressions)
        {
            Console.WriteLine(IsBalanced(expression) ? "YES" : "NO");
        }
        Console.ReadLine();
    }

    static Dictionary<char,char> LookUpList()
    {
        var lookUp = new Dictionary<char, char>();

        lookUp.Add('[', ']');
        lookUp.Add('{', '}');
        lookUp.Add('(', ')');
        lookUp.Add(']', '[');
        lookUp.Add('}', '{');
        lookUp.Add(')', '(');

        return lookUp;
    }

    static bool IsBalanced(string expression)
    {
        var stack = new Stack<char>();
        var lookUp = LookUpList();
        var result = false;
        for(int i = 0; i < expression.Length;i++)
        {
            var chr = expression[i];

            if(stack.Count>0)
            {
                var lastChr = stack.Peek();
                if(lookUp[lastChr] == chr)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(chr);
                }
            }
            else
            {
                stack.Push(chr);
            }
        }

        if(stack.Count == 0)
        {
            result = true;
        }

        return result;
    }
}
