# 題目網址 & 題目簡述  
https://leetcode.com/problems/valid-sudoku/  
  
題目的 Input 為一組數獨，我們必須要驗證這組數獨是否合法。  

# 解題思路  
解決方法靠直覺就能想到，就是檢查每一列、每一行、和每一個九宮格是否出現重複的數字。  
只是實作上有一些細節需要注意，像是如何抓出每一個九宮格的行與列，  
或是在檢查重複的字元時，記得要忽略小數點。  
  
# UnitTest 使用的測資  
char[][] board1 =  
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
  
char[][] board2 =   
{  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '8', '3', '.', '.', '7', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '6', '.', '.', '1', '9', '5', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '9', '8', '.', '.', '.', '.', '6', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '8', '.', '.', '.', '6', '.', '.', '.', '3' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '4', '.', '.', '8', '.', '3', '.', '.', '1' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '7', '.', '.', '.', '2', '.', '.', '.', '6' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '6', '.', '.', '.', '.', '2', '8', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '4', '1', '9', '.', '.', '5' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '8', '.', '.', '7', '9' }  
};  
  
char[][] board3 =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' }  
};  
  
char[][] board4 =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '1', '.', '1', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },  
&nbsp;&nbsp;&nbsp;&nbsp;new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' }  
};  
  
Assert.AreEqual(true, testClass.IsValidSudoku(board1));  
Assert.AreEqual(false, testClass.IsValidSudoku(board2));  
Assert.AreEqual(true, testClass.IsValidSudoku(board3));  
Assert.AreEqual(false, testClass.IsValidSudoku(board4));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q36(Valid%20Sudoku)/SuccessShot.PNG)
&emsp;
&emsp;
