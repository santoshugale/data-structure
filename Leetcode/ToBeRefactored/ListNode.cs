namespace Leetcode.Leetcode
{
    public class ListNode
    {
        public int Data { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int data, ListNode next = null)
        {
            Data = data;
            Next = next;
        }
    }
}
