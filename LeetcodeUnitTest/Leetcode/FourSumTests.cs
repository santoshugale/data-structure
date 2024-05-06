using Xunit;
using Leetcode;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LeetCodeUnitTest
{
    public class FourSumTest
    {
        [Fact]
        public void BruteForce_Success()
        {
            var result = FourSum.BruteForce(new List<int> { 1, 0, -1, 0, -2, 2 }, 0);

            Assert.Equal(3, result.Count());
        }

        [Fact]
        public void BruteForce_EmptyList()
        {
            var result = ThreeSum.BruteForce(new List<int> { });
            Assert.Empty(result);
        }

        [Fact]
        public void AA()
        {
            var a = DivisibleSumPairs.pageCount(6,5);

        }
    }
}
