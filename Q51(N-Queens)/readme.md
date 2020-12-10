# 題目網址 & 題目簡述  
https://leetcode.com/problems/n-queens/  
  
題目的 input 為一個正整數 N (1 <= N <= 9)  
我們的任務是 : 找出所有將 N 個皇后放置在 N*N 棋盤的合法情況。  
  
皇后的放置規則如下  
1.不能使兩個以上的皇后出現在同一個 row  
2.不能使兩個以上的皇后出現在同一個 column  
3.不能使兩個以上的皇后出現在同一個 X 的斜線與反斜線  
  
範例1:  
輸入 = 4  
輸出 =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;".Q..",  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"...Q",  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"Q...",  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"..Q."  
&nbsp;&nbsp;&nbsp;&nbsp;},  
  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"..Q.",  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"Q...",  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"...Q",  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;".Q.."  
&nbsp;&nbsp;&nbsp;&nbsp;},  
}  
  
範例2:  
輸入 = 1  
輸出 = { { "Q" } }  
  
# 解題思路  
首先，製造並保存每一個 row 可能的情況，  
假設 N = 4，則 PossibleRow = { "Q...", ".Q..", "..Q.", "...Q"}  
  
然後，使用 BackTracking 將所有可能的情況插入到棋盤的每一列，實作的大概流程如下  
1.在棋盤第 X 列插入 PossibleRow 的其中一種情況  
2.若棋盤仍然合法，則遞迴搜尋以此前提的所有情況(即繼續插入棋盤的第 X+1 與之後的列)  
3.清空棋盤第 X 列並重複步驟一(對於第 X 列，必須將 PossibleRow 內的所有情況都試過一遍)  
4.若棋盤在插入第 N 列後仍然保持合法，代表成功找到了一組答案  
  
# UnitTest 使用的測資  
/* N = 4 */  
answer = new List<IList<string>>  
{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new List<string>{ ".Q..", "...Q", "Q...", "..Q." },  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new List<string>{ "..Q.", "Q...", "...Q", ".Q.." },  
};  
  
Assert.AreEqual(true, HasSameContent(answer, UnitTest.SolveNQueens(4)));  
  
/* N = 1 */  
answer = new List<IList<string>>  
{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new List<string>{ "Q" },  
};  
  
Assert.AreEqual(true, HasSameContent(answer, UnitTest.SolveNQueens(1)));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q51(N-Queens)/SuccessShot.PNG)  
&emsp;  
&emsp;  
