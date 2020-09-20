# 題目網址 & 題目簡述  
https://leetcode.com/problems/missing-number/  
      
題目的 Input 為 0,1,2...,N 當中的 N 個數字，Output 為缺少的那個數字。    

範例1:  
當 Input = [9,6,4,2,3,5,7,0,1]  
則 Output = 8  

範例2:  
當 Input = [0,1]  
則 Output = 2  

# 解題思路  
創建一個長度為 (N+1) 的 HashTable，將出現過的數字存到對應的 Index，   
例如看到 3 時，就令 HashTable[3] = 3，  
之後只要檢查 HashTable，若 HashTable[i] 不等於 i，就表示數字 i 沒有出現過。  

舉例:  
當 Input = [1,2,3,4]  
令 HashTable 的初始值 = [-1,0,0,0,0]  
將 Input 的每個值都存到 HashTable 之後，HashTable = [-1,1,2,3,4]  
用個迴圈檢查 HashTable 裡面的值，發現 HashTable[0] != 0，表示數字 0 沒有出現過。

# UnitTest 使用的測資  
Assert.AreEqual(0, testClass.MissingNumber(new int[0]));  
Assert.AreEqual(1, testClass.MissingNumber(new int[1] { 0 }));  
Assert.AreEqual(0, testClass.MissingNumber(new int[1] { 1 }));  
Assert.AreEqual(2, testClass.MissingNumber(new int[2] { 0, 1 }));  
Assert.AreEqual(0, testClass.MissingNumber(new int[2] { 1, 2 }));  
Assert.AreEqual(1, testClass.MissingNumber(new int[2] { 0, 2 }));  
Assert.AreEqual(2, testClass.MissingNumber(new int[3] { 3, 0, 1 }));  
Assert.AreEqual(0, testClass.MissingNumber(new int[3] { 1, 2, 3 }));  
Assert.AreEqual(8, testClass.MissingNumber(new int[9] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));     
  
# 提交結果  
![image](https://github.com/Jacky20200711/LeetCode/blob/master/Q268(Missing%20Number)/SuccessShot.PNG?raw=true)
&emsp;
&emsp;
