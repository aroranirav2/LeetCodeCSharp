using System;
using System.Collections.Generic;

namespace Q234PalindromeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            Console.WriteLine(IsPalindrome(list));
            Console.WriteLine(IsPalindrome1(list));
        }

        public static bool IsPalindrome(ListNode head)
        {
            List<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            int left = 0, right = list.Count - 1;

            while(left < right)
            {
                if (list[left] != list[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
        //O(n) and O(1)
        public static bool IsPalindrome1(ListNode head)
        {
            ListNode node = head, fastNode = head;
            //Node will be at the middle point (roughly)
            while(fastNode != null && fastNode.next != null)
            {
                node = node.next;
                fastNode = fastNode.next.next;
            }
            ListNode previous = null, temp;
            while(node != null)
            {
                temp = node.next;
                node.next = previous;
                previous = node;
                node = temp;
            }
            ListNode left = head, right = previous;
            while(right != null)
            {
                if (left.val != right.val)
                    return false;
                left = left.next;
                right = right.next;
            }
            return true;
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

    public class ListNode
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
