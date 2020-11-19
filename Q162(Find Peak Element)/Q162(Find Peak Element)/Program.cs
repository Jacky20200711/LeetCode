using System;

namespace Q162_Find_Peak_Element_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool IsPeak(int[] nums, int mid)
        {
            int mid_left = mid - 1;
            int mid_right = mid + 1;

            // 若左邊越界
            if (mid_left < 0)
            {
                // 若右邊越界 or 沒越界
                return (mid_right == nums.Length || nums[mid] > nums[mid_right]) ? true : false;
            }

            // 若右邊越界
            if (mid_right == nums.Length)
            {
                // 若左邊越界 or 沒越界
                return (mid_left < 0 || nums[mid] > nums[mid_left]) ? true : false;
            }

            return nums[mid] > nums[mid_left] && nums[mid] > nums[mid_right] ? true : false;
        }

        public int FindPeakElement(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while(left <= right)
            {
                int mid = (left + right) >> 1;
                if(IsPeak(nums, mid))
                {
                    return mid;
                }
                else if(mid + 1 < nums.Length && nums[mid] < nums[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
    }
}
