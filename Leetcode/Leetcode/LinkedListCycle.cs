using Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode
{
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            var slowPointer = head;
            var fastPointer = head;
            while (slowPointer != null && fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
                if (slowPointer == fastPointer)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
