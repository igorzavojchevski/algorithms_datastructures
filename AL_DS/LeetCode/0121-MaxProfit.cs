namespace AL_DS.LeetCode
{
    public static class _0121_MaxProfit
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;

            int minValue = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minValue)
                    minValue = prices[i];
                else if (prices[i] - minValue > maxProfit)
                    maxProfit = prices[i] - minValue;
            }

            return maxProfit;
        }
    }
}
