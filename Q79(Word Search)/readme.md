# 題目網址 & 題目簡述  
https://leetcode.com/problems/word-search/  
  
題目的 Input 為一組 N*M 字元陣列，以及一個欲搜尋的字串，  
  
從字元陣列獲取字串的規則如下:  
1.只能循序獲取水平或垂直相鄰的字元  
2.同樣位置的字元只能被獲取一次  
  
我們的任務是: 驗證是否可以從字元陣列中，獲取欲搜尋的字串。  
  
# 解題思路  
使用類似解數獨的思路(BackTracking)，  
當搜尋到字串的第一個字元後，嘗試從該位置開始遞迴(往上下左右搜尋下一個字元)，  
若遞迴途中發現上下左右都沒有符合的字元，則退回到之前的格子，並嘗試從該格子的另一個方向搜尋，  
重複這個過程直到搜尋結束。  
  
要將這個思路轉換成代碼並不容易，所以在此把主要的代碼流程敘述一下  
步驟1:  
迴圈搜尋字串的第一個字元。  
  
步驟2:  
找到後，進入第一層遞迴(假設當前所在的堆疊為X)，  
然後在X中測試上下左右的格子是否符合下一個字元(即有沒有可以從X延伸的路徑)，  
若有符合的格子Y，則將Y設成已路過，然後在X中，往Y呼叫遞迴並持續搜尋。  
  
步驟3:  
若中途發現沒有可以延伸的方向，則程式會退回到X(意味著從X延伸出去的其中一條路徑被切斷)，  
此時在X中，我們將Y設回未路過，並嘗試從X的其他方向進行延伸，  
若發現X沒有可以延伸的方向，則程式會退回到X的上一層。  
  
# UnitTest 使用的測資  
char[][] board = new char[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new char[]{'A', 'B', 'C', 'E'},  
&nbsp;&nbsp;&nbsp;&nbsp;new char[]{'S', 'F', 'C', 'S'},  
&nbsp;&nbsp;&nbsp;&nbsp;new char[]{'A', 'D', 'E', 'E'},  
};  
  
Assert.AreEqual(true, UnitTest.Exist(board, "ABCCED"));  
Assert.AreEqual(true, UnitTest.Exist(board, "F"));  
Assert.AreEqual(false, UnitTest.Exist(board, "ABCB"));  
Assert.AreEqual(false, UnitTest.Exist(board, "X"));  
Assert.AreEqual(true, UnitTest.Exist(board, "BFSADEESECC"));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q79(Word%20Search)/SuccessShot.PNG)  
&emsp;  
&emsp;  
