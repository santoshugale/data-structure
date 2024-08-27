using Leetcode.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetcodeUnitTest.Medium
{
    public class MaximumSubArraySumTests
    {
        [Fact]
        public void TestMaxiMumSubArraySumBruteForce()
        {
            int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            (int, int, int) result = MaximumSubArraySum.MaxiMumSubArraySumBruteForce(array);
            Assert.Equal((6, 3, 6), result);
        }
    }
}
