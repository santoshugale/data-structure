using FluentAssertions;
using Leetcode.Sort;
using Xunit;

namespace LeetcodeTest
{
    public class QuickSortTest
    {
        [Fact]
        public void QuickSort_Test()
        {
            var input = new int[10] { 1, 6, 3, 2, 7, 9, 4, 5, 8, 0 };
            QuickSort.Sort(input);
            input[0].Should().Be(0);
            input[1].Should().Be(1);
            input[2].Should().Be(2);
            input[3].Should().Be(3);
            input[4].Should().Be(4);
            input[5].Should().Be(5);
            input[6].Should().Be(6);
            input[7].Should().Be(7);
            input[8].Should().Be(8);
            input[9].Should().Be(9);
        }
    }
}
