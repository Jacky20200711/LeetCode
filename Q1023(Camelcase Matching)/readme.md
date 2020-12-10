# 題目網址 & 題目簡述  
https://leetcode.com/problems/camelcase-matching/  
  
題目的 input 為一個字串陣列，以及一個目標字串(pattern)，  
我們的任務是 : 判斷 pattern 可否透過 "插入小寫的字母" 來變成那些給定的字串。  
※可以插入的字母數量為0個或很多個  
  
範例1:  
輸入 = { "FooBar", "FooBarTest", "FootBall", "FrameBuffer" } & pattern = "FB"  
輸出 = { true, false, true, true }  
  
範例2:  
輸入 = { "FB" } & pattern = "FB"  
輸出 = { true }  
  
# 解題思路  
這題最直覺的作法是將每一個 query 去循序匹配 pattern 的字元  
舉例來說，若 query = "abFooBarest" & pattern = "FBat"  
我們會在 query[2] 成功搜尋到 pattern 的第一個字元 "F"，接著再從 Index = 2 繼續往後搜尋，  
我們會在 query[5] 成功搜尋到 pattern 的下一個字元 "B"，接著再從 Index = 5 繼續往後搜尋，  
我們會在 query[6] 成功搜尋到 pattern 的下一個字元 "a"，接著再從 Index = 6 繼續往後搜尋，  
...以此類推  
  
但必須注意的是，就算所有的字元都匹配成功，pattern 也不一定可以變成 query  
例如 query = "FooBarTest" & pattern = "FB"  
雖然 query 可以循序匹配到 pattern 的 "F" 和 "B"，  
但由於 pattern 無法插入大寫字母 "T" 所以無法變身成 query  
  
思考一陣子後，可以將 "就算匹配成功，也不一定能變身成功" 的情況整理如下  
1.如果兩者的大寫字母數量不一樣，則 pattern 不可能單靠插入小寫來變成 query  
2.如果兩者的大寫字母順序不一樣，則 pattern 不可能單靠插入小寫來變成 query  
  
接著，重新整理一下實作的思路，其大概的流程如下  
1.檢查 pattern 的長度，若比 query 長則不可能單靠插入來變身成功  
2.檢查 pattern 和 query 大寫字母的數量和出現順序是否相同  
3.將此 query 循序匹配 pattern 的字元  
4.檢查匹配成功的字元數量，若和 pattern 的長度相同，表示 pattern 可以變成這個 query  
  
# UnitTest 使用的測資  
Queries = new string[] { "FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack" };  
Pattern = "FB";  
Answer = new List<bool>{ true, false, true, true, false };  
Verify = UnitTest.CamelMatch(Queries, Pattern);  
Assert.AreEqual(true, Enumerable.SequenceEqual(Answer, Verify));  
  
Queries = new string[] { "FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack" };  
Pattern = "FoBa";  
Answer = new List<bool> { true, false, true, false, false };  
Verify = UnitTest.CamelMatch(Queries, Pattern);  
Assert.AreEqual(true, Enumerable.SequenceEqual(Answer, Verify));  
  
Queries = new string[] { "FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack" };  
Pattern = "FoBaT";  
Answer = new List<bool> { false, true, false, false, false };  
Verify = UnitTest.CamelMatch(Queries, Pattern);  
Assert.AreEqual(true, Enumerable.SequenceEqual(Answer, Verify));  
  
Queries = new string[] { "CompetitiveProgramming", "CounterPick", "ControlPanel" };  
Pattern = "CooP";  
Answer = new List<bool> { false, false, true };  
Verify = UnitTest.CamelMatch(Queries, Pattern);  
Assert.AreEqual(true, Enumerable.SequenceEqual(Answer, Verify));  
  
Queries = new string[] { "FB" };  
Pattern = "FB";  
Answer = new List<bool> { true };  
Verify = UnitTest.CamelMatch(Queries, Pattern);  
Assert.AreEqual(true, Enumerable.SequenceEqual(Answer, Verify));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q1023(Camelcase%20Matching)/SuccessShot.PNG)  
&emsp;  
&emsp;  
