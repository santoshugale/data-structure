using FluentAssertions;
using Leetcode.Hard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetcodeUnitTest.Hard
{
    public class LongestCommonSubsequenceTest
    {
        [Theory]
        [InlineData("ABC", "DEF", 0)]
        [InlineData("ABC", "CBA", 1)]
        [InlineData("ABC", "ACD", 2)]
        [InlineData("XYZW", "XYWZ", 3)]
        [InlineData("AGGTAB", "GXTXAYB", 4)]
        public void TestLongestCommonSubsequenceBruteForce(string text1, string text2, int expected)
        {
            int result = LongestCommonSubsequence.LongestCommonSubsequenceBruteForce(text1, text2);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("ABC", "DEF", 0)]
        [InlineData("ABC", "CBA", 1)]
        [InlineData("ABC", "ACD", 2)]
        [InlineData("XYZW", "XYWZ", 3)]
        [InlineData("AGGTAB", "GXTXAYB", 4)]
        public void TestLongestCommonSubsequenceMemoization(string text1, string text2, int expected)
        {
            int result = LongestCommonSubsequence.LongestCommonSubsequenceMemoization(text1, text2);
            result.Should().Be(expected);
        }
    }
}
