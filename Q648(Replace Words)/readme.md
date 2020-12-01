# 題目網址 & 題目簡述  
https://leetcode.com/problems/replace-words/  
  
這題的 input 為包含很多字串的串列，以及一個句子(也是字串，內含很多用空白分隔的單字)，  
若串列中的字串 S 恰為單字 W 的 prefix，則必須使用 S 來替換掉 W，  
若存在很多符合的 S 則我們必須選用最短的 S 來替換掉 W，  
我們的任務是 : 將句子中必須替換掉的單字全部替換掉。  
※除了用來分隔的空白字元外，只需要考慮英文小寫  
  
範例1:  
輸入 = { "cat", "bat", "rat" }，sentence = "the cattle was rattled by the battery"  
輸出 = "the cat was rat by the bat"  
  
範例2:  
輸入 = { "catt", "cat", "bat", "rat" }，sentence = "the cattle was rattled by the battery"  
輸出 = "the cat was rat by the bat"  
  
# 解題思路  
這題是 Trie 的延伸題型，所以在解這一題之前，建議要先解過 Trie 的基本題(連結如下)  
https://github.com/Jacky20200711/LeetCode/tree/master/Q208(Implement%20Trie)  
  
在學會 Trie 的基本觀念與實作之後，我們先將題目給的句子以空白字元進行切割，  
然後再將切割後的單字一個個丟進 Trie 看有沒有可以替換的字串，  
主要的思路為修改 prefix 匹配的部分以符合題目的要求，其兩個重點如下  
1.若成功匹配當前的字元，則判斷當前的節點是否為某字串的尾端，若是則返回該字串，若不是則繼續往下匹配。  
2.若中途匹配字元失敗，則表示 Trie 中不存在可以替換的字串，所以返回原本的單字即可。  
  
# UnitTest 使用的測資  
dictionary = new List<string> { "cat", "bat", "rat" };  
sentence = "the cattle was rattled by the battery";  
Assert.AreEqual("the cat was rat by the bat", UnitTest.ReplaceWords(dictionary, sentence));  
  
dictionary = new List<string> { "a", "b", "c" };  
sentence = "aadsfasf absbs bbab cadsfafs";  
Assert.AreEqual("a a b c", UnitTest.ReplaceWords(dictionary, sentence));  
  
dictionary = new List<string> { "a", "aa", "aaa", "aaaa" };  
sentence = "a aa a aaaa aaa aaa aaa aaaaaa bbb baba ababa";  
Assert.AreEqual("a a a a a a a a bbb baba a", UnitTest.ReplaceWords(dictionary, sentence));  
  
dictionary = new List<string> { "catt", "cat", "bat", "rat" };  
sentence = "the cattle was rattled by the battery";  
Assert.AreEqual("the cat was rat by the bat", UnitTest.ReplaceWords(dictionary, sentence));  
  
dictionary = new List<string> { "ac", "ab" };  
sentence = "it is abnormal that this solution is accepted";  
Assert.AreEqual("it is ab that this solution is ac", UnitTest.ReplaceWords(dictionary, sentence));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q648(Replace%20Words)/SuccessShot.PNG)  
&emsp;  
&emsp;  
