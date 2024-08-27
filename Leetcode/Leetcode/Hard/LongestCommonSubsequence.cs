using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode.Hard
{
    public class LongestCommonSubsequence
    {
        // https://leetcode.com/problems/longest-common-subsequence/solutions/4623190/memoization-based-recursive-solution-for-lcs/
        public static int LongestCommonSubsequenceBruteForce(string string1, string string2)
        {
            if (string.IsNullOrEmpty(string1) || string.IsNullOrEmpty(string2))
                return 0;
            return LongestCommonSubsequenceBruceForceRecursive(string1, string2, string1.Length, string2.Length);
        }

        public static int LongestCommonSubsequenceMemoization(string string1, string string2)
        {
            if (string.IsNullOrEmpty(string1) || string.IsNullOrEmpty(string2))
                return 0;
            var memoizeData = new int[string1.Length + 1, string2.Length + 1];
            for (int i = 0; i <= string1.Length; i++)
            {
                for (int j = 0; j <= string2.Length; j++)
                {
                    memoizeData[i, j] = -1;
                }
            }
            return LongestCommonSubsequenceMemoizationRecursive(string1, string2, memoizeData, string1.Length, string2.Length);
        }

        private static int LongestCommonSubsequenceBruceForceRecursive(string string1, string string2, int string1Length, int string2Length)
        {
            if (string1Length == 0 || string2Length == 0) return 0;
            if (string1[string1Length - 1] == string2[string2Length - 1])
            {
                return 1 + LongestCommonSubsequenceBruceForceRecursive(string1, string2, string1Length - 1, string2Length - 1);
            }
            return Math.Max(LongestCommonSubsequenceBruceForceRecursive(string1, string2, string1Length - 1, string2Length),
                LongestCommonSubsequenceBruceForceRecursive(string1, string2, string1Length, string2Length - 1));
        }

        private static int LongestCommonSubsequenceMemoizationRecursive(string string1, string string2, int[,] memoizeData, int string1Length, int string2Length)
        {
            if (string1Length == 0 || string2Length == 0) return 0;
            if (memoizeData[string1Length, string2Length] != -1)
            {
                return memoizeData[string1Length, string2Length];
            }
            if (string1[string1Length - 1] == string2[string2Length - 1])
            {
                memoizeData[string1Length, string2Length] = 1 + LongestCommonSubsequenceMemoizationRecursive(string1, string2, memoizeData, string1Length - 1, string2Length - 1);
                return memoizeData[string1Length, string2Length];
            }
            memoizeData[string1Length, string2Length] = Math.Max(LongestCommonSubsequenceMemoizationRecursive(string1, string2, memoizeData, string1Length - 1, string2Length),
                LongestCommonSubsequenceMemoizationRecursive(string1, string2, memoizeData, string1Length, string2Length - 1));
            return memoizeData[string1Length, string2Length];
        }
    }
}
