using System;

namespace Q121BestTimeToBuyAndSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0, buy = 0, sell = 1;

            while (sell < prices.Length)
            {
                if (prices[buy] > prices[sell])
                    buy = sell;
                else
                    maxProfit = Math.Max(prices[sell] - prices[buy], maxProfit);

                sell++;
            }

            return maxProfit;
        }
    }
}
