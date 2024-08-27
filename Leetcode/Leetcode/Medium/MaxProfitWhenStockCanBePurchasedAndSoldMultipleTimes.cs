namespace Leetcode.Leetcode.Medium
{
    public class MaxProfitWhenStockCanBePurchasedAndSoldMultipleTimes
    {
        public int MaxProfit(int[] prices)
        {
            // maxProfit adds up the difference
            // between adjacent elements if they
            // are in increasing order
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
                if (prices[i] > prices[i - 1])
                    maxProfit += prices[i] - prices[i - 1];

            return maxProfit;
        }
    }
}
