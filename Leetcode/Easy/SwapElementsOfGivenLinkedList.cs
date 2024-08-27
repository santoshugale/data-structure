using System;
using Leetcode.Leetcode;

namespace Leetcode.Easy
{
    public class SwapElementsOfGivenLinkedList
    {
        public static void Swap(ListNode head)
        {
            while (head != null && head.Next != null)
            {
                var tempdata = head.Data;
                head.Data = head.Next.Data;
                head.Next.Data = tempdata;
                head = head.Next.Next;
            }
        }

        public static void Print(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.Data + " ");
                head = head.Next;
            }
            Console.WriteLine();
        }
    }
}
