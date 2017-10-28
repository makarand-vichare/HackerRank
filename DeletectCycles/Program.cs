using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeletectCycles
{
    class Program
    {

        public class Node
        {
            public int value;
            public Node Next;

            public Node(int value)
            {
                this.value = value;
            }
        }
        static void Main(string[] args)
        {
            Node head = null;

            head = CreateCycle(head);
            var cycleLength = HasLoop1(head);
            Console.WriteLine(cycleLength);
            Console.ReadLine();
        }

        public static Node CreateCycle(Node head)
        {
            head = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            head.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
            node6.Next = node4;

            return head;
        }

        public static int HasLoop(Node head)
        {
            Node tempNode = head;
            Node tempNode1 = head.Next;
            int cycleLength =0;
            bool startCount = false;

            while (tempNode != null && tempNode1 != null)
            {
                if (tempNode.Equals(tempNode1))
                {
                    if(cycleLength == 0)
                    {
                        startCount = true;
                    }
                    else
                    {
                        return cycleLength;
                    }
                }

                if (startCount)
                {
                    cycleLength++;
                }

                if ((tempNode1.Next != null) && (tempNode.Next != null))
                {
                    tempNode1 = tempNode1.Next.Next;
                    tempNode = tempNode.Next;
                }
                else
                {
                    return 0;
                }
            }

            return 0;
        }

        public static int HasLoop1(Node head)
        {
            Node tempNode = head;
            List<Node> tempNodeList = new List<Node>();
            int cycleLength = 0;
            bool startCount = false;

            while (tempNode != null)
            {
                if (tempNodeList.Contains(tempNode))
                {
                    if (cycleLength == 0)
                    {
                        startCount = true;
                    }
                    else
                    {
                        return cycleLength;
                    }
                }
                else
                {
                    tempNodeList.Add(tempNode);
                }

                if (startCount)
                {
                    cycleLength++;
                }

                if (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                else
                {
                    return 0;
                }
            }

            return 0;
        }

    }
}
