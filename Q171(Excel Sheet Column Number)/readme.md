# 題目網址 & 題目簡述  
https://leetcode.com/problems/excel-sheet-column-number/  

A 到 Z 分別代表數字 1 到 26  
字串 AA 代表數字 27  
字串 AB 代表數字 28  
字串 ZY 代表數字 701  
  
題目的 Input 為一個字串，Output 為該字串對應的數字。  
  
# 解題思路  
很明顯，題目給的 Input 即代表二十六進位的數字，我們要做的就是把它轉換成十進位的數字，  
拿 ZY 來舉例，其中 Z = 26 、 Y = 25  
則 ZY = 26*(26^1) + 25*(26^0) = 701  

# UnitTest 使用的測資  
Assert.AreEqual(1, testClass.TitleToNumber("A"));  
Assert.AreEqual(28, testClass.TitleToNumber("AB"));  
Assert.AreEqual(701, testClass.TitleToNumber("ZY"));  
Assert.AreEqual(2147483647, testClass.TitleToNumber("FXSHRXW"));  

# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q171(Excel%20Sheet%20Column%20Number)/SuccessShot.PNG)
&emsp;
&emsp;
