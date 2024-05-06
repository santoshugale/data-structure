using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode
{
    public class MiddleOfTheLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            var slowP = head;
            var fastP = head;
            while (fastP != null && fastP.next != null)
            {
                slowP = slowP.next;
                fastP = fastP.next.next;
            }
            return slowP;
        }
    }
}
