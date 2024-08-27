using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Leetcode;

namespace Leetcode.Easy
{
    public class MiddleOfTheLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            var slowP = head;
            var fastP = head;
            while (fastP != null && fastP.Next != null)
            {
                slowP = slowP.Next;
                fastP = fastP.Next.Next;
            }
            return slowP;
        }
    }
}
