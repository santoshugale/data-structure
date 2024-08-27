using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class CheckIfSumPossibleInArray
    {
        public static bool IsSumPossible(int[] arr, int sum)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var item in arr)
            {
                if (set.Contains(sum - item))
                    return true;
                set.Add(item);
            }
            return false;
        }

        public static bool IsSumPossibleBruteForce(int[] arr, int sum)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sum)
                        return true;
                }
            }
            return false;
        }
    }
}
