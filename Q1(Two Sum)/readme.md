# 題目網址 & 題目簡述  
https://leetcode.com/problems/two-sum/  
  
題目的 input 為一維整數陣列，以及一個目標數字(target)，  
我們的任務是 : 找出陣列中相加為 target 的兩個數字，並返回對應的索引(題目保證有唯一解)。  
  
範例1:  
輸入 = { 2, 7, 11, 15 } & target = 9  
輸出 = { 0, 1 }  
  
範例2:  
輸入 = { 2, 3, 2, 3  } & target = 6  
輸出 = { 1, 3 }  
  
# 解題思路  
創建一個字典(HashTable)用來儲存出現過的數字與對應的索引，並將陣列的第一個數存入字典，  
接著從 i = 1 開始掃描陣列，過程中只需要處理兩種情況  
1.若 target 和當前元素的差值出現在字典，則表示已找到答案並返回對應的索引  
2.若差值沒有出現在字典，則將當前的元素存入字典  
  
# UnitTest 使用的測資  
sample = new int[] { 2, 7, 11, 15 };  
verify = UnitTest.TwoSum(sample, 9);  
answer = new int[] { 0, 1 };  
Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));  
  
sample = new int[] { 2, 3, 2, 3 };  
verify = UnitTest.TwoSum(sample, 6);  
answer = new int[] { 1, 3 };  
Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q1(Two%20Sum)/SuccessShot.PNG)  
&emsp;  
&emsp;  
