# 題目網址 & 題目簡述  
https://leetcode.com/problems/kth-largest-element-in-an-array/  
  
題目的 Input 為一個整數陣列，以及一個數字K，  
我們的任務是: 找出在這個陣列中第K大的數(注意，是找第K大而不是第K個不同的數字)。  
  
範例1  
輸入 = { 3, 2, 1, 5, 6, 4 } K = 4  
輸出 = 4  
  
範例2  
輸入 = { -1, -1 } K = 2  
輸出 = -1  
  
# 解題思路  
直接將陣列從大到小排序即可輕易取得，超級無敵簡單XD  
  
# UnitTest 使用的測資  
Assert.AreEqual(5, unitTest.FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2));  
Assert.AreEqual(4, unitTest.FindKthLargest(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4));  
Assert.AreEqual(1, unitTest.FindKthLargest(new int[] { 1 }, 1));  
Assert.AreEqual(-1, unitTest.FindKthLargest(new int[] { -1, -1 }, 2));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q215(Kth%20Largest%20Element%20in%20an%20Array)/SuccessShot.PNG)  
&emsp;  
&emsp;  
