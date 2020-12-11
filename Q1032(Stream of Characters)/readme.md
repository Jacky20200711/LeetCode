# 題目網址 & 題目簡述  
https://leetcode.com/problems/stream-of-characters/  
  
這題沒有直接的 input 與 output，而是需要實作一個叫做 StreamChecker 的類別，  
這個類別的任務如下  
1.儲存大量給定的字串(words)  
2.持續追蹤不斷輸入的字元串流  
3.判斷輸入某字元後，當前的串流尾端是否為已儲存的字串之一  
※所有的字串只會包含英文小寫  
  
該類別運作的範例:  
words = { "cd", "f" }  
StreamChecker streamChecker = new StreamChecker(words);  
  
streamChecker.query('a');    // return false, current stream is "a"  
streamChecker.query('b');    // return false, current stream is "ab"  
streamChecker.query('c');    // return false, current stream is "abc"  
streamChecker.query('d');    // return true, current stream is "abcd" -> match "cd"  
streamChecker.query('e');    // return false, current stream is "abcde"  
streamChecker.query('f');    // return true, current stream is "abcdef" -> match "f"  
  
# 解題思路  
這題是 Trie 的延伸題型，所以在解這一題之前，建議要先解過 Trie 的基本題(連結如下)  
https://github.com/Jacky20200711/LeetCode/tree/master/Q208(Implement%20Trie)  
  
由於這題必須從字尾開始匹配，所以是以反轉的形式將字串插入 Trie，  
查詢的時候也是將串流以反轉的形式做匹配。  
  
整體的實作流程大概如下  
1.反向插入所有的字串到 Trie  
2.每當有一個字元進入串流，就使用 Trie 反向匹配當前的串流內容  
3.匹配的過程中，若路過的節點為某字串的尾端則代表匹配成功  
4.匹配的過程中，若步驟三的情況沒有出現則代表匹配失敗  
  
# UnitTest 使用的測資  
words = new string[] { "cd", "f", "kl", "app" };  
streamChecker = new Program.StreamChecker(words);  
Assert.AreEqual(false, streamChecker.Query('a'));  
Assert.AreEqual(false, streamChecker.Query('b'));  
Assert.AreEqual(false, streamChecker.Query('c'));  
Assert.AreEqual(true, streamChecker.Query('d'));  
Assert.AreEqual(false, streamChecker.Query('e'));  
Assert.AreEqual(true, streamChecker.Query('f'));  
Assert.AreEqual(false, streamChecker.Query('g'));  
Assert.AreEqual(false, streamChecker.Query('h'));  
Assert.AreEqual(false, streamChecker.Query('i'));  
Assert.AreEqual(false, streamChecker.Query('j'));  
Assert.AreEqual(false, streamChecker.Query('k'));  
Assert.AreEqual(true, streamChecker.Query('l'));  
Assert.AreEqual(false, streamChecker.Query('a'));  
Assert.AreEqual(false, streamChecker.Query('p'));  
Assert.AreEqual(true, streamChecker.Query('p'));  
Assert.AreEqual(false, streamChecker.Query('p'));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q1032(Stream%20of%20Characters)/SuccessShot.PNG)  
&emsp;  
&emsp;  
