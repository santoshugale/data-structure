using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class NearbyDuplicate
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    var indexes = dict[nums[i]];
                    for (int i1 = 0; i1 < indexes.Count; i1++)
                    {
                        if (Math.Abs(i - indexes[i1]) <= k)
                            return true;
                    }
                    dict[nums[i]].Add(i);
                }
                else
                {
                    dict[nums[i]] = new List<int>() { i };
                }
            }
            return false;
        }
    }
}
