using System;

namespace Leetcode.DynamicProgramming
{
    public class Knapsack
    {
        public static int Knapsack_0_1(int[] profit, int[] weights, int capacity, int n)
        {
            if (n == 0 || capacity == 0) return 0;
            if (weights[n - 1] > capacity)
            {
                return Knapsack_0_1(profit, weights, capacity, n - 1);
            }
            else
            {
                return Math.Max(Knapsack_0_1(profit, weights, capacity - profit[n - 1], n - 1), Knapsack_0_1(profit, weights, capacity, n - 1));
            }

        }
    }
}
