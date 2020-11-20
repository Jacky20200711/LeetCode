# 題目網址 & 題目簡述  
https://leetcode.com/problems/number-of-islands/  
  
題目的 Input 為一組二維陣列(只含1和0兩種字元)，  
我們的任務是 : 計算被0包圍的1區域數量(注意，邊界的外圍算是0)。  
  
範例輸入:  
sample = new char[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '1','1','1','1','0' },  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '1','1','0','1','0' },  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '1','1','0','0','1' },  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '0','0','1','0','0' },  
};  
  
範例輸出:  
3  
  
# 解題思路  
1.設置一個區域計數器並搜尋 '1' 字元，搜尋到後將計數器+1  
2.從該字元做 DFS 往上下左右搜尋同區域的 '1' 字元，並將路過的 '1' 設成 '0'(表示已經處理過這個區域)  
3.重複上述步驟，搜尋結束後返回計數器的值即可。  
  
# UnitTest 使用的測資  
// -------------------------------------------------------------  
char[][] sample =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '1','1','1','1','0' },  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '1','1','0','1','0' },  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '1','1','0','0','0' },  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '0','0','0','0','0' },  
};  
  
Assert.AreEqual(1, unitTest.NumIslands(sample));  
// -------------------------------------------------------------  
sample = new char[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '1','1','0','0','0' },  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '1','1','0','0','0' },  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '0','0','1','0','0' },  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '0','0','0','1','1' },  
};  
  
Assert.AreEqual(3, unitTest.NumIslands(sample));  
// -------------------------------------------------------------  
sample = new char[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '1','1','1','1','0' },  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '1','1','0','1','0' },  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '1','1','0','0','1' },  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { '0','0','1','0','0' },  
};  
  
Assert.AreEqual(3, unitTest.NumIslands(sample));  
// -------------------------------------------------------------  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q200(Number%20of%20Islands)/SuccessShot.PNG)  
&emsp;  
&emsp;  
