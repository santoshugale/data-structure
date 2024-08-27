using Leetcode.Medium;
using Xunit;

namespace LeetcodeUnitTest.Medium
{
    public class MaxProfitWhenStockCanBePurchasedAndSoldMultipleTimesTests
    {
        [Fact]
        public void MaxProfit_ShouldReturnMaxProfit()
        {
            // Arrange
            int[] prices = { 100, 180, 260, 310, 40, 535, 695 };
            int expected = 865;

            // Act
            int result = MaxProfitWhenStockCanBePurchasedAndSoldMultipleTimes.MaxProfit(prices);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
