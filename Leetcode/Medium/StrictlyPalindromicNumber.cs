using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Medium
{
    internal class StrictlyPalindromicNumber
    {
        public bool IsStrictlyPalindromic(int n)
        {
            for (var i = 2; i < n - 2; i++)
            {
                var binary = ToBase(n, i);
                var end = binary.Length - 1;
                for (var j = 0; j < end; j++, end--)
                {
                    if (binary[j] != binary[end])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int[] ToBase(int n, int base1)
        {
            int remaining = n;
            List<int> digits = new List<int>();
            while (remaining > 0)
            {
                digits.Add(remaining % base1);
                remaining = remaining / base1;
            }
            return digits.ToArray();
        }
    }
}
