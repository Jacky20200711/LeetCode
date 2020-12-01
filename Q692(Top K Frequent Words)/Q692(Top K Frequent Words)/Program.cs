using System;
using System.Collections.Generic;
using System.Linq;

namespace Q692_Top_K_Frequent_Words_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public IList<string> TopKFrequent(string[] words, int k)
        {
            Trie trie = new Trie();

            foreach(string word in words)
            {
                trie.Insert(word);
            }

            // 依字典順序(即a~z)取得所有的字串
            trie.GetAllStrWithFrequcncy();

            // 依照頻率由大到小排序(LINQ的排序為穩定排序，可以保持字典順序)
            trie.freqStrings = trie.freqStrings.OrderByDescending(s => s.Frequency).ToList();

            // 取出前k個頻率最高的字串
            IList<string> answer = new List<string>();
            for(int i = 0; i < k; i++)
            {
                answer.Add(trie.freqStrings[i].Word);
            }

            return answer;
        }

        public class Trie
        {
            // 每個節點都包含 26 個子節點，分別表示對應的小寫字母
            public class Node
            {
                public int StrFrequency { get; set; }

                public Node[] ChrPointers { get; set; }

                public Node()
                {
                    StrFrequency = 0;
                    ChrPointers = new Node[26];
                }
            }

            // 創建可以包含字串和頻率的類別
            public class FreqString
            {
                public string Word { get; set; }

                public int Frequency { get; set; }
            }

            private readonly Node rootOfTrie = null;
            private readonly List<char> StrChars = new List<char>(); // 用來儲存路過的字元

            // 當抵達某字串尾端時，用來儲存 StrChars 形成的字串  
            public List<FreqString> freqStrings { get; set; }

            public Trie()
            {
                rootOfTrie = new Node();
                freqStrings = new List<FreqString>();
                StrChars = new List<char>();
            }

            public void Insert(string word)
            {
                Node CurrentNode = rootOfTrie;

                foreach (char chr in word)
                {
                    int ModifyIndex = chr - 97;

                    // 若該字母不存在則建立對應的節點
                    if (CurrentNode.ChrPointers[ModifyIndex] == null)
                    {
                        CurrentNode.ChrPointers[ModifyIndex] = new Node();
                    }

                    // 將當前的指針移動到下一個節點
                    CurrentNode = CurrentNode.ChrPointers[ModifyIndex];
                }

                // 標記最後的節點(若要查詢儲存的某字串，就是以這個標記作為搜尋的結尾)
                // 預設為0，表示不為任何字串的結尾
                CurrentNode.StrFrequency++;
            }

            public void DFS(Node CurrentNode)
            {
                // 儲存搜尋到的字串與對應的頻率
                if (CurrentNode.StrFrequency != 0)
                {
                    freqStrings.Add(new FreqString
                    {
                        Word = string.Join("", StrChars),
                        Frequency = CurrentNode.StrFrequency
                    });
                }

                for(int i = 0; i < CurrentNode.ChrPointers.Length; i++)
                {
                    if(CurrentNode.ChrPointers[i] != null)
                    {
                        // 儲存路過的字元
                        StrChars.Add(Convert.ToChar(i + 97));

                        // 從非空的子節點往下遞迴
                        DFS(CurrentNode.ChrPointers[i]);

                        // 恢復字元的儲存狀態，以測試其他的非空子節點
                        StrChars.RemoveAt(StrChars.Count - 1);
                    }
                }
            }

            public void GetAllStrWithFrequcncy()
            {
                DFS(rootOfTrie);
            }
        }
    }
}
