using System;
using System.Linq;

namespace Q283_Move_Zeroes_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool MoveZeroes(int[] nums, int[] nums2)
        {
            int WritePos = 0;

            // 持續將非零數字往左填
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[WritePos++] = nums[i];
                }
            }

            // 零的數量 = nums.Length - WritePos
            // 從最右邊填0
            for (int i = 0; i < nums.Length - WritePos; i++)
            {
                nums[nums.Length - 1 - i] = 0;
            }

            return nums.SequenceEqual(nums2);
        }
    }
}
