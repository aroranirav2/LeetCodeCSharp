using System;
using System.Collections.Generic;

namespace Q217ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                if (set.Contains(num))
                    return true;
                set.Add(num);
            }
            return false;
        }
    }
}
