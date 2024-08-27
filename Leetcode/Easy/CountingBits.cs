using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class CountingBits
    {
        public static int[] CountBits(int n)
        {
            var result = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                result[i] = result[i >> 1] + (i & 1);
            }
            return result;
        }

        public int[] CountBitsUsingOperator(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                // every number have the number of 1 bites of previous number + 1
                result[i] = result[i & i - 1] + 1;
            }

            return result;
        }
    }
}
