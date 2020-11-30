using System;

namespace Q677_Map_Sum_Pairs_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public MapSum GetTrie()
        {
            return new MapSum();
        }

        public class MapSum
        {
            // 每個節點都包含 26 個子節點，分別表示對應的小寫字母
            public class Node
            {
                public Node[] ChrPointers { get; set; }

                public int NumInStringEnd { get; set; }

                public Node()
                {
                    ChrPointers = new Node[26];
                    NumInStringEnd = 0; // 題目給的字串對應值為 1~1000，所以令預設為0(表示此節點不為任何字串的結尾)
                }
            }

            private readonly Node rootOfTrie = null;

            public MapSum()
            {
                rootOfTrie = new Node();
            }

            public void Insert(string key, int val)
            {
                Node CurrentNode = rootOfTrie;

                foreach (char chr in key)
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

                // 標記字串尾端的節點(若之後要查詢此字串，就是以這個標記作為搜尋的結尾)
                CurrentNode.NumInStringEnd = val;
            }

            public int Sum(string prefix)
            {
                int TotalSum = 0;

                Node CurrentNode = rootOfTrie;

                // 搜尋已儲存的字串中，是否有符合的 prefix
                foreach (char chr in prefix)
                {
                    int ModifyIndex = chr - 97;

                    if (CurrentNode.ChrPointers[ModifyIndex] == null)
                    {
                        return 0;
                    }

                    // 將當前的指針移動到下一個節點
                    CurrentNode = CurrentNode.ChrPointers[ModifyIndex];
                }

                // 當前的指針指向 prefix 的尾端節點
                // prefix 本身可能是已儲存的字串之一，所以累加當前節點的字串值
                TotalSum += CurrentNode.NumInStringEnd;

                // 從這個節點遞迴搜尋出底下的字串並累加對應的字串值
                DFS(CurrentNode, ref TotalSum);
                return TotalSum;
            }


            public void DFS(Node CurrentNode, ref int TotalSum)
            {
                foreach (Node node in CurrentNode.ChrPointers)
                {
                    if (node != null)
                    {
                        TotalSum += node.NumInStringEnd;
                        DFS(node, ref TotalSum);
                    }
                }
            }
        }
    }
}
