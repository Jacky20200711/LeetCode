using System;

namespace Q34_Find_First_and_Last_Position_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[] SearchRange(int[] nums, int target)
        {
            int FirstPosition, LastPosition, X;
            int FirstFindPosition = Array.BinarySearch(nums, target);

            // 做全陣列的二分搜尋(假設搜尋到的 Index = X)
            if (FirstFindPosition < 0)
            {
                return new int[] { -1, -1 };
            }
            else
            {
                FirstPosition = LastPosition = FirstFindPosition;
            }

            // 做零到(X-1)的二分搜尋 & 持續壓縮 X 的值，直到找不到目標值
            X = FirstFindPosition;
            while (true)
            {
                int NewPosition = Array.BinarySearch(nums, 0, X, target);

                if (NewPosition > -1)
                {
                    FirstPosition = X = NewPosition;
                }
                else break;
            }

            // 做(X+1)到尾端的二分搜尋 & 持續壓縮 X 的值，直到找不到目標值
            X = FirstFindPosition;
            while (true)
            {
                // 計算從 (FindPosition + 1) 到尾端的數量
                int len = nums.Length - X - 1;
                int NewPosition = Array.BinarySearch(nums, X + 1, len, target);

                if (NewPosition > -1)
                {
                    LastPosition = X = NewPosition;
                }
                else break;
            }
            return new int[] { FirstPosition, LastPosition };
        }
    }
}
