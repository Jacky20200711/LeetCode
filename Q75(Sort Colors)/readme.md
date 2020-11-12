# 題目網址 & 題目簡述  
https://leetcode.com/problems/sort-colors/  
  
題目的 Input 為一個只包含數字 0,1,2 的一維陣列，  
我們的任務是: 排序這些數字。  
  
範例:  
Input  = { 2, 0, 2, 1, 1, 0 }  
Output = { 0, 0, 1, 1, 2, 2 }  
  
# 解題思路  
使用 Counting sort 即可，這題太簡單了，感覺應該擺在 Easy 而不是 Medium XD  
  
# UnitTest 使用的測資  
[TestMethod()]  
public void SortColorsTest()  
{  
&nbsp;&nbsp;&nbsp;&nbsp;Program UnitTest = new Program();  
  
&nbsp;&nbsp;&nbsp;&nbsp;int[] sample = new int[] { 2, 0, 2, 1, 1, 0 };  
&nbsp;&nbsp;&nbsp;&nbsp;int[] answer = new int[] { 0, 0, 1, 1, 2, 2 };  
&nbsp;&nbsp;&nbsp;&nbsp;UnitTest.SortColors(sample);  
&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(true, Enumerable.SequenceEqual(sample, answer));  
  
&nbsp;&nbsp;&nbsp;&nbsp;sample = new int[] { 2, 0, 1 };  
&nbsp;&nbsp;&nbsp;&nbsp;answer = new int[] { 0, 1, 2 };  
&nbsp;&nbsp;&nbsp;&nbsp;UnitTest.SortColors(sample);  
&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(true, Enumerable.SequenceEqual(sample, answer));  
  
&nbsp;&nbsp;&nbsp;&nbsp;sample = new int[] { 0 };  
&nbsp;&nbsp;&nbsp;&nbsp;answer = new int[] { 0 };  
&nbsp;&nbsp;&nbsp;&nbsp;UnitTest.SortColors(sample);  
&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(true, Enumerable.SequenceEqual(sample, answer));  
  
&nbsp;&nbsp;&nbsp;&nbsp;sample = new int[] { 1 };  
&nbsp;&nbsp;&nbsp;&nbsp;answer = new int[] { 1 };  
&nbsp;&nbsp;&nbsp;&nbsp;UnitTest.SortColors(sample);  
&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(true, Enumerable.SequenceEqual(sample, answer));  
}  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q75(Sort%20Colors)/SuccessShot.PNG)  
&emsp;  
&emsp;  
