﻿using System;
using System.Linq;

namespace Q268_Missing_Number_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int MissingNumber(int[] nums)
        {
            int[] hashTableOfZeroToN = new int[nums.Length + 1];

            // 不要讓 Index = 0 的 Default Value 為 0
            hashTableOfZeroToN[0] = -1;

            // 將確定存在的數字放到對應的Index
            foreach (var n in nums)
            {
                hashTableOfZeroToN[n] = n;
            }

            // 查看各Index內的數字是否為本身
            for (int i = 0; i < hashTableOfZeroToN.Length; i++)
            {
                if (hashTableOfZeroToN[i] != i)
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
