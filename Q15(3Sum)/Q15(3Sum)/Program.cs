using System;
using System.Collections.Generic;

namespace Q15_3Sum_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            // Edge case
            if (nums.Length < 3)
                return new List<IList<int>>();

            IList<IList<int>> Triplets = new List<IList<int>>();

            // 先排序以方便忽略重複的數
            Array.Sort(nums);

            // 將題目看成是找出 a + b = -c 的組合
            // 將每一個當前的數字看成是 -c (target)
            for(int i = 0; i < nums.Length-1; i++)
            {
                // 忽略重複的 target (否則抓到的組合會一模一樣)
                if (i > 0 && nums[i] == nums[i-1])
                    continue;

                int target = nums[i] * -1;
                int lPtr = i + 1;
                int rPtr = nums.Length - 1;

                // 從 nums[i+1] ~ nums[^1] 找出 x + y = target 的組合(由於排序過，所以使用 Two pointer)
                while(lPtr < rPtr)
                {
                    if(nums[lPtr] + nums[rPtr] < target)
                    {
                        lPtr++;
                    }
                    else if(nums[lPtr] + nums[rPtr] > target)
                    {
                        rPtr--;
                    }
                    else
                    {
                        
                        // 紀錄答案
                        Triplets.Add(new List<int> { nums[i], nums[lPtr], nums[rPtr] });

                        // 指針各移動一格
                        lPtr++; rPtr--;

                        // 若移動後的值沒有變則繼續移動
                        while (lPtr < rPtr && nums[lPtr] == nums[lPtr - 1]) lPtr++;
                        while (lPtr < rPtr && nums[rPtr] == nums[rPtr + 1]) rPtr--;
                    }
                }
            }

            return Triplets;
        }
    }
}
