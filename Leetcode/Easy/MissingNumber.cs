using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class MissingNumber
    {
        public static int GetMissingNumber(int[] nums)
        {
            return nums.Length * (nums.Length + 1) / 2 - nums.Sum(x => x);
        }

        public static int GetMissingNumberOptimized(int[] nums)
        {
            var array = new int[nums.Length + 1];
            foreach (var num in nums)
            {
                array[num]++;
            }
            return Array.IndexOf(array, 0);
        }


        public static int GetMissingNumberOptimized1(int[] nums)
        {
            int missingNumber = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                missingNumber ^= i ^ nums[i];
            }
            return missingNumber;
        }
    }
}
