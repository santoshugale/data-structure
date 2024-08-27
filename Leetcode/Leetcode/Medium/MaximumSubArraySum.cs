using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode.Medium
{
    // Given an array arr[] of size N.
    // The task is to find the sum of the contiguous subarray within a arr[] with the largest sum.
    // Kadane’s Algorithm
    public class MaximumSubArraySum
    {
        public static (int, int, int) MaxiMumSubArraySumBruteForce(int[] array)
        {
            int max_so_far = int.MinValue, max_ending_here = 0, start = 0, end = 0, tempStart = 0;
            for (int index = 0; index < array.Length; index++)
            {
                max_ending_here = max_ending_here + array[index];
                if (max_ending_here > max_so_far)
                {
                    max_so_far = max_ending_here;
                    start = tempStart;
                    end = index;
                }
                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    tempStart = index + 1;
                }
            }
            return (max_so_far, start, end);
        }
    }
}
