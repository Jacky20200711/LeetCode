using System;
using System.Collections.Generic;

namespace Q1_Two_Sum_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> num_pos = new Dictionary<int, int>
            {
                [nums[0]] = 0
            };

            for (int i = 1; i < nums.Length; i++)
            {
                int diff = target - nums[i];

                // 檢查目標值是否曾被記錄
                if (num_pos.ContainsKey(diff))
                {
                    return new int[] { num_pos[diff], i };
                }
                // 紀錄新的數字與對應的索引
                else
                {
                    num_pos[nums[i]] = i;
                }
            }

            return new int[] { 0, 1 };
        }
    }
}
