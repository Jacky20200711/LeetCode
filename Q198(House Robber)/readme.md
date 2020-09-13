# 題目網址 & 題目簡述  
https://leetcode.com/problems/house-robber/  
   
題目的 Input 為一個數字陣列，Output 為該陣列的間隔累加最大值，  
間隔的意思就是你在累加陣列的元素時，不能有兩個元素是相鄰的，    
因為依照題目，如果連續偷了兩家的錢，則警報系統會自動啟動。  

範例1:  
假設 Input nums = [2,7,9,3,1];  
則 Output = nums[0] + nums[2] + nums[4] = 12  

範例2:  
假設 Input nums = [2,1,1,2];  
則 Output = nums[0] + nums[3] = 4  
  
# 解題思路  
用一個陣列 maxProfit 來紀錄從每個 Index 開始往後偷錢，所能夠獲得的最大利益  
例如 maxProfit[5] 就代表從 nums[5] 開始往後偷錢，所能夠獲得的最大利益  

假設從倒數第一家開始往後偷，由於只剩一家可以偷  
所以 maxProfit[最大的Index] = 倒數第一家的錢     

假設從倒數第二家開始往後偷，由於只有兩家可以偷    
maxProfit[第二大的Index] = max(倒數第一家的錢, 倒數第二家的錢)  

假設從倒數第三家開始往後偷，由於只有三家可以偷  
maxProfit[第三大的Index] = max(倒數第三家的錢+倒數第一家的錢, 倒數第二家的錢)  

假設從倒數第 N 家開始往後偷，下一家偷第 N+2 或 N+3 家都有可能獲得最大利益
maxProfit[N] = 第 N 家的錢 + max(maxProfit[N+2], maxProfit[N+3])
這裡簡單解釋一下，為什麼不用考慮第 N+4 家，  
假設你偷了第 N 家，則挑下一家的時候不可能直接跳到 N+4，因為你還可以多偷第 N+2 家的錢，   
如果你還是不太懂這一步在幹麻，建議把 maxProfit[i] 代表的意思多看幾遍。  

# UnitTest 使用的測資  
Assert.AreEqual(0,  testClass.Rob(new int[0] {  }));  
Assert.AreEqual(1,  testClass.Rob(new int[1] { 1 }));  
Assert.AreEqual(4,  testClass.Rob(new int[2] { 2, 4 }));  
Assert.AreEqual(4,  testClass.Rob(new int[2] { 4, 2 }));  
Assert.AreEqual(4,  testClass.Rob(new int[3] { 1, 2, 3 }));  
Assert.AreEqual(5,  testClass.Rob(new int[3] { 1, 5, 3 }));  
Assert.AreEqual(4,  testClass.Rob(new int[4] { 1, 2, 3, 1 }));  
Assert.AreEqual(4,  testClass.Rob(new int[4] { 2, 1, 1, 2 }));  
Assert.AreEqual(12, testClass.Rob(new int[5] { 2, 7, 9, 3, 1 }));  
Assert.AreEqual(18, testClass.Rob(new int[6] { 6, 6, 6, 6, 6, 6}));  
  
# 提交結果  
![image](https://github.com/Jacky20200711/LeetCodeWithUnitTest/blob/master/Q198(House%20Robber)/SuccessShot.PNG?raw=true)
&emsp;
&emsp;
