using System;

namespace Q88MergeSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Merge1(new int[] { 2, 0 }, 1, new int[] { 1 }, 1);
            Merge(new int[] { 2, 0 }, 1, new int[] { 1 }, 1);

        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (var i = n - 1; i >= 0; i--)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);
        }
        public static void Merge1(int[] nums1, int m, int[] nums2, int n)
        {
            int l1 = 0, l2 = 0, length = m + n;
            int[] nums3 = new int[length];
            if (n != 0)
            {
                for (int i = 0; i < length; i++)
                {
                    if ((l2 >= n) || (l1 < m && nums1[l1] <= nums2[l2]))
                    {
                        nums3[i] = nums1[l1];
                        l1++;
                    }
                    else
                    {
                        nums3[i] = nums2[l2];
                        l2++;
                    }
                }
                for (int i = 0; i < nums3.Length; i++)
                {
                    nums1[i] = nums3[i];
                }
            }
        }
    }
}
