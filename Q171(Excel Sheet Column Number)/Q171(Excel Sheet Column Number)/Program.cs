using System;

namespace Q171_Excel_Sheet_Column_Number_
{
    public class Program
    {

        static void Main() { }

        public int TitleToNumber(string s)
        {
            // 建立26進位的輔助換算表
            int[] powerOf26 = new int[7];

            powerOf26[0] = 1;

            for(int i = 1; i < powerOf26.Length; i++)
            {
                powerOf26[i] = powerOf26[i - 1] * 26;
            }

            int stringToNumberInBase26 = 0;

            // 將26進位的字串轉成數字
            for(int i = 0; i < s.Length; i++)
            {
                int charNumber = Convert.ToInt32(s[i]) - 64;

                stringToNumberInBase26 += charNumber * powerOf26[s.Length - i - 1];
            }

            return stringToNumberInBase26;
        }
    }
}