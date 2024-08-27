using Leetcode.Recursion;
using Xunit;

namespace LeetcodeUnitTest
{
    public class FactorialTests
    {
        [Fact]
        public void TestGetFactorialNonRecursive()
        {
            // Arrange
            int number = 5;
            int expected = 120;

            // Act
            int result = Factorial.GetFactorialNonRecursive(number);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestGetFactorialRecursive()
        {
            // Arrange
            int number = 5;
            int expected = 120;

            // Act
            int result = Factorial.GetFactorialRecursive(number);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
