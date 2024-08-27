using Xunit;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Leetcode.Easy;

namespace LeetcodeUnitTest.Easy
{
    public class StockRelatedQuestionsTest
    {
        [Fact]
        public void MaxProfit_Return_Profit_5()
        {
            var result = StockRelatedQuestions.MaxProfitBestSolution(new int[] { 7, 1, 5, 3, 6, 4 });
            Assert.Equal(5, result);
        }

        [Fact]
        public void MaxProfit_Return_Profit_19()
        {
            var result = StockRelatedQuestions.MaxProfitBestSolution(new int[] { 7, 2, 5, 3, 6, 1, 20 });
            Assert.Equal(19, result);
        }

        [Fact]
        public void MaxProfit_Return_Profit_0()
        {
            var result = StockRelatedQuestions.MaxProfitBestSolution(new int[] { 7, 6, 5, 4, 3, 2, 1 });
            Assert.Equal(0, result);
        }
    }
}
