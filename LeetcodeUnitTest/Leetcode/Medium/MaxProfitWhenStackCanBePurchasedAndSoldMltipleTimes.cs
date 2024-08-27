using Xunit;

namespace Leetcode.Leetcode.Medium.Tests
{
    public class MaxProfitWhenStockCanBePurchasedAndSoldMultipleTimesTests
    {
        [Fact]
        public void MaxProfit_ShouldReturnMaxProfit()
        {
            // Arrange
            var solution = new MaxProfitWhenStockCanBePurchasedAndSoldMultipleTimes();
            int[] prices = { 100, 180, 260, 310, 40, 535, 695 };
            int expected = 865;

            // Act
            int result = solution.MaxProfit(prices);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
