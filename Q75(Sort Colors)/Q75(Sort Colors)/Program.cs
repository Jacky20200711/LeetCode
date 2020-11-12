using System;
using System.Linq;

namespace Q75_Sort_Colors_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void SortColors(int[] nums)
        {
            // 累計 0,1,2 的數量
            int[] Counter = new int[3];
            for(int i = 0; i < nums.Count(); i++)
            {
                Counter[nums[i]]++;
            }

            // 依序寫入 0,1,2
            int index = 0;
            for (int i = 0; i < Counter.Count(); i++)
            {
                for(int j = 0; j < Counter[i]; j++)
                {
                    nums[index++] = i;
                }
            }
        }
    }
}
