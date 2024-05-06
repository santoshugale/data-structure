using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode
{
    public class NearbyAlmostDuplicate
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
        {
            int n = nums.Length;
            if (n <= 1) return false;
            if (valueDiff < 0) return false;

            // take care when t == 0
            long width = (long)valueDiff + 1;

            var map = new Dictionary<long, long>();
            for (int i = 0; i < n; i++)
            {
                long bucketId = getBucketId((long)nums[i], width);
                if (map.ContainsKey(bucketId))
                {
                    return true;
                }
                if (map.ContainsKey(bucketId - 1l) && Math.Abs(map[bucketId - 1] - nums[i]) < width)
                {
                    return true;
                }
                if (map.ContainsKey(bucketId + 1l) && Math.Abs(map[bucketId + 1] - nums[i]) < width)
                {
                    return true;
                }
                map.Add(bucketId, (long)nums[i]);
                if (i - indexDiff >= 0)
                {
                    long oldBucketId = getBucketId((long)nums[i - indexDiff], width);
                    map.Remove(oldBucketId);
                }
            }

            return false;
        }
        private long getBucketId(long val, long width)
        {
            return val < 0 ? (val + 1l) / width - 1l : val / width;
        }
    }
}
