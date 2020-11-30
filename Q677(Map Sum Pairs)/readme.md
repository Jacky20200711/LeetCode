# 題目網址 & 題目簡述  
https://leetcode.com/problems/map-sum-pairs/  
  
這題沒有直接的 input 與 output，而是需要我們實作一個叫做 MapSum 的類別，  
我們的任務是 : 令這個類別可以插入字串，並且從已儲存的字串中，快速找出所有符合特定 prefix 的字串。  
※題目插入的字串只會包含英文小寫  
  
# 解題思路  
這題是 Trie 的延伸題型，在解這一題之前必須先解過 Trie 的基本題(連結如下)  
https://github.com/Jacky20200711/LeetCode/tree/master/Q208(Implement%20Trie)  
  
這一題最直覺的解法是用 HashTable 儲存所有的字串，再拿 prefix 去比對所有已儲存的字串，  
時間複雜度 = O(prefix 的長度 * 已儲存的字串數量)  
  
如果改用 Trie 去搜尋，  
時間複雜度 = O(prefix 的長度 + 所有 "符合的字串長度 - prefix 的長度" 的加總)  
  
可以看出如果 prefix 很長而且插入字串的數量很龐大，那麼使用 Trie 應該會有更好的效率，  
雖然這一題的測資看起來沒有很大，但我想要練習 Trie 所以採用 Trie 去搜尋，  
而在學會了 Trie 的基本觀念與實作之後，修改 prefix 匹配的部分以符合這一題的要求，重點如下  
1.當匹配 prefix 成功之後，當前的指針會指向 prefix 的最後一個字元節點X  
2.由於X底下所有的字串開頭必然符合，所以我們從X開始往下做 DFS 來搜尋出所有的字串即可。  
  
# UnitTest 使用的測資  
mapSum.Insert("apple", 3);  
Assert.AreEqual(0, mapSum.Sum("b"));  
Assert.AreEqual(3, mapSum.Sum("ap"));  
mapSum.Insert("app", 2);  
Assert.AreEqual(5, mapSum.Sum("ap"));  
mapSum.Insert("apple", 1);  
Assert.AreEqual(1, mapSum.Sum("apple"));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q677(Map%20Sum%20Pairs)/SuccessShot.PNG)  
&emsp;  
&emsp;  
