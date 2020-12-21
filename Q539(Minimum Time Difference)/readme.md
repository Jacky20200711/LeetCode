# 題目網址 & 題目簡述  
https://leetcode.com/problems/minimum-time-difference/  
  
題目的 input 為一個字串陣列，每一個字串用來表示一個時間，  
我們的任務是 : 找出最小的時間差(單位為分鐘)。  
  
範例1:  
輸入 = { "23:59", "00:00" }  
輸出 = 1  
  
範例2:  
輸入 = { "12:12", "00:13" }  
輸出 = 719  
  
# 解題思路  
將時間做排序後，其最小差值必定出現在相鄰的兩個時間，  
或是頭尾相減的兩個時間(假設排序後為 00:00 00:05 23:59，則答案為頭尾相差的1分鐘)，  
我一開始的作法是直接將字串使用 LINQ 做排序，然後再持續將相鄰的字串轉成分鐘後相減，  
雖然這樣做比較直覺，但是提交後的效率很差，估計是用 LINQ 對字串做排序很耗時。。。  
  
後來改用另一種作法，由於合法的時間只有1440種(00:00~23:59)，  
所以可將字串代表的時間，映射到大小為1440的陣列(例如 "14:20" = 60 * 14 + 20 = 860)，  
如果重複映射到相同的索引，即代表出現重複的時間，直接返回0即可，  
在過程中我們使用兩個變數，來追蹤最小與最大的映射索引，以方便定位之後要檢查的映射區間，  
而在映射完畢後，也相當於對時間做完了排序，  
之後再仿造先前的思路，對於映射的索引區間，檢查其頭尾以及相鄰的時間差即可。  
  
整個實作的流程大概如下  
1.由於合法的時間只有1440種，所以若字串數量大於1440即代表出現重複的時間，直接返回0即可。  
2.將時間映射到大小為1440的陣列，並追蹤最小與最大的映射索引(用來定位之後要檢查的區間)  
3.對於映射的索引區間，檢查其頭尾差值，並持續搜尋相鄰的時間並計算差值。  
  
# UnitTest 使用的測資  
timePoints = new List<string> { "23:59", "00:00" };  
Assert.AreEqual(1, UnitTest.FindMinDifference(timePoints));  
  
timePoints = new List<string> { "00:00", "23:59", "00:00" };  
Assert.AreEqual(0, UnitTest.FindMinDifference(timePoints));  
  
timePoints = new List<string> { "00:00", "23:59", "00:05" };  
Assert.AreEqual(1, UnitTest.FindMinDifference(timePoints));  
  
timePoints = new List<string> { "00:00", "00:55", "00:00" };  
Assert.AreEqual(0, UnitTest.FindMinDifference(timePoints));  
  
timePoints = new List<string> { "12:12", "00:13" };  
Assert.AreEqual(719, UnitTest.FindMinDifference(timePoints));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q539(Minimum%20Time%20Difference)/SuccessShot.PNG)  
&emsp;  
&emsp;  
