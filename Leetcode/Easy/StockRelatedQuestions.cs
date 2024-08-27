using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Easy
{
    public class StockRelatedQuestions
    {
        public static int MaxProfit(int[] prices)
        {
            var sellPrice = prices[0];
            var purchasePrice = prices[0];
            foreach (var price in prices)
            {
                if (price < purchasePrice)
                {
                    purchasePrice = price;
                    sellPrice = price;
                }
                if (price > sellPrice)
                {
                    sellPrice = price;
                }
            }
            return sellPrice - purchasePrice;
        }

        public static int MaxProfitBestSolution(int[] prices)
        {
            var purchasePrice = prices[0];
            var profit = 0;

            foreach (var price in prices)
            {
                if (price > purchasePrice)
                {
                    profit = Math.Max(profit, price - purchasePrice);
                }
                else
                {
                    purchasePrice = price;
                }
            }
            return profit;
        }
    }
}
