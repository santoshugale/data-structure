using Leetcode.Leetcode;
using Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace LeetcodeTest.Leetcode
{
    public class SimpleTextQueriesTest
    {
        [Fact]
        public void TextQueries_Return_minus_1()
        {
            var result = SimpleTextQueries.TextQueriesOptimized(new List<string> { "Some String", "Some Other String" }, new List<string> { "Not" });
            result[0].Should().BeEquivalentTo(new List<int> { -1 });
        }

        [Fact]
        public void TextQueries_Return_Index()
        {
            var result = SimpleTextQueries.TextQueriesOptimized(new List<string> { "Some String", "Some Other String" }, new List<string> { "Other" });
            result[0].Should().BeEquivalentTo(new List<int> { 1 });
        }

        [Fact]
        public void TextQueries_Return_Index_2()
        {
            var result = SimpleTextQueries.TextQueriesOptimized(new List<string> { "Some String", "Some Other String" }, new List<string> { "String" });
            result[0].Should().BeEquivalentTo(new List<int> { 0, 1 });
        }

        [Fact]
        public void TextQueries_Return_Index_3()
        {
            var result = SimpleTextQueries.TextQueriesOptimized(new List<string> { "Some String", "Some Other String" }, new List<string> { "Some String" });
            result[0].Should().BeEquivalentTo(new List<int> { 0, 1 });
        }

        [Fact]
        public void TextQueries_Return_Index_4()
        {
            var result = SimpleTextQueries.TextQueriesOptimized(new List<string> { "Some String", "Some Other String" }, new List<string> { "Not String" });
            result[0].Should().BeEquivalentTo(new List<int> { -1 });
        }

        [Fact]
        public void TextQueries_Return_Index_5()
        {
            var result = SimpleTextQueries.TextQueriesOptimized(new List<string> { "Some String", "Some Other String" }, new List<string> { "String Not" });
            result[0].Should().BeEquivalentTo(new List<int> { -1 });
        }
    }
}
