﻿using System;

namespace Q37_Sudoku_Solver_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool RepeatInRow(char[][] board, int row, char digitChar)
        {
            for(int j = 0; j < 9; j++)
            {
                if(board[row][j] == digitChar)
                {
                    return true;
                }
            }
            return false;
        }

        public bool RepeatInCol(char[][] board, int col, char digitChar)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i][col] == digitChar)
                {
                    return true;
                }
            }
            return false;
        }

        public bool RepeatInBox(char[][] board, int row, int col, char digitChar)
        {
            // 取得此九宮格左上角的索引
            row = (row / 3) * 3;
            col = (col / 3) * 3;

            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    if (board[i][j] == digitChar)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool BackTracking(char[][] board, int row, int col)
        {
            // 成功填到 board[8][8] 後， row 會被設成 9
            if (row == 9) return true;

            if (board[row][col] != '.')
            {
                // 遞迴前往下一個格子
                return BackTracking(board, col == 8 ? row + 1 : row, col == 8 ? 0 : col + 1);
            }

            // 嘗試填入1~9
            for (int i = 1; i < 10; i++)
            {
                // 將數字轉成字元
                char digitChar = Convert.ToChar(i + 48);

                // 檢查是否可以填入這個字元，若可以則填入
                if (!RepeatInRow(board, row, digitChar) && 
                    !RepeatInCol(board, col, digitChar) &&
                    !RepeatInBox(board, row, col, digitChar))
                {
                    board[row][col] = digitChar;

                    // 遞迴前往下一個格子
                    if (BackTracking(board, col == 8 ? row + 1 : row, col == 8 ? 0 : col + 1)) return true;

                    // 若遞迴解題失敗，則恢復這個格子的狀態 & 嘗試填入其他的數字
                    board[row][col] = '.';
                }
            }

            // 若 1~9 都無法填入，則切斷這個分支
            return false;
        }

        public void SolveSudoku(char[][] board)
        {
            BackTracking(board, 0, 0);
        }
    }
}
