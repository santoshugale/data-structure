using Leetcode;
using Xunit;

namespace LeetCodeUnitTest
{
    public class ThreeSumTest
    {
        [Fact]
        public void BruteForce_Success()
        {
            var result = ThreeSum.BruteForce(new List<int> { -1, 0, 1, 2, -1, -4 });
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public void BrueForce_EmptyList()
        {
            var result = ThreeSum.BruteForce(new List<int> { });
            Assert.Empty(result);
        }

        [Fact]
        public void OptimizedSolution_Success()
        {
            var result = ThreeSum.OptimizedSolution(new List<int> { -1, 0, 1, 2, -1, -4 });
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public void OptimizedSolution_Success_0()
        {
            var result = ThreeSum.OptimizedSolution(new List<int> { -1, -1, -1, 0, 1, 2, -1 });
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public void OptimizedSolution_Success_1()
        {
            var result = ThreeSum.OptimizedSolution(new List<int> { -1, 0, 1, 2, 2, 2 });
            Assert.Single(result);
        }

        [Fact]
        public void OptimizedSolution_Success_3()
        {
            var result = ThreeSum.OptimizedSolution(new List<int> { -1, 0, 1 });
            Assert.Single(result);
        }

        [Fact]
        public void OptimizedSolution_Success_4()
        {
            var result = ThreeSum.OptimizedSolution(new List<int> { -2, 0, 1 });
            Assert.Empty(result);
        }


        [Fact]
        public void OptimizedSolution_EmptyList()
        {
            var result = ThreeSum.OptimizedSolution(new List<int> { });
            Assert.Empty(result);
        }
    }
}
