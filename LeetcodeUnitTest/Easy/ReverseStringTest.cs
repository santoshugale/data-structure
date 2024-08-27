using FluentAssertions;
using Leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetcodeUnitTest.Easy
{
    public class ReverseStringTest
    {

        [Theory]
        [InlineData("abcd", "dcba")]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("aa", "aa")]
        public void TestReverseWithExtraSpace(string text, string expected)
        {
            var result = ReverseString.ReverseWithExtraSpace(text);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("abcd", "dcba")]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("aa", "aa")]
        public void TestReverseWithoutExtraSpace(string text, string expected)
        {
            var result = ReverseString.ReverseWithoutExtraSpace(text);
            result.Should().Be(expected);
        }
    }
}
