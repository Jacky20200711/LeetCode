# 題目網址 & 題目簡述  
https://leetcode.com/problems/find-peak-element/  
  
題目的 Input 為一個一維陣列(只包含整數)，  
我們的任務是 : 找出任意一個比左右兩邊的值都還要大的值(Peak)，並返回該 Peak 的索引。  
※陣列中相鄰的兩數不會相等，且左右邊界被定義成無限小。  
  
範例1:  
輸入 = { 1, 2 }  
輸出 = 1  
  
範例2:  
輸入 = { 1, 2, 1, 3, 5, 6, 4 }  
輸出 = 1 or 5 都可以  
&emsp;  
&emsp;  
# 解題思路  
使用二分搜尋並考慮下面三種情況即可  
1.若 nums[mid] > 兩邊，則本身就是 Peak  
2.若 nums[mid] < nums[mid+1]，則 nums[mid] 右邊必然存在 Peak  
3.若 nums[mid] < nums[mid-1]，則 nums[mid] 左邊必然存在 Peak  
  
但問題來了，上述的情況2和3為什麼會成立呢?  
想像一下，令當前的 nums = { X1, X2, ..., 10, 11, Y1, Y2, ... }  
令 nums[mid] = 10  
令 nums[mid+1] = 11  
假設情況2不成立，那麼 10 的右邊就不能出現 Peak，  
若要讓 11 不能成為 Peak，則 Y1 必須 > 11，同理，  
若要讓 Y1 不能成為 Peak，則 Y2 必須 > Y1，同理，  
...以此類推  
當一路遞增到最後一個數字後，卻發現最後一個數字必然是 Peak (因為邊界被定義成無限小)，  
所以，我們透過反證法成功證明了情況2會成立XD(情況3同理可證)  
&emsp;  
&emsp;  
# UnitTest 使用的測資  
index = unitTest.FindPeakElement(new int[] { 1, 2, 3, 1 });  
Assert.AreEqual(true, InAnswer(index, new HashSet<int> { 2 }));  
  
index = unitTest.FindPeakElement(new int[] { 1, 2, 1, 3, 5, 6, 4 });  
Assert.AreEqual(true, InAnswer(index, new HashSet<int> { 1, 5 }));  
  
index = unitTest.FindPeakElement(new int[] { 1 });  
Assert.AreEqual(true, InAnswer(index, new HashSet<int> { 0 }));  
  
index = unitTest.FindPeakElement(new int[] { 1, 2, 3, 4 });  
Assert.AreEqual(true, InAnswer(index, new HashSet<int> { 3 }));  
  
index = unitTest.FindPeakElement(new int[] { 1, 2 });  
Assert.AreEqual(true, InAnswer(index, new HashSet<int> { 1 }));  
&emsp;  
&emsp;  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q162(Find%20Peak%20Element)/SuccessShot.PNG)  
&emsp;  
&emsp;  
