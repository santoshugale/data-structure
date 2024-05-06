using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode
{
    public class ContainsDuplicate
    {
        public static bool IsContainsDuplicate(int[] nums)
        {
            var dict = new HashSet<int>();

            foreach (int n in nums)
            {
                if (!dict.Add(n))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
