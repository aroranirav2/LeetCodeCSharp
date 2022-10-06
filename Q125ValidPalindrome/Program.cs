using System;

namespace Q125ValidPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        }
        public static bool IsPalindrome(string s)
        {
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                if (!char.IsLetterOrDigit(s[l]))
                {
                    l++;
                    continue;
                }
                if (!char.IsLetterOrDigit(s[r]))
                {
                    r--;
                    continue;
                }
                if (char.ToLowerInvariant(s[l]) != char.ToLowerInvariant(s[r]))
                    return false;
                l++;
                r--;
            }
            return true;
        }
    }
}
