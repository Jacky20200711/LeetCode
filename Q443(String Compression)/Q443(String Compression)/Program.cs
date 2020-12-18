using System;

namespace Q443_String_Compression_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int Compress(char[] chars)
        {
            // 紀錄第一個字元
            char CurrentChar = chars[0];
            int numOfChar = 1;
            int WritePos = 0;

            // 從第2個字元開始掃描
            for (int i = 1; i < chars.Length; i++)
            {
                // 若出現一樣的字元，累加其出現頻率
                if (chars[i] == CurrentChar)
                {
                    numOfChar++;
                }
                // 若出現不一樣的字元，則從 WritePos 將之前追蹤的字元和頻率寫回原陣列 
                else
                {
                    // 寫入之前追蹤的字元
                    chars[WritePos++] = CurrentChar;

                    // 寫入該字元的頻率(若頻率為1則忽略)
                    if (numOfChar != 1)
                    {
                        string frequency = numOfChar.ToString();
                        foreach (char c in frequency)
                        {
                            chars[WritePos++] = c;
                        }
                    }

                    // 更新追蹤的字元和累計頻率
                    CurrentChar = chars[i];
                    numOfChar = 1;
                }
            }

            // 注意，由於最後那組無法再碰到不同字元，所以尚未被寫入
            // 寫入最後追蹤的字元
            chars[WritePos++] = CurrentChar;

            // 寫入該字元的頻率(若頻率為1則忽略)
            if (numOfChar != 1)
            {
                string frequency = numOfChar.ToString();
                foreach (char c in frequency)
                {
                    chars[WritePos++] = c;
                }
            }

            return WritePos;
        }
    }
}