using Leetcode.Search;
using Xunit;

namespace LeetcodeTest.Search
{
    public class BinarySearchTest
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
        public void BinarySearch_Test(int target, int output)
        {
            var result = BinarySearch.Search1<int>(array, target);
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 4)]
        [InlineData(6, 5)]
        [InlineData(100, -1)]
        public void BinarySearchRecursiveReturnsIndex_Test(int target, int output)
        {
            var result = BinarySearch.BinarySearchRecursive_ReturnIndex(array, 0, array.Length - 1, target);
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, true)]
        [InlineData(5, true)]
        [InlineData(6, true)]
        [InlineData(100, false)]
        public void BinarySearch_RecursiveTest(int target, bool output)
        {
            var result = BinarySearch.SearchRecursive<int>(array, target);
            Assert.Equal(output, result);
        }
    }
}
