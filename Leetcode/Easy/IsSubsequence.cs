using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class IsSubsequence
    {
        public static bool IsSubsequenceUsingForLoop(string s, string t)
        {
            if (s.Length > t.Length)
            {
                return false;
            }
            int sIndex = 0, tIndex = 0;
            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                }
                tIndex++;
            }
            return sIndex == s.Length;
        }
    }
}
