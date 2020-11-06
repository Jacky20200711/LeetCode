using System;

namespace Q79_Word_Search_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool BackTracking(char[][] board, bool[][] visit, int i, int j, string word, int CharIndex)
        {
            if (CharIndex + 1 == word.Length) return true;

            int NextIndex;

            // 檢查是否可以往上走
            NextIndex = i - 1;
            if(NextIndex > -1 && !visit[NextIndex][j] && board[NextIndex][j] == word[CharIndex + 1])
            {
                visit[NextIndex][j] = true;
                
                // 往上走 & 繼續遞迴
                if (BackTracking(board, visit, NextIndex, j, word, CharIndex + 1)) return true;

                // 遞迴失敗 & 清除拜訪過的紀錄
                visit[NextIndex][j] = false;
            }

            // 檢查是否可以往下走
            NextIndex = i + 1;
            if (NextIndex < board.Length && !visit[NextIndex][j] && board[NextIndex][j] == word[CharIndex + 1])
            {
                visit[NextIndex][j] = true;
                
                // 往下走 & 繼續遞迴
                if (BackTracking(board, visit, NextIndex, j, word, CharIndex + 1)) return true;
              
                // 遞迴失敗 & 清除拜訪過的紀錄
                visit[NextIndex][j] = false;
            }

            // 檢查是否可以往左走
            NextIndex = j - 1;
            if (NextIndex > -1 && !visit[i][NextIndex] && board[i][NextIndex] == word[CharIndex + 1])
            {
                visit[i][NextIndex] = true;
                
                // 往左走 & 繼續遞迴
                if (BackTracking(board, visit, i, NextIndex, word, CharIndex + 1)) return true;

                // 遞迴失敗 & 清除拜訪過的紀錄
                visit[i][NextIndex] = false;
            }
            
            // 檢查是否可以往右走
            NextIndex = j + 1;
            if (NextIndex < board[0].Length && !visit[i][NextIndex] && board[i][NextIndex] == word[CharIndex + 1])
            {
                visit[i][NextIndex] = true;

                // 往右走 & 繼續遞迴
                if (BackTracking(board, visit, i, NextIndex, word, CharIndex + 1)) return true;

                // 遞迴失敗 & 清除拜訪過的紀錄
                visit[i][NextIndex] = false;
            }
            return false;
        }

        public bool Exist(char[][] board, string word)
        {
            bool[][] visit = new bool[board.Length][];

            for(int i = 0; i < board.Length; i++)
            {
                visit[i] = new bool[board[0].Length];
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    // 若找到目標字串的字首，則嘗試進行搜尋
                    if(board[i][j] == word[0])
                    {
                        visit[i][j] = true;

                        // 從這一格開始遞迴搜尋
                        if (BackTracking(board, visit, i,  j, word, 0)) return true;

                        // 遞迴失敗 & 清除拜訪過的紀錄
                        visit[i][j] = false;
                    }
                }
            }
            return false;
        }
    }
}
