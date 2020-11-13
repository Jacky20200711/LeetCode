using System;
using System.Collections.Generic;

namespace Q49_Group_Anagrams_
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public string GetCharFreqStr(string TargetStr)
        {
            int[] CharFreq = new int[26];

            // 統計各小寫字元的出現頻率
            for (int i = 0; i < TargetStr.Length; i++)
            {
                CharFreq[TargetStr[i] - 97]++;
            }

            // 將統計結果轉成字串，以方便之後用 HashTable 分組
            // 舉例 : aaab 經過轉換後，會變成 a3b
            string CharStr = "abcdefghijklmnopqrstuvwxyz";
            List<string> FreqToStrList = new List<string>();

            for (int i = 0; i < CharStr.Length; i++)
            {
                if (CharFreq[i] != 0)
                {
                    FreqToStrList.Add(CharStr[i].ToString());
                    FreqToStrList.Add(CharFreq[i].ToString());
                }
            }
            return string.Join("", FreqToStrList);
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> AnagramGroups = new List<IList<string>>();
            Dictionary<string, List<int>> IndexGroups = new Dictionary<string, List<int>>();

            for (int i = 0; i < strs.Length; i++)
            {
                // 取得當前字串的字元頻率
                string FreqStr = GetCharFreqStr(strs[i]);

                // 將相同字元頻率的 Hash 到同一個 Group (存索引即可)
                if (IndexGroups.ContainsKey(FreqStr))
                {
                    IndexGroups[FreqStr].Add(i);
                }
                else
                {
                    // 新增 Group
                    IndexGroups[FreqStr] = new List<int> { i };
                }
            }

            // 取出各組別的字串，並放入用來儲存答案的二維串列
            foreach(var IndexGroup in IndexGroups)
            {
                // 新增 Group
                AnagramGroups.Add(new List<string>());

                // 將同一組的字串加入到這個 Group 
                foreach (var index in IndexGroup.Value)
                {
                    AnagramGroups[^1].Add(strs[index]);
                }
            }
            return AnagramGroups;
        }
    }
}
