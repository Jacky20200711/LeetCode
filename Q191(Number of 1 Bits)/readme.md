# 題目網址 & 題目簡述  
https://leetcode.com/problems/number-of-1-bits/  
   
題目的 Input 為一個 unsigned integer，Output 為該數字轉成二進位時所擁有的 1 bit 數目。  
  
例如 Input = 11，轉成二進位後為 00000000000000000000000000001011，  
其中有 3 個 Bit 為 1，所以 Output = 3  
  
# 解題思路  
->修改十進位轉二進位的除法過程，使用位元運算來取代除法和取餘數以增進效能   
假設 Input = n，則解題步驟如下
1.將 n 和 1 做 AND 運算，若運算結果 > 0，就代表 n 的最後一位 Bit 為 1
2.對 n 做右移運算，去除已經觀察過的 Bit 
3.持續做步驟1和步驟2，直到 n = 0  

# UnitTest 使用的測資  
Assert.AreEqual(0,  testClass.HammingWeight(0));  
Assert.AreEqual(1,  testClass.HammingWeight(1));  
Assert.AreEqual(3,  testClass.HammingWeight(11));  
Assert.AreEqual(1,  testClass.HammingWeight(128));  
Assert.AreEqual(31, testClass.HammingWeight(4294967293));  
Assert.AreEqual(32, testClass.HammingWeight(4294967295));   
  
# 提交結果  
![image](https://github.com/Jacky20200711/LeetCodeWithUnitTest/blob/master/Q191(Number%20of%201%20Bits)/SuccessShot.PNG?raw=true)
&emsp;
&emsp;
