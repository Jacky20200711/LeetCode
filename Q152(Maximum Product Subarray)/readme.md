# 題目網址 & 題目簡述  
https://leetcode.com/problems/maximum-product-subarray/  
  
題目的 Input 為一個一維陣列(只包含整數)，我們的任務是 : 找出最大的連續乘積。  
  
範例1:  
輸入 = { 1, 2, 3 }  
輸出 = 6  
  
範例2:  
輸入 = { -1, 0 }  
輸出 = 0  
  
# 解題思路  
觀察後可以發現，在子序列中添加一個新的數字時，有三種數字可能取代原本的答案  
1.新的數字本身  
2.新的數字 * 之前序列的最大連續乘積  
3.新的數字 * 之前序列的最小連續乘積(可能負負得正)  
  
代碼流程大概如下  
1.持續考慮新加入的數，並持續維護當前序列最大與最小的連續乘積  
2.檢查當前序列的最大連續乘積可否取代當前的答案  
※由於不知道答案所在的子序列是否包含新的數，所以每次加入新的數都必須嘗試更新答案  
  
# UnitTest 使用的測資  
Assert.AreEqual(0, unitTest.MaxProduct(new int[] { -1, 0 }));  
Assert.AreEqual(6, unitTest.MaxProduct(new int[] { 2, 3, -2, 4 }));  
Assert.AreEqual(0, unitTest.MaxProduct(new int[] { -2, 0, -1 }));  
Assert.AreEqual(2, unitTest.MaxProduct(new int[] { 0, -1, -2 }));  
Assert.AreEqual(6, unitTest.MaxProduct(new int[] { 1, 2, 3 }));  
Assert.AreEqual(8, unitTest.MaxProduct(new int[] { 1, 2, 3, 0, 8 }));  
Assert.AreEqual(8, unitTest.MaxProduct(new int[] { -1, -2, -2, -2 }));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q152(Maximum%20Product%20Subarray)/SuccessShot.PNG)  
&emsp;  
&emsp;  
