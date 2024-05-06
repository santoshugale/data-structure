using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode
{
    public class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            var cache = new int[n + 1];
            return CountWays(n, cache);
        }

        static int CountWays(int n, int[] cache)
        {
            if (n <= 1)
                return cache[n] = 1;

            if (cache[n] != 0)
            {
                return cache[n];
            }
            cache[n] = CountWays(n - 1, cache) + CountWays(n - 2, cache);
            return cache[n];
        }
    }
}
