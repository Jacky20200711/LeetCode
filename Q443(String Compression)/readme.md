# 題目網址 & 題目簡述  
https://leetcode.com/problems/string-compression/  
  
題目的 input 為一個字元陣列，  
我們的任務是 : 將連續出現的字元壓縮成數字，並將結果寫回原陣列並返回壓縮後的長度。  
※若只會連續出現一次，則壓縮後即為字元本身。  
  
範例1:  
輸入 = { "a", "a", "b", "b", "c", "c", "c" }  
壓縮後的字串 = "a2b2c3"，其長度 = 6  
我們必須將原陣列的前 6 個字元改寫成 = { "a", "2", "b", "2", "c", "3" } 並 return 6  
  
範例2:  
輸入 = { "a" }  
輸出 = { "a" } & return 1  
  
# 解題思路  
創建一個變數來追蹤當前欲寫入的原陣列位置(預設為0)，  
創建一個變數來追蹤當前的字元(預設為chars[0])，  
創建一個變數來累計當前的字元頻率(預設為1)，  
然後從第2個字元開始掃描陣列，只需要考慮兩種情況  
1.若和上一個字元相同則累加其頻率  
2.若和上一個字元不同，則將之前追蹤的字元與頻率寫回原陣列，並更新追蹤的字元並重設頻率。  
  
注意，在掃瞄完成之後，還必須將最後一組字元和頻率寫入原陣列，  
因為最後那組字元無法再碰到不同字元，所以不會在掃描進行的時候被寫入。  
  
# UnitTest 使用的測資  
CharArray = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };  
Assert.AreEqual(6, UnitTest.Compress(CharArray));  
  
CharArray = new char[] { 'a' };  
Assert.AreEqual(1, UnitTest.Compress(CharArray));  
  
CharArray = new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };  
Assert.AreEqual(4, UnitTest.Compress(CharArray));  
  
CharArray = new char[] { 'a', 'a', 'a', 'b', 'b', 'a', 'a' };  
Assert.AreEqual(6, UnitTest.Compress(CharArray));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q443(String%20Compression)/SuccessShot.PNG)  
&emsp;  
&emsp;  
