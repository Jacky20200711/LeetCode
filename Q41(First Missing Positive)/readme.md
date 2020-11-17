# 題目網址 & 題目簡述  
https://leetcode.com/problems/first-missing-positive/  
  
題目的 Input 為一個一維陣列，我們的任務是找出陣列中缺漏的最小正數。  
  
範例1:  
輸入 = { -1 }  
輸出 = { 1 }  
  
範例2:  
輸入 = { 1, 2, 0 }  
輸出 = { 3 }  
  
範例3:  
輸入 = { 0, 2, 2, 1, 1 }  
輸出 = { 3 }  
  
# 解題思路  
1.將出現過的正數儲存到 HashTable  
2.持續從1往上累加，直到發現當前的值不在 HashTable 裡面  
  
# UnitTest 使用的測資  
[TestClass()]  
public class ProgramTests  
{  
&nbsp;&nbsp;&nbsp;&nbsp;[TestMethod()]  
&nbsp;&nbsp;&nbsp;&nbsp;public void FirstMissingPositiveTest()  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Program unitTest = new Program();  
  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(3, unitTest.FirstMissingPositive(new int[] { 1, 2, 0 }));  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(2, unitTest.FirstMissingPositive(new int[] { 3, 4, -1, 1 }));  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(1, unitTest.FirstMissingPositive(new int[] { 7, 8, 9, 11, 12 }));  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(1, unitTest.FirstMissingPositive(new int[] { 0 }));  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(1, unitTest.FirstMissingPositive(new int[] { 3 }));  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(1, unitTest.FirstMissingPositive(new int[] { -1 }));  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(2, unitTest.FirstMissingPositive(new int[] { 1 }));  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(3, unitTest.FirstMissingPositive(new int[] { 0, 2, 2, 1, 1 }));  
&nbsp;&nbsp;&nbsp;&nbsp;}  
}  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q41(First%20Missing%20Positive)/SuccessShot.PNG)  
&emsp;  
&emsp;  
