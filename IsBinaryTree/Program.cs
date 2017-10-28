using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var leftNode = new Node(2);
            leftNode.left = new Node(1);
            leftNode.right = new Node(3);

            var rightNode = new Node(6);
            rightNode.left = new Node(5);
            rightNode.right = new Node(7);

            var binaryRoot = new Node(4);
            binaryRoot.left = leftNode;
            binaryRoot.right = rightNode;

            var isbinaryT = checkBST(binaryRoot);
            Console.WriteLine(isbinaryT);
            Console.ReadLine();
        }

        public static bool checkBST(Node root)
        {
            return isValidBST(root, Int32.MinValue, Int32.MaxValue);
        }

        private static bool isValidBST(Node node, int min, int max)
        {
            if (node == null)
                return true;
            if(node.data < min && node.data > max)
            {
                return false;
            }
            return isValidBST(node.left, min, node.data)
                && isValidBST(node.right, node.data, max);
        }

    }

    public class Node
    {
        public Node left { get; set; }
        public Node right { get; set; }
        public int data { get; set; }

        public Node(int data)
        {
            this.data = data;
        }
    }
}
