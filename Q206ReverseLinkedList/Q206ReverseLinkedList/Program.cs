using System;

namespace Q206ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = CreateList();
            head = ReverseList(head);
        }
        public static ListNode CreateList()
        {
            Console.Write("Enter number of Nodes: ");
            int totalNumber = Convert.ToInt32(Console.ReadLine());
            if (totalNumber < 1)
            {
                Console.WriteLine("Empty list");
                return null;
            }
            ListNode start = null;
            int number;
            for (var i = 0; i < totalNumber; i++)
            {
                Console.Write("Enter number: ");
                number = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(number, ref start);
            }
            return start;
        }
        public static void InsertAtEnd(int number, ref ListNode start)
        {
            ListNode temp = new ListNode(number, null);
            if (start == null)
            { 
                start = temp;
                return;
            }
            ListNode node = start;
            while (node.next != null)
            {
                node = node.next;
            }
            node.next = temp;
        }
        public static ListNode ReverseList(ListNode head)
        {
            ListNode previous = null, next;
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
