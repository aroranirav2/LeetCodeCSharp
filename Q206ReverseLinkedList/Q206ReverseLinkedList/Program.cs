using System;

namespace Q206ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static ListNode ReverseList(ListNode head)
        {
            ListNode? previous = null, next;
            while (head != null)
            {
                next = head.next;
                head.next = previous;
                previous = head;
                head = next;
            }
            return previous;
        }
    }
}
