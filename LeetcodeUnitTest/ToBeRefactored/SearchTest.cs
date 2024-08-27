using Leetcode.Leetcode;
using FluentAssertions;
using Xunit;

namespace LeetcodeUnitTest.ToBeRefactored
{
    public class SearchItemsTest
    {
        [Fact]
        public void GetList_Return_Result()
        {
            var result = SearchItems.GetList(new List<string> {
                "camera", "computer","cooker","mobile",
                "charger","laptop","calculator","keyboard",
                "mouse" }, "camera");
            result.Count.Should().Be(6);
            result[5].Count.Should().Be(1);
        }
    }
}
