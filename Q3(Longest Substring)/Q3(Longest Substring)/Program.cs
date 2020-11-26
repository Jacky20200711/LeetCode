using System;
using System.Collections.Generic;

namespace Q3_Longest_Substring_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int LengthOfLongestSubstring(string s)
        {
            int MaxLen = 0;
            int LeftBound = 0;
            int[] ASCII = new int[129];

            for(int i = 0; i < ASCII.Length; i++)
            {
                ASCII[i] = -1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                // 若遇到重複出現的字元，而且該字元上次出現的位置被包含在當前的子字串
                if (ASCII[s[i]] >= LeftBound)
                {
                    // 將當前子字串的左界移動到 "上一次出現該字元的右邊"
                    LeftBound = ASCII[s[i]] + 1;

                    // 紀錄該字元最後出現的位置
                    ASCII[s[i]] = i;
                }
                // 若該字元沒有被包含在當前的子字串
                else
                {
                    // 紀錄新字元的位置
                    ASCII[s[i]] = i;

                    // 計算當前的子字串長度
                    int CurrentLen = i - LeftBound + 1;

                    // 查看是否比當前的答案大
                    if (MaxLen < CurrentLen)
                    {
                        MaxLen = CurrentLen;
                    }
                }
            }

            return MaxLen;
        }
    }
}
