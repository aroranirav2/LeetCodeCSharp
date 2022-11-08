using System;

namespace Q21MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = CreateList();
            var list2 = CreateList();
            var mergedList = Merge(list1, list2);
        }

        public static ListNode Merge(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            ListNode list = new ListNode(), current = list;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
            if (list1 != null)
                current.next = list1;
            if (list2 != null)
                current.next = list2;
            return list.next;
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
    }

    internal class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
