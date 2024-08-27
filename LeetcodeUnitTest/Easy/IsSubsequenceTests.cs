using Leetcode.Easy;
using Xunit;

namespace LeetcodeUnitTest.Easy
{
    public class IsSubsequenceTests
    {
        [Fact]
        public void IsSubsequenceUsingForLoop_ShouldReturnTrue()
        {
            // Arrange
            string s = "abc";
            string t = "ahbgdc";

            // Act
            bool result = IsSubsequence.IsSubsequenceUsingForLoop(s, t);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsSubsequenceUsingForLoop_ShouldReturnFalse()
        {
            // Arrange
            string s = "axc";
            string t = "ahbgdc";

            // Act
            bool result = IsSubsequence.IsSubsequenceUsingForLoop(s, t);

            // Assert
            Assert.False(result);
        }
    }
}
