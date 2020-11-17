# 題目網址 & 題目簡述  
https://leetcode.com/problems/set-matrix-zeroes/  
  
題目的 Input 為一個 M*N 的二維陣列，  
我們的任務是 : 將元素值為零的那一整個 row 和 column 都設成零。  
  
範例輸入 = {  
&nbsp;&nbsp;&nbsp;&nbsp;{ 0, 1, 2, 0 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 3, 4, 5, 2 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 1, 3, 1, 5 },  
}  
  
範例輸出 = {  
&nbsp;&nbsp;&nbsp;&nbsp;{ 0, 0, 0, 0 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 0, 4, 5, 0 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 0, 3, 1, 0 },  
}  
  
# 解題思路  
1.將出現過零的 row 和 col 紀錄到 HashTable  
2.取出 HashTable 的內容並將對應的 row 或 col 所有的值設成零  
  
# UnitTest 使用的測資  
// -------------------------------------------------------------  
int[][] matrix =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 1, 1, 1 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 1, 0, 1 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 1, 1, 1 },  
};  
  
int[][] answer =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 1, 0, 1 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 0, 0, 0 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 1, 0, 1 },  
};  
  
unitTest.SetZeroes(matrix);  
  
Assert.AreEqual(true, HasSameContent(matrix, answer));  
// -------------------------------------------------------------  
matrix = new int[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new int[] { 0, 1, 2, 0 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[] { 3, 4, 5, 2 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[] { 1, 3, 1, 5 },  
};  
  
answer = new int[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 0, 0 ,0, 0 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 0, 4, 5, 0 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 0, 3, 1, 0 },  
};  
  
unitTest.SetZeroes(matrix);  
  
Assert.AreEqual(true, HasSameContent(matrix, answer));  
// -------------------------------------------------------------  
matrix = new int[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new int[] { 1 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[] { 0 },  
};  
  
answer = new int[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new int[] { 0 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[] { 0 },  
};  
  
unitTest.SetZeroes(matrix);  
  
Assert.AreEqual(true, HasSameContent(matrix, answer));  
// -------------------------------------------------------------  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q73(Set%20Matrix%20Zeroes)/SuccessShot.PNG)  
&emsp;  
&emsp;  
