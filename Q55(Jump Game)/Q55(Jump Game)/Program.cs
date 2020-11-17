using System;

namespace Q55_Jump_Game_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool CanJump(int[] nums)
        {
            int max_index_CanJump = -1;

            for(int i = 0; i < nums.Length; i++)
            {
                // 在沒有遇到0之前，計算目前可以到達的最大索引
                if (nums[i] != 0)
                {
                    if (i + nums[i] > max_index_CanJump)
                    {
                        max_index_CanJump = i + nums[i];
                    }
                }
                // 若遇到0，檢查目前可以到達的最大索引是否可以越過這個0
                // 注意，若這個0恰好出現在尾端則不需要考慮越過
                else
                {
                    if (i != nums.Length - 1 && max_index_CanJump <= i)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
