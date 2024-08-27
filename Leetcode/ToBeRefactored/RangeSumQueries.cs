using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode
{
    internal class RangeSumQueries
    {
        private readonly int[]? preSumArray = null;
        public RangeSumQueries(int[] numbers)
        {
            preSumArray = new int[numbers.Length];
            preSumArray[0] = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                preSumArray[i] = numbers[i] + preSumArray[i - 1];
            }
        }

        public int SumRange(int left, int right)
        {
            if (left > right)
                return 0;
            if (left == 0)
            {
                return preSumArray[right];
            }
            return preSumArray[right] - preSumArray[left - 1];
        }
    }
}
