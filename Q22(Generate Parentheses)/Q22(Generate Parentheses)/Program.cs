using System;
using System.Collections.Generic;

namespace Q22_Generate_Parentheses_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void GetValidParenthesis(IList<string> ValidParenStr, string ParenStr, int num_left, int num_right, int n)
        {
            // 右括號不能比左括號多 & 左括號的上限為n
            if (num_right > num_left || num_left > n)
                return;

            // 若右括號達到上限，表示找到一組答案
            if(num_right == n)
            {
                ValidParenStr.Add(ParenStr);
                return;
            }

            // 遞迴搜尋在當前位置放左括號的情形
            GetValidParenthesis(ValidParenStr, ParenStr + "(", num_left + 1, num_right, n);

            // 遞迴搜尋在當前位置放右括號的情形
            GetValidParenthesis(ValidParenStr, ParenStr + ")", num_left, num_right + 1, n);
        }

        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> ValidParenStr = new List<string>();

            GetValidParenthesis(ValidParenStr, "", 0, 0, n);

            return ValidParenStr;
        }
    }
}
