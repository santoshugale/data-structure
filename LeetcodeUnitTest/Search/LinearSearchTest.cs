using Leetcode.Search;
using Xunit;

namespace LeetcodeTest.Search
{
    public class LinearSearchTest
    {
        private readonly int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 4)]
        [InlineData(6, 5)]
        [InlineData(100, -1)]
        public void Test(int target, int output)
        {
            var result = LinearSearch.Search<int>(array, target);
            Assert.Equal(output, result);
        }
    }
}
