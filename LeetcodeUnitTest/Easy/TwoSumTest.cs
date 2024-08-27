using Leetcode.Easy;
using Xunit;

namespace LeetcodeUnitTest.Easy
{
    public class TwoSumTest
    {
        [Fact]
        public void TwoSumBruteForceTestCase1()
        {
            var result = TwoSum.BruteForce(new int[] { 2, 7, 11, 15 }, 9);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void TwoSumBruteForceTestCase2()
        {
            var result = TwoSum.BruteForce(new int[] { 3, 2, 4 }, 6);
            Assert.Equal(new int[] { 1, 2 }, result);
        }

        [Fact]
        public void TwoSumBruteForceTestCase3()
        {
            var result = TwoSum.BruteForce(new int[] { 3, 3 }, 6);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void OptimizedSolutionTestCase1()
        {
            var result = TwoSum.OptimizedSolution(new int[] { 2, 7, 11, 15 }, 9);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void OptimizedSolutionTestCase2()
        {
            var result = TwoSum.OptimizedSolution(new int[] { 3, 2, 4 }, 6);
            Assert.Equal(new int[] { 1, 2 }, result);
        }

        [Fact]
        public void OptimizedSolutionTestCase3()
        {
            var result = TwoSum.OptimizedSolution(new int[] { 3, 3 }, 6);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void UsingSortTestCase1()
        {
            var result = TwoSum.UsingSort(new int[] { 2, 7, 11, 15 }, 9);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void UsingSortTestCase2()
        {
            var result = TwoSum.UsingSort(new int[] { 3, 2, 4 }, 6);
            Assert.Equal(new int[] { 1, 2 }, result);
        }

        [Fact]
        public void UsingSortTestCase3()
        {
            var result = TwoSum.UsingSort(new int[] { 3, 3 }, 6);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void UsingSortTestCase4()
        {
            var result = TwoSum.UsingSort(new int[] { 3, 3, 3, 3 }, 6);
            Assert.Equal(new int[] { 0, 1 }, result);
        }
    }
}
