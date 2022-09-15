using System;
using System.Collections.Generic;

namespace Q20ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsValid(string s)
        {
            var parenthesesDict = new Dictionary<char, char>
            {
                {'{', '}' },
                {'(', ')' },
                {'[', ']' }
            };
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (parenthesesDict.ContainsKey(c))
                    stack.Push(parenthesesDict[c]);
                else if (stack.Count == 0 || stack.Pop() != c)
                    return false;
            }
            return stack.Count == 0;
        }
    }
}
