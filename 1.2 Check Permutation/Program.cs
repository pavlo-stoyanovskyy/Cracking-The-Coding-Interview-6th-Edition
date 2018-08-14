using System;
using System.Collections.Generic;

namespace _1._2_Check_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = Permutation("apple", "papel");
        }

        static bool Permutation(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var d = new Dictionary<char, int>();

            foreach (var c in s)
            {
                if (d.ContainsKey(c))
                    d[c]++;
                else
                    d[c] = 1;
            }

            foreach (var c in t)
            {
                d[c]--;
                if (d[c] < 0) {
                    return false;
                }
            }

            return true;
        }
    }
}
