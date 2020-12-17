using System;
using System.Collections.Generic;

namespace Q93_Restore_IP_Addresses_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //GetValidAddress("25525511135", 0, new List<string>());
        }

        public void GeneratePossibleAddress(string s, int start, List<string> partList, IList<string> Answer)
        {
            // 若字元已經用完但還沒湊齊4個部分則返回(避免越界)
            if (start == s.Length && partList.Count < 4)
            {
                return;
            }

            if(partList.Count == 4)
            {
                // 若成功湊齊4個部分且所有字元都有被使用到，表示成功找到一組答案
                if (start == s.Length)
                {
                    Answer.Add(string.Join(".", partList));
                }
                return;
            }

            string PossiblePart;

            // 從當前位置往後取1個字元組成當前部分(肯定合法，所以不用檢查)
            // 之後遞迴取下一個部分，搜尋完後恢復狀態
            PossiblePart = s.Substring(start, 1);
            partList.Add(PossiblePart);
            GeneratePossibleAddress(s, start + 1, partList, Answer);
            partList.RemoveAt(partList.Count - 1);

            // 檢查往後取2個字元是否越界，以及第一個字元是否為0
            if(start > s.Length - 2 || s[start] == '0')
            {
                return;
            }

            // 從當前位置往後取2個字元組成當前部分
            // 之後遞迴取下一個部分，搜尋完後恢復狀態
            PossiblePart = s.Substring(start, 2);
            partList.Add(PossiblePart);
            GeneratePossibleAddress(s, start + 2, partList, Answer);
            partList.RemoveAt(partList.Count - 1);

            // 檢查往後取3個字元是否越界
            if (start > s.Length - 3)
            {
                return;
            }

            // 從當前位置往後取3個字元組成當前部分(三位數必須檢查大小)
            // 之後遞迴取下一個部分，搜尋完後恢復狀態
            PossiblePart = s.Substring(start, 3);
            if (Convert.ToInt32(PossiblePart) < 256)
            {
                partList.Add(PossiblePart);
                GeneratePossibleAddress(s, start + 3, partList, Answer);
                partList.RemoveAt(partList.Count - 1);
            }
        }

        public IList<string> RestoreIpAddresses(string s)
        {
            // Edge case
            if(s.Length < 4 || s.Length > 12)
            {
                return new List<string>();
            }

            IList<string> Answer = new List<string>();
            GeneratePossibleAddress(s, 0, new List<string>(), Answer);
            return Answer;
        }
    }
}
