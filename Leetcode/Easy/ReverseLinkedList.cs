using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Leetcode;

namespace Leetcode.Easy
{
    public class ReverseLinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;
            ListNode next = null;

            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
    }
}
