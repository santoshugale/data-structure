using Leetcode.Sort;
using FluentAssertions;
using Xunit;

namespace LeetcodeTest
{
    public class MergeSortTest
    {
        [Fact]
        public void MergeSort_Test()
        {
            var input = new int[10] { 1, 6, 3, 2, 7, 9, 4, 5, 8, 0 };
            var output = MergeSort.SortArrayRec(input);
            output[0].Should().Be(0);
            output[1].Should().Be(1);
            output[2].Should().Be(2);
            output[3].Should().Be(3);
            output[4].Should().Be(4);
            output[5].Should().Be(5);
            output[6].Should().Be(6);
            output[7].Should().Be(7);
            output[8].Should().Be(8);
            output[9].Should().Be(9);
        }
    }
}
