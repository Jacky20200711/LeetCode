using System;
using System.Collections.Generic;

namespace Q41_First_Missing_Positive_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int FirstMissingPositive(int[] nums)
        {
            HashSet<int> PositiveNumSet = new HashSet<int>();

            int smallestMissingPositive = 1;

            // 紀錄所有出現過的正數
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] > 0)
                {
                    PositiveNumSet.Add(nums[i]);
                }
            }

            // 搜尋缺漏的最小正數
            while (PositiveNumSet.Contains(smallestMissingPositive))
            {
                smallestMissingPositive++;
            }

            return smallestMissingPositive;
        }
    }
}
