using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Leetcode;

namespace Leetcode.Easy
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            // find the middle point
            // reverse till the middle 
            // check the palindrome
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            // reverse the second half of the linked list
            ListNode prev = null;
            ListNode curr = slow;
            ListNode next = null;

            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }

            // compare the first half and the reversed second half
            ListNode firstHalf = head;
            ListNode secondHalf = prev;

            while (secondHalf != null)
            {
                if (firstHalf.Data != secondHalf.Data)
                {
                    return false;
                }

                firstHalf = firstHalf.Next;
                secondHalf = secondHalf.Next;
            }

            return true;
        }
    }
}
