using System;

namespace Q172_Factorial_Trailing_Zeroes_
{
    public class Program
    {
        static void Main() { }

        public int TrailingZeroes(int n)
        {
            // 建立5的次方對照表，5^14 會開始超過 Input 的上限，所以最大次方取13
            int[] powerOf5 = new int[14];

            powerOf5[1] = 5;

            for(int i = 2; i < powerOf5.Length; i++)
            {
                powerOf5[i] = powerOf5[i - 1] * 5;
            }

            // 計算 n! 如果拆成質因數相乘會有幾個5
            int numberOf5 = 0;
            
            for(int i = 1; i < powerOf5.Length && n >= powerOf5[i]; i++)
            {
                numberOf5 += n / powerOf5[i];
            }

            return numberOf5;
        }
    }
}
