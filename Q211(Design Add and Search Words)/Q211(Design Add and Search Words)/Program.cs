﻿using System;

namespace Q211_Design_Add_and_Search_Words_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public WordDictionary GetTrie()
        {
            return new WordDictionary();
        }

        public class WordDictionary
        {
            // 每個節點都包含 26 個子節點，分別表示對應的小寫字母
            public class Node
            {
                public bool IsStringEnd { get; set; }

                public Node[] ChrPointers { get; set; }

                public Node()
                {
                    IsStringEnd = false;
                    ChrPointers = new Node[26];
                }
            }

            private readonly Node rootOfTrie = null;

            public WordDictionary()
            {
                rootOfTrie = new Node();
            }

            public void AddWord(string word)
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
                CurrentNode.IsStringEnd = true;
            }

            public bool DFS(Node node, string word, int i)
            {
                if (i == word.Length)
                {
                    // 若所有對應的字母都存在，還需要檢查最後到達的節點是否為儲存過的某字串結尾
                    return node.IsStringEnd;
                }

                // 若不是萬用字元，則沿著字元鏈結做線性搜尋
                if (word[i] != '.' && node.ChrPointers[word[i] - 97] != null)
                {
                    return DFS(node.ChrPointers[word[i] - 97], word, i + 1);
                }
                // 若遇到萬用字元，則測試當前節點的所有子節點
                else if (word[i] == '.')
                {
                    foreach (Node nPtr in node.ChrPointers)
                    {
                        if (nPtr != null)
                        {
                            if(DFS(nPtr, word, i + 1))
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }

            public bool Search(string word)
            {
                return DFS(rootOfTrie, word, 0);
            }
        }
    }
}
