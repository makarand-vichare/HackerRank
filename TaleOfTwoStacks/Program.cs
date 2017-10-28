using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static Stack<string> pushQueue = new Stack<string>();
    static Stack<string> popQueue = new Stack<string>();

    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        var input = Console.ReadLine();
        var totalCommands = 0;
        var commandCount = 0;
        var printList = new List<string>();

        var commandList = new List<int> { (int)CommandType.Queue, (int)CommandType.Dequeue, (int)CommandType.Print };
        if (int.TryParse(input, out totalCommands))
        {

            while (totalCommands > commandCount)
            {
                var validCommand = false;
                while (!validCommand)
                {
                    var inputCommand = Console.ReadLine();
                    var inputs = inputCommand.Split(' ');
                    int command = 0;
                    var result = int.TryParse(inputs[0], out command);
                    if (result && commandList.Contains(command))
                    {
                        validCommand = true;
                        commandCount++;

                        if (!string.IsNullOrWhiteSpace(inputs[0]))
                        {
                            switch (command)
                            {
                                case (int)CommandType.Queue:
                                {
                                    Queue(inputs[1]);
                                     break;
                                }
                                case (int)CommandType.Dequeue:
                                {
                                    Dequeue();
                                    break;
                                }
                                case (int)CommandType.Print:
                                {
                                    printList.Add(DequeuePeek());
                                    break;
                                }
                            }
                        }
                        else
                        {
                           // Console.WriteLine("Invalid Value");
                        }
                    }
                    else
                    {
                        //Console.WriteLine("Invalid Command");
                    }
                }
            }
        }
        else
        {
           // Console.WriteLine("Invalid Input");
        }

        foreach(var item in printList)
        {
            Console.WriteLine(item);
        }

       // Console.ReadLine();
    }

    static void Queue(string value)
    {
        pushQueue.Push(value);
    }

    static string Dequeue()
    {
        if (popQueue.Count <= 0)
        {
            while (pushQueue.Count > 0)
            {
                var item = pushQueue.Pop();
                popQueue.Push(item);
            }
        }
        return popQueue.Count > 0 ? popQueue.Pop() : string.Empty;
    }

    static string DequeuePeek()
    {
        if (popQueue.Count <= 0)
        {
            while (pushQueue.Count > 0)
            {
                var item = pushQueue.Pop();
                popQueue.Push(item);
            }
        }
        return popQueue.Count > 0 ? popQueue.Peek() : string.Empty;
    }

    enum CommandType
    {
        Queue = 1,
        Dequeue = 2,
        Print = 3
    }
}