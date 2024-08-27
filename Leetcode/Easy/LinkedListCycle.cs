using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Leetcode;

namespace Leetcode.Easy
{
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            var slowPointer = head;
            var fastPointer = head;
            while (slowPointer != null && fastPointer != null && fastPointer.Next != null)
            {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next.Next;
                if (slowPointer == fastPointer)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
