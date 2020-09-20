# 題目網址 & 題目簡述  
https://leetcode.com/problems/factorial-trailing-zeroes/  
  
題目的 Input 為一個數字 n，Output 為 n! 尾端有多少個零。  

範例1:  
假設 Input 的 n = 5，則 5! = 120，其尾端有1個零，所以 Output = 1  

範例2:  
假設 Input 的 n = 12，則 12! = 479001600，其尾端有2個零，所以 Output = 2  
  
# 解題思路  
想像一下，當 n! 轉成質因數連續相乘的時候，如果要使尾端多一個零，就必須多一組 2 * 5，    
但是2的數量肯定會比5多，所以我們只需要計算5的數量。  

在連續相乘的過程中，每多出一個5的倍數(暫稱X)，我們就會多一個5可以拿來用，  
假設X為5^2的倍數，那就會額外再多一個5可以拿來用，  
假設X為5^3的倍數，那就會額外再再多一個5可以拿來用，  
假設X為5^4的倍數，那就會額外再再再多一個5可以拿來用，  
...以此類推  
  
所以，假設 Input 的 n = 625，則將 625! 轉成質因數連續相乘時，     
5的數量 = 625/5 + 625/(5^2) + 625/(5^3) + 625/(5^4) = 156  

# UnitTest 使用的測資  
Assert.AreEqual(0, testClass.TrailingZeroes(3));  
Assert.AreEqual(1, testClass.TrailingZeroes(5));  
Assert.AreEqual(1, testClass.TrailingZeroes(6));  
Assert.AreEqual(2, testClass.TrailingZeroes(10));  
Assert.AreEqual(6, testClass.TrailingZeroes(25));  
Assert.AreEqual(156, testClass.TrailingZeroes(625));  
Assert.AreEqual(536870902, testClass.TrailingZeroes(2147483647));  

# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q172(Factorial%20Trailing%20Zeroes)/SuccessShot.PNG)
&emsp;
&emsp;
