public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = prices[0];
        int maxProfit = 0;
        foreach(int p in prices)
        {
            if (p < buy)
            {
                buy = p;
                continue;
            }

            int potential = p - buy;
            if(potential > maxProfit)
            {
                maxProfit = potential;
            }
        }

        return maxProfit;
    }
}
