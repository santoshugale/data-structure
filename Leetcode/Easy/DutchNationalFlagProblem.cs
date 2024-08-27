using System.Collections.Generic;

namespace Leetcode.Easy
{
    /// <summary>
    /// The functions should put all 0s first, then all 1s and all 2s in last.
    /// </summary>
    public class DutchNationalFlagProblem
    {
        /// <summary>
        /// Time complexity O(n) - one traversal
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IEnumerable<int> SortBySwapping(List<int> list)
        {
            var low = 0;
            var mid = 0;
            var high = list.Count - 1;
            while (mid <= high)
            {
                if (list[mid] == 0)
                {
                    Swap(list, low, mid);
                    low++;
                    mid++;
                }
                if (list[mid] == 1)
                {
                    mid++;
                    continue;
                }
                if (list[mid] == 2)
                {
                    Swap(list, mid, high);
                    high--;
                }
            }

            return list;
        }

        /// <summary>
        /// 2 traversal will required - O(2n) and 2 constant it will be O(n)
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IEnumerable<int> SortByCounting(List<int> list)
        {
            var countOfZero = 0;
            var countOfOne = 0;
            var countOfTwo = 0;

            foreach (int item in list)
            {
                if (item == 0) countOfZero++;
                else if (item == 1) countOfOne++;
                else countOfTwo++;
            }

            int i = 0;
            while (countOfZero > 0)
            {
                list[i++] = 0;
                countOfZero--;
            }
            while (countOfOne > 0)
            {
                list[i++] = 1;
                countOfOne--;
            }
            while (countOfTwo > 0)
            {
                list[i++] = 2;
                countOfTwo--;
            }
            return list;
        }

        private static void Swap(List<int> list, int first, int second)
        {
            var temp = list[first];
            list[first] = list[second];
            list[second] = temp;
        }
    }
}
