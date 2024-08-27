using Leetcode.Easy;
using Xunit;

namespace LeetcodeUnitTest.Easy
{
    public class FindTheIndexOfTheFirstOccurrenceInStringTests
    {
        [Fact]
        public void StrStr_ShouldReturnCorrectIndex()
        {
            // Arrange
            string haystack = "hello";
            string needle = "ll";
            int expectedIndex = 2;

            // Act
            int actualIndex = FindTheIndexOfTheFirstOccurrenceInString.StrStr(haystack, needle);

            // Assert
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void StrStr_ShouldReturnNegativeOne_WhenNeedleNotFound()
        {
            // Arrange
            string haystack = "sadbutsad";
            string needle = "sad";
            int expectedIndex = 0;

            // Act
            int actualIndex = FindTheIndexOfTheFirstOccurrenceInString.StrStr(haystack, needle);

            // Assert
            Assert.Equal(expectedIndex, actualIndex);
        }
    }
}
