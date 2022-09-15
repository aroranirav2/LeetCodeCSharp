using System;
using System.Collections.Generic;

namespace Q242ValidAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var sArray = s.ToCharArray();
            var tArray = t.ToCharArray();
            Array.Sort(sArray);
            Array.Sort(tArray);
            for (var i = 0; i <= sArray.Length; i++)
            {
                if (sArray[i] != tArray[i])
                    return false;
            }
            return true;
        }

        //public static bool IsAnagram1(string s, string t)
        //{
        //    if (s.Length != t.Length)
        //        return false;

        //    var sDictionary = new Dictionary<char, int>();
        //    var tDictionary = new Dictionary<char, int>();

        //    foreach (char c in s)
        //    {
        //        if (sDictionary.ContainsKey(c))
        //        {
        //            sDictionary[c]++;
        //            continue;
        //        }
        //        sDictionary[c] = 1;
        //    }
        //    foreach (char c in t)
        //    {
        //        if (tDictionary.ContainsKey(c))
        //        {
        //            tDictionary[c]++;
        //            continue;
        //        }
        //        tDictionary[c]++;
        //    }

        //}
    }
}
