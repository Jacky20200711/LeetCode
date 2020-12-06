# 題目網址 & 題目簡述  
https://leetcode.com/problems/prefix-and-suffix-search/  
  
這題沒有直接的 input 與 output，而是要實作一個叫做 WordFilter 的類別，  
我們的任務是 : 令這個類別可以儲存大量字串，並且快速找出能夠同時符合 prefix 和 suffix 的字串。  
  
注意事項:  
1.字串只會包含英文小寫  
2.在儲存所有的字串之後，欲查詢的 prefix 和 suffix 會有很多組，所以必須注重查詢的效率  
3.若符合的字串很多則必須取索引最大的那個並返回其索引，若都不符合則返回 -1  
  
範例1:  
字串 = { "apple", "applee", "appleee" }  
查詢 = { "a", "e" }  
輸出 = 2  
  
範例2:  
字串 = { "apple" }  
查詢 = { "x", "y" }  
輸出 = -1  
  
# 解題思路  
這題是 Trie 的延伸題型，所以在解這一題之前，建議要先解過 Trie 的基本題(連結如下)  
https://github.com/Jacky20200711/LeetCode/tree/master/Q208(Implement%20Trie)  
  
這一題最直覺的解法是將所有的字串都拿去做 prefix 和 suffix 的匹配，  
其查詢期間的時間複雜度 = 字串數量 * (len_prefix + len_suffix)  
  
如果使用 Trie 先將符合 prefix 的字串全部抓出來再分別比對 suffix  
其查詢期間的時間複雜度 = (符合 prefix 的字串數量) * (len_suffix)  
  
可以看出如果符合 prefix 的字串數量很少，那麼使用 Trie 的查詢效率將會壓倒性勝出，  
就算所有的字串都能夠符合，其效率依然略勝，所以這一題應該要用 Trie 來解。  
  
那麼要如何快速抓出符合 prefix 的字串呢?  
我們可以令每個節點都攜帶一個 HashTable，  
並且在插入字串的時候，令每個路過的節點都儲存該字串與對應的索引，  
如此一來，在插入所有的字串之後，任何一個節點都可以立刻告訴我們有哪些字串會路過該節點，  
所以當匹配 prefix 成功的時候，指針最後所停留的節點即可立刻告訴我們期望的資訊。  
  
總結這一題實作的流程如下  
1.建立 Trie  
2.持續插入字串，並且令路過的每個節點都儲存當前字串與對應的索引  
3.若成功匹配 prefix 則返回當前節點的 HashTable (紀錄了所有符合 prefix 的字串與對應的索引)  
4.檢查這些字串所對應的索引，以及是否符合 suffix 並嘗試更新答案  
  
另外我發現兩件事  
1.內建的 EndsWith 比對效率很差，遠不如自行撰寫逐字比對= =  
2.有些測資會大量查詢重複的配對，所以將查詢過的配對與答案紀錄起來可以提升效率  
  
# UnitTest 使用的測資  
words = new string[] { "apple" };  
wordFilter = UnitTest.GetWordFilter(words);  
Assert.AreEqual(0, wordFilter.F("a", "e"));  
  
words = new string[] { "apple" };  
wordFilter = UnitTest.GetWordFilter(words);  
Assert.AreEqual(-1, wordFilter.F("x", "y"));  
  
words = new string[] { "apple", "apple", "apple" };  
wordFilter = UnitTest.GetWordFilter(words);  
Assert.AreEqual(2, wordFilter.F("a", "e"));  
  
words = new string[] { "apple", "applee", "appleee" };  
wordFilter = UnitTest.GetWordFilter(words);  
Assert.AreEqual(2, wordFilter.F("a", "e"));  
  
words = new string[] { "bird" };  
wordFilter = UnitTest.GetWordFilter(words);  
Assert.AreEqual(0, wordFilter.F("bird", "bird"));  
  
words = new string[] { "cabaabaaaa", "ccbcababac", "bacaabccba", "bcbbcbacaa", "abcaccbcaa", "accabaccaa", "cabcbbbcca", "ababccabcb", "caccbbcbab", "bccbacbcba" };  
wordFilter = UnitTest.GetWordFilter(words);  
Assert.AreEqual(9, wordFilter.F("bccbacbcba", "a"));  
Assert.AreEqual(4, wordFilter.F("ab", "abcaccbcaa"));  
Assert.AreEqual(5, wordFilter.F("a", "aa"));  
Assert.AreEqual(0, wordFilter.F("cabaaba", "abaaaa"));  
Assert.AreEqual(8, wordFilter.F("cacc", "accbbcbab"));  
Assert.AreEqual(1, wordFilter.F("ccbcab", "bac"));  
Assert.AreEqual(2, wordFilter.F("bac", "cba"));  
Assert.AreEqual(5, wordFilter.F("ac", "accabaccaa"));  
Assert.AreEqual(3, wordFilter.F("bcbb", "aa"));  
Assert.AreEqual(1, wordFilter.F("ccbca", "cbcababac"));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q745(Prefix%20and%20Suffix%20Search)/SuccessShot.PNG)  
&emsp;  
&emsp;  
