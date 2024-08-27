using Leetcode.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    // The problem asks for the number of distinct ways to climb to the top of a staircase with n steps.
    // Each time you can either climb 1 or 2 steps. The code uses a dynamic programming approach to efficiently solve the problem.

    // Note
    // This is actually the expression for Fibonacci numbers,
    // but there is one thing to notice, the value of ways(n) is equal to fibonacci(n+1). 
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
