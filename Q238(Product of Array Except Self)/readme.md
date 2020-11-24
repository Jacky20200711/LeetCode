# 題目網址 & 題目簡述  
https://leetcode.com/problems/product-of-array-except-self/  
  
題目的 input 為一維整數陣列，  
我們的任務是 : 找出所有 "除了自己以外的所有元素乘積"  
  
舉例 : 假如 input 的長度 = 4，則我們必須依序取得以下的乘積  
當 i = 0，計算 nums[1] * nums[2] * nums[3]  
當 i = 1，計算 nums[0] * nums[2] * nums[3]  
當 i = 2，計算 nums[0] * nums[1] * nums[3]  
當 i = 3，計算 nums[0] * nums[1] * nums[2]  
  
範例1:  
輸入 = { 1, 2, 3, 4 }  
輸出 = { 24, 12, 8, 6 }  
  
範例2:  
輸入 = { 1, 2, 3, 0 }  
輸出 = { 0, 0, 0, 6 }  
  
# 解題思路  
1.用兩個陣列分別紀錄前序與後序的連續乘積  
令 prefix_mul[i] 表示 nums[0] ~ nums[i] 的連續乘積  
令 postfix_mul[i] 表示 nums[i] ~ nums[nums.length-1] 的連續乘積  
  
2.接著就可以輕易取得索引i對應的答案(即位置i之前的連續乘積 * 位置i之後的連續乘積)  
answer[i] = prefix_mul[i - 1] * postfix_mul[i + 1];  
  
# UnitTest 使用的測資  
sample = new int[] { 1, 2, 3, 4 };  
verify = unitTest.ProductExceptSelf(sample);  
answer = new int[] { 24, 12, 8, 6 };  
Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));  
  
sample = new int[] { 1, 2, 3, 0 };  
verify = unitTest.ProductExceptSelf(sample);  
answer = new int[] { 0, 0, 0, 6 };  
Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q238(Product%20of%20Array%20Except%20Self)/SuccessShot.PNG)  
&emsp;  
&emsp;  
