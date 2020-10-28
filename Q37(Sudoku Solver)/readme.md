# 題目網址 & 題目簡述  
https://leetcode.com/problems/sudoku-solver/  
  
題目的 Input 為一組數獨(保證有唯一解)，我們必須找出這個唯一解。  
  
# 解題思路  
搜尋尚未填入數字的格子並嘗試填入1~9，若發現當前嘗試的格子再也無法填入任何數字，  
則將當前的格子設成未填入狀態，然後退回到之前的格子，重新調整之前格子所填入的數字，  
重複這個過程直到81格都被填滿。  
  
在填入數字的過程中，不需要每次都將1~9嘗試一遍，只要確保在填入數字X後數獨仍然保持合法，  
才會將X填入到格子中。  
  
要將這個思路轉換成代碼還蠻多細節的，所以在此把大概的代碼流程敘述一下  
步驟1:  
遞迴搜尋下一個可以填入數字的格子  
  
步驟2:  
找到後，嘗試填入適合的數字(假設我們目前所在的堆疊為X)，  
並在X中呼叫遞迴，繼續搜尋下一格(意味著嘗試從X延伸路徑去找答案)  
  
步驟3:  
若中途無法再填入任何數字則程式會退回到X(意味著從X延伸出去的其中一條路徑被切斷)，  
此時在X中，我們將當前的格子設成未填入狀態，並嘗試填入其他適合的數字，  
若發現當前的格子無法再填入任何數字，則程式會退回到X的上一層  
  
# UnitTest 使用的測資  
使用題目給的測資即可，因為懶得去找其他有唯一解的數獨XD  
char[][] Sudoku =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '5', '3', '.', '.', '7', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '6', '.', '.', '1', '9', '5', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '9', '8', '.', '.', '.', '.', '6', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '8', '.', '.', '.', '6', '.', '.', '.', '3' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '4', '.', '.', '8', '.', '3', '.', '.', '1' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '7', '.', '.', '.', '2', '.', '.', '.', '6' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '6', '.', '.', '.', '.', '2', '8', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '4', '1', '9', '.', '.', '5' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '8', '.', '.', '7', '9' }  
};  
  
char[][] Answer =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '5', '3', '4', '6', '7', '8', '9', '1', '2' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '6', '7', '2', '1', '9', '5', '3', '4', '8' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '1', '9', '8', '3', '4', '2', '5', '6', '7' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '8', '5', '9', '7', '6', '1', '4', '2', '3' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '4', '2', '6', '8', '5', '3', '7', '9', '1' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '7', '1', '3', '9', '2', '4', '8', '5', '6' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '9', '6', '1', '5', '3', '7', '2', '8', '4' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '2', '8', '7', '4', '1', '9', '6', '3', '5' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '3', '4', '5', '2', '8', '6', '1', '7', '9' }  
};  
  
testClass.SolveSudoku(Sudoku);  
  
for(int i = 0; i < 9; i++)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;for (int j = 0; j < 9; j++)  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;if(Sudoku[i][j] != Answer[i][j])  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.Fail();  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}  
&nbsp;&nbsp;&nbsp;&nbsp;}  
}  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q37(Sudoku%20Solver)/SuccessShot.PNG)  
&emsp;  
&emsp;  
