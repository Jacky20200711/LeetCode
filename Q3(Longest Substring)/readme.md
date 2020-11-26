# 題目網址 & 題目簡述  
https://leetcode.com/problems/longest-substring-without-repeating-characters/  
  
題目的 input 為一個字串，我們的任務是 : 找出不含重複字元的最長子字串其長度。  
  
範例1:  
輸入 = "tmmzuxt"  
輸出 = 5  
  
範例2:  
輸入 = ""  
輸出 = 0  
  
# 解題思路  
創建一個 HashTable 來儲存出現過的數字以及該數字最後出現的索引，  
創建一個變數來儲存當前子字串的左界，  
創建一個變數來儲存所有子字串的最大長度，  
接著，掃描字串並考慮兩種情況即可。  
  
情況一  
若當前的字元已經被包含在之前的子字串(即當前字元的位置大於子字串的左界)，  
則將當前子字串的左界移動到 "上次出現該字元的位置，其右邊一格"  
例如 s = "abcad"，則子字串和其左界的變動情況如下  
下一輪的子字串 = "a" 左界 = 0  
下一輪的子字串 = "ab" 左界 = 0  
下一輪的子字串 = "abc" 左界 = 0  
下一輪的子字串 = "bca" 左界 = 1 (因為左界移動到上次出現 'a' 的右邊一格)  
下一輪的子字串 = "bcad" 左界 = 1  
  
情況二  
若當前的字元沒有被包含在之前的子字串，表示當前子字串的長度增加，  
所以我們要計算當前子字串的長度並檢查是否要更新答案。  
  
這題有一個好玩的地方，剛開始我用 Dictionary 來當 HashTable，提交後的效率很差...  
後來改用 int[] 來當 HashTable 之後效率卻暴增，看來存取陣列的效能遠高於複雜的物件XD  
  
# UnitTest 使用的測資  
Assert.AreEqual(3, UnitTest.LengthOfLongestSubstring("abcabcbb"));  
Assert.AreEqual(1, UnitTest.LengthOfLongestSubstring("bbbbb"));  
Assert.AreEqual(3, UnitTest.LengthOfLongestSubstring("pwwkew"));  
Assert.AreEqual(0, UnitTest.LengthOfLongestSubstring(""));  
Assert.AreEqual(7, UnitTest.LengthOfLongestSubstring("axbcdbcdexyz"));  
Assert.AreEqual(1, UnitTest.LengthOfLongestSubstring("a"));  
Assert.AreEqual(5, UnitTest.LengthOfLongestSubstring("tmmzuxt"));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q3(Longest%20Substring)/SuccessShot.PNG)  
&emsp;  
&emsp;  
