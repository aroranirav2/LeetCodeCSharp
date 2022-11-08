using System;
using System.Text;

namespace Q1544MakeTheStringGreat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeGood("leEeetcode"));
        }

        public static string MakeGood(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (Math.Abs(s[i] - s[i + 1]) == 32)
                    return MakeGood(s.Substring(0, i) + s.Substring(i + 2));
            }
            return s;
        }
    }
}
