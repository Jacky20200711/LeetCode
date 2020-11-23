# 題目網址 & 題目簡述  
https://leetcode.com/problems/longest-consecutive-sequence/  
  
題目的 Input 為未排序的一維整數陣列，我們的任務是 : 取得最長的遞增序列其長度。  
※遞增的意思是相鄰兩數的值只差1  
  
範例1:  
輸入 = { 1, 2, 0, 1 }  
輸出 = 3 (因為最長的遞增序列 = { 0, 1, 2 })  
  
範例2:  
輸入 = { }  
輸出 = 0  
  
# 解題思路  
將陣列排序後，從頭檢查是否遞增，過程中只要處理三種情況即可  
1.遇到重複的數則忽略  
2.若遞增成功則嘗試更新答案  
3.若遞增中斷則表示遇到新的序列，需要重新累計其長度  
  
# UnitTest 使用的測資  
Assert.AreEqual(4, unitTest.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 }));  
Assert.AreEqual(9, unitTest.LongestConsecutive(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }));  
Assert.AreEqual(0, unitTest.LongestConsecutive(new int[] { }));  
Assert.AreEqual(1, unitTest.LongestConsecutive(new int[] { 1 }));  
Assert.AreEqual(1, unitTest.LongestConsecutive(new int[] { 3, 6 }));  
Assert.AreEqual(4, unitTest.LongestConsecutive(new int[] { 5, 7, 9, 10, 4, 8 }));  
Assert.AreEqual(3, unitTest.LongestConsecutive(new int[] { 1, 2, 0, 1 }));  
Assert.AreEqual(1, unitTest.LongestConsecutive(new int[] { 1, 1, 1 }));  
Assert.AreEqual(4, unitTest.LongestConsecutive(new int[] { 5, 7, 9, 10, 4, 8, 8, 7, 7, 9, 10 }));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q128(Longest%20Consecutive%20Sequence)/SuccessShot.PNG)  
&emsp;  
&emsp;  
