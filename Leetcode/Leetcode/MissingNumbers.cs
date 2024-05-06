using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode
{
    public class MissingNumbers
    {

        public static List<int> GetAllMissingNumbers(int[] nums)
        {
            var array = new int[nums.Length + 1];
            foreach (var num in nums)
            {
                array[num]++;
            }
            var result = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0) result.Add(i);
            }
            return result;
        }

        public static List<int> GetAllMissingNumbers1(int[] nums)
        {
            var result = new List<int>();
            foreach (var num in nums)
            {
                var abs = Math.Abs(num) - 1;
                nums[abs] = -Math.Abs(nums[abs]);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    result.Add(i + 1);
            }
            return result;
        }
    }
}
