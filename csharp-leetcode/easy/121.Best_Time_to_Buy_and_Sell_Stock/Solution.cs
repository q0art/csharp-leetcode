namespace csharp_leetcode.easy._121.Best_Time_to_Buy_and_Sell_Stock;

public class Solution
{
    public int MaxProfit(int[] prices) 
    {
        if (prices == null || prices.Length <= 1)
            return 0;

        int maxProfit = 0, minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            minPrice = Math.Min(minPrice, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
        }

        return maxProfit;
    }
}