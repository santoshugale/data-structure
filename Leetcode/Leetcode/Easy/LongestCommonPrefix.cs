using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Easy
{
    public static class LongestCommonPrefix
    {
        public static string LongestCommonPrefixBruteforce(string[] strs)
        {
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 0; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[0][i] != strs[j][i])
                    {
                        return strs[0].Substring(0, i - 1);
                    }
                }
            }
            return strs[0];
        }

        
    }
}
