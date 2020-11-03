using System;
using static PathSum.Program.BST;

namespace PathSum
{
    class Program
    {
        public static int Currentsum = 0;
        public static Node root;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BST bST = new BST();
            root = new Node(3);
            root.left = new Node(9);
            root.right = new Node(20);
            root.right.left = new Node(15);
            root.right.right = new Node(7);
            Console.WriteLine(bST.HasPathSum(root, 30));
            Console.ReadLine();
        }
        public class BST
        {
            public class Node
            {
                public int key;
                public Node left;
                public Node right;

                public Node()
                {
                }

                public Node(int item)
                {
                    key = item;
                    left = null;
                    right = null;
                }


            }

            public BST()
            {
                root = null;
            }
            public bool HasPathSum(Node root, int sum)
            {
               if(root ==null)
                {
                    return false;
                }
               else if(root.left == null && root.right == null && sum-root.key==0)
                {
                    return true;
                }
               else
                {
                    return HasPathSum(root.left, sum - root.key) || HasPathSum(root.right, sum - root.key);
                }
            }
           


        }
    }
}
