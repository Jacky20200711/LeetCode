# 題目網址 & 題目簡述  
https://leetcode.com/problems/jump-game/  
  
題目的 Input 為一個一維陣列，每一個元素值為大於等於零的整數(即最多可以從該索引跳躍的格子數)，  
我們的任務是 : 判斷是否可以從陣列的第一格跳躍到最後一格。  
  
範例1:  
輸入 = { 2, 0, 0 }  
輸出 = true  
  
範例2:  
輸入 = { 2, 0, 3, 2, 1, 0, 1 }  
輸出 = false  
  
# 解題思路  
觀察後可以發現，當出現無法跨過去的0時，才能夠阻止我們的跳躍XD  
  
代碼的流程大致如下  
1.在遇到0之前，持續計算目前可以到達的最大索引  
2.在遇到0之時，判斷目前可以到達的最大索引是否可以跨過它  
  
有一點必須注意，若遇到的0恰好是位在最後一格，則不需要考慮是否跨得過去。  
  
# UnitTest 使用的測資  
Assert.AreEqual(true, unitTest.CanJump(new int[] { 0 }));  
Assert.AreEqual(true, unitTest.CanJump(new int[] { 2 }));  
Assert.AreEqual(true, unitTest.CanJump(new int[] { 2, 0 }));  
Assert.AreEqual(true, unitTest.CanJump(new int[] { 2, 0, 0 }));  
Assert.AreEqual(true, unitTest.CanJump(new int[] { 2, 3, 1, 1, 4 }));  
Assert.AreEqual(true, unitTest.CanJump(new int[] { 2, 0, 3, 2, 1, 0 }));  
  
Assert.AreEqual(false, unitTest.CanJump(new int[] { 0, 3 }));  
Assert.AreEqual(false, unitTest.CanJump(new int[] { 3, 2, 1, 0, 4 }));  
Assert.AreEqual(false, unitTest.CanJump(new int[] { 2, 0, 3, 2, 1, 0, 1 }));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q55(Jump%20Game)/SuccessShot.PNG)  
&emsp;  
&emsp;  
