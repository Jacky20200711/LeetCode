# 題目網址 & 題目簡述  
https://leetcode.com/problems/n-queens-ii/  
  
題目的 input 為一個正整數 N (1 <= N <= 9)  
我們的任務是 : 計算有幾種 "將 N 個皇后放置在 N*N 棋盤的合法情況"  
  
皇后的放置規則如下  
1.不能使兩個以上的皇后出現在同一個 row  
2.不能使兩個以上的皇后出現在同一個 column  
3.不能使兩個以上的皇后出現在同一個 X 的斜線與反斜線  
  
範例1:  
輸入 = 1  
輸出 = 1  
  
範例2:  
輸入 = 4  
輸出 = 2  
  
# 解題思路  
這一題雖然名稱為 N-Queens II，但卻是 Q51(N-Queens) 的簡化題型(連結如下)  
https://github.com/Jacky20200711/LeetCode/tree/master/Q51(N-Queens)  
  
在 Q51(N-Queens) 中，我們需要製造出所有合法的放置情況，  
所以在解掉 Q51 之後，只要簡單修改 Q51 的代碼就能取得每個 N 所對應的合法棋盤數量，  
由於答案為固定的 9 種數字，所以我們只需要將這 9 種數字放入 HashTable 來查詢即可。  
  
# UnitTest 使用的測資  
Assert.AreEqual(1, UnitTest.TotalNQueens(1));  
Assert.AreEqual(0, UnitTest.TotalNQueens(2));  
Assert.AreEqual(0, UnitTest.TotalNQueens(3));  
Assert.AreEqual(2, UnitTest.TotalNQueens(4));  
Assert.AreEqual(10, UnitTest.TotalNQueens(5));  
Assert.AreEqual(4, UnitTest.TotalNQueens(6));  
Assert.AreEqual(40, UnitTest.TotalNQueens(7));  
Assert.AreEqual(92, UnitTest.TotalNQueens(8));  
Assert.AreEqual(352, UnitTest.TotalNQueens(9));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q52(N-Queens%20II)/SuccessShot.PNG)  
&emsp;  
&emsp;  
