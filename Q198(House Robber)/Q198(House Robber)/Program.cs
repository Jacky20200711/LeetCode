using System;
using System.Globalization;
using System.Linq;
using System.Runtime;

namespace Q198_House_Robber_
{
    public class Program
    {
        static void Main(string[] args) { }

        public int Rob(int[] nums)
        {
            // Edge Case
            switch (nums.Length)
            {
                case 0:
                    return 0;
                case 1:
                    return nums[0];
                case 2:
                    return nums[0] > nums[1] ? nums[0] : nums[1];
            }

            // 用來紀錄從每個Index開始往後偷錢，能夠獲得的最大利益
            // 舉例:maxProfit[5]就代表從nums[5]開始往後偷錢能夠獲得的最大利益
            int[] maxProfit = new int[nums.Length];

            // 填入可以快速取得的答案(舉例:若從最後一家開始偷，則最大利益為nums[^1])
            maxProfit[nums.Length - 1] = nums[^1];
            maxProfit[nums.Length - 2] = nums[^1] > nums[^2] ? nums[^1] : nums[^2];
            maxProfit[nums.Length - 3] = nums[^1] + nums[^3] > nums[^2] ? nums[^1] + nums[^3] : nums[^2];

            // 填入其他的答案
            for (int i = nums.Length - 4; i > -1; i--)
            {
                // 從i開始偷錢的最大利益 = nums[i] + max(從i+2往後偷的最大利益, 從i+3往後偷的最大利益)
                maxProfit[i] = nums[i] + (maxProfit[i + 2] > maxProfit[i + 3] ? maxProfit[i + 2] : maxProfit[i + 3]);
            }

            // 最大利益可能是從第一家開始偷錢，或是從第二家開始偷錢
            return maxProfit[0] > maxProfit[1] ? maxProfit[0] : maxProfit[1];
        }
    }
}
