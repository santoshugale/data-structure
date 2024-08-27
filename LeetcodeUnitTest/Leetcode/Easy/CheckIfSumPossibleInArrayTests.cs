using Leetcode.Leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetcodeUnitTest.Leetcode.Easy
{
    public class CheckIfSumPossibleInArrayTests
    {
        [Fact]
        public void IsSumPossible_ShouldReturnTrue()
        {
            // Arrange
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 9;

            // Act
            bool result = CheckIfSumPossibleInArray.IsSumPossible(arr, sum);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsSumPossible_ShouldReturnFalse()
        {
            // Arrange
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 10;

            // Act
            bool result = CheckIfSumPossibleInArray.IsSumPossible(arr, sum);

            // Assert
            Assert.False(result);
        }
    }
}
