using System;

namespace Leetcode
{
    /// <summary>
    /// In BST left element is smaller and right element is greater that root
    /// </summary>
    public class BinarySearchTree
    {
        public BSTNode Root { get; set; }

        public void Insert(int data)
        {
            Root = InsertRecursively(Root, data);
        }

        private BSTNode InsertRecursively(BSTNode root, int data)
        {
            if (root == null)
            {
                root = new BSTNode(data);
                return root;
            }

            if (data < root.Data)
                root.Left = InsertRecursively(root.Left, data);
            else if (data > root.Data)
                root.Right = InsertRecursively(root.Right, data);
            return root;
        }

        public void InsertUsingLoop(int dada)
        {
            var node = new BSTNode(dada);
            if (Root == null)
            {
                Root = node;
                return;
            }
            BSTNode prev = null;
            BSTNode temp = Root;
            while (temp != null)
            {
                if (temp.Data > dada)
                {
                    prev = temp;
                    temp = temp.Left;
                }
                else if (temp.Data < dada)
                {
                    prev = temp;
                    temp = temp.Right;
                }
            }
            if (prev.Data > dada)
                prev.Left = node;
            else prev.Right = node;
        }

        public static void PrintPostOrder(BSTNode root)
        {
            if (root == null) return;
            PrintPostOrder(root.Left); // recur to left
            PrintPostOrder(root.Right); // recur to right
            Console.Write($"{root.Data} "); // print data of the node
        }

        public static void PrintPreOrder(BSTNode root)
        {
            if (root == null) return;
            Console.Write($"{root.Data} "); // print data of the node
            PrintPreOrder(root.Left); // recur to left
            PrintPreOrder(root.Right); // recur to right
        }

        public static void PrintInOrder(BSTNode root)
        {
            if (root == null) return;
            PrintInOrder(root.Left); // recur to left
            Console.Write($"{root.Data} "); // print data of the node
            PrintInOrder(root.Right); // recur to right
        }

        public class BSTNode
        {
            public BSTNode(int data)
            {
                Data = data;
            }
            public int Data { get; set; }
            public BSTNode Left { get; set; }
            public BSTNode Right { get; set; }
        }
    }
}
