using System;
using System.Collections.Generic;
using System.Linq;

namespace Q215_Kth_Largest_Element_in_an_Array_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort<int>(nums, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            return nums[k - 1];
        }
    }
}
