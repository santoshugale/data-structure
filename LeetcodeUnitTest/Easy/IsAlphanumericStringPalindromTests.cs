using Leetcode.Easy;
using Xunit;

namespace LeetcodeUnitTest.Easy
{
    public class IsAlphanumericStringPalindromTests
    {
        [Fact]
        public void IsPalindrome_ShouldReturnTrue_WhenInputIsPalindrome()
        {
            // Arrange
            string input = "A man, a plan, a canal: Panama";

            // Act
            bool result = IsAlphanumericStringPalindrom.IsPalindrome(input);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_ShouldReturnTrue_WhenInputIsSingleChar()
        {
            // Arrange
            string input = "a";

            // Act
            bool result = IsAlphanumericStringPalindrom.IsPalindrome(input);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_ShouldReturnFalse_WhenInputIsNotPalindrome()
        {
            // Arrange
            string input = "race a car";

            // Act
            bool result = IsAlphanumericStringPalindrom.IsPalindrome(input);

            // Assert
            Assert.False(result);
        }
    }
}
