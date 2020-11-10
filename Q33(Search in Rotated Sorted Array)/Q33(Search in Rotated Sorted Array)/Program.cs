using System;
using System.Globalization;
using System.Linq;

namespace Q33_Search_in_Rotated_Sorted_Array_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int GetPivot(int[] nums)
        {
            int left = 0, right = nums.Count()-1;

            // 二分搜尋 pivot (我把它定義為右邊部分的第一個數)
            while (left <= right)
            {
                int mid = (right + left) >> 1;

                if (nums[mid] > nums[0])
                {
                    // 如果 0~mid 已排序，則 pivot 必然在右邊
                    left = mid + 1;
                }
                else if(nums[mid] < nums[0])
                {
                    // 如果 0~mid 未排序，則 mid 可能恰好為 pivot 
                    if (nums[mid] < nums[mid - 1])
                    {
                        return mid;
                    }
                    else
                    {
                        // 若 mid 不是 pivot 則 pivot 必然在左邊
                        right = mid - 1;
                    }
                }
                else
                {
                    return mid + 1;
                }
            }
            return left;
        }

        public int Search(int[] nums, int target)
        {
            // 取得可以將數列分隔成兩邊已排序數列的 pivot (其中 nums[pivot] 為右邊部分的第一個數)
            int pivot = GetPivot(nums);

            // 對 pivot 左邊做二分搜尋
            int targetIndex = Array.BinarySearch(nums, 0, pivot, target);

            if (targetIndex < 0)
            {
                // 若左邊搜尋不到，則對 pivot(含) 右邊做二分搜尋
                targetIndex = Array.BinarySearch(nums, pivot, nums.Count() - pivot, target);

                return targetIndex > -1 ? targetIndex : -1;
            }
            else
            {
                return targetIndex;
            }
        }
    }
}
