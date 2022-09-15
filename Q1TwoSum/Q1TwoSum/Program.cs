using System;
using System.Collections.Generic;

namespace Q1TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            int complement;
            for (var i = 0; i < nums.Length; i++)
            {
                complement = target - nums[i];
                if (dictionary.ContainsKey(complement))
                    return new int[2] { dictionary[complement], i };
                dictionary[nums[i]] = i;
            }
            throw new Exception("No matching elements that adds up to the target");
        }
    }
}
