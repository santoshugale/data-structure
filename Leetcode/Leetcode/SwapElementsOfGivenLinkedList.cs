using System;

namespace Leetcode
{
    public class SwapElementsOfGivenLinkedList
    {
        public static void Swap<T>(Node<T> head)
        {
            while (head != null && head.Next != null)
            {
                var tempdata = head.Data;
                head.Data = head.Next.Data;
                head.Next.Data = tempdata;
                head = head.Next.Next;
            }
        }

        public static void Print<T>(Node<T> head)
        {
            while (head != null)
            {
                Console.Write(head.Data + " ");
                head = head.Next;
            }
            Console.WriteLine();
        }
    }

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data, Node<T> next = null)
        {
            Data = data;
            Next = next;
        }
    }
}
