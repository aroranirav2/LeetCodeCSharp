using System;
using System.Collections.Generic;

namespace Q75SortColors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SortColors(new int[] { 2, 0, 2, 1, 1, 0 });
            SortColors1(new int[] { 2, 0, 2, 1, 1, 0 });
        }
        //bubble sort technique
        static void SortColors1(int[] nums)
        {
            int length = nums.Length, temp;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }
        //more time efficient
        static void SortColors(int[] nums)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>
            {
                {'r', 0 },
                {'w', 0 },
                {'b', 0 }
            };

            foreach (var num in nums)
            {
                if (num == 0)
                    dict['r']++;
                else if (num == 1)
                    dict['w']++;
                else if (num == 2)
                    dict['b']++;
                else
                    throw new Exception("Invalid number");
            }
            int i = 0;
            while (i < dict['r'])
            {
                nums[i] = 0;
                i++;
            }
            while (i - dict['r'] < dict['w'])
            {
                nums[i] = 1;
                i++;
            }
            while (i - (dict['r'] + dict['w']) < dict['b'])
            {
                nums[i] = 2;
                i++;
            }
        }
    }
}
