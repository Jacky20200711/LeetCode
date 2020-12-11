using System;
using System.Collections.Generic;
using System.Linq;

namespace Q1032_Stream_of_Characters_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void SearchWord()
        {

        }

        public class Trie
        {
            private readonly Node rootOfTrie = null;

            public Trie()
            {
                rootOfTrie = new Node();
            }

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

            public void Insert(string word)
            {
                Node CurrentNode = rootOfTrie;

                // 插入反轉後的字串到 Trie
                for(int i = word.Length - 1; i > -1; i--)
                {
                    int ModifyIndex = word[i] - 97;

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

            public bool Search(char[] Stream, int NumberOfStreamChar)
            {
                Node CurrentNode = rootOfTrie;

                // 反向匹配串流的字元
                for(int i = NumberOfStreamChar - 1; i > -1; i--)
                {
                    int ModifyIndex = Stream[i] - 97;

                    // 匹配字元失敗
                    if (CurrentNode.ChrPointers[ModifyIndex] == null)
                    {
                        return false;
                    }

                    // 匹配字元成功，將當前的指針移動到下一個節點
                    CurrentNode = CurrentNode.ChrPointers[ModifyIndex];

                    // 查看該節點的標記，確認是否為儲存過的字串尾端
                    if (CurrentNode.IsStringEnd)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public class StreamChecker
        {
            private readonly Trie MyTrie;
            private readonly char[] Stream = new char[40000];
            private int NumberOfStreamChar;

            public StreamChecker(string[] words)
            {
                NumberOfStreamChar = 0;

                MyTrie = new Trie();

                foreach(string word in words)
                {
                    MyTrie.Insert(word);
                }
            }

            public bool Query(char letter)
            {
                Stream[NumberOfStreamChar++] = letter;
                return MyTrie.Search(Stream, NumberOfStreamChar);
            }
        }
    }
}
