# 題目網址 & 題目簡述  
https://leetcode.com/problems/map-sum-pairs/  
  
這題沒有直接的 input 與 output，而是需要實作一個叫做 MapSum 的類別，其任務如下  
1.儲存大量的字串  
2.找出所有符合特定 prefix 的字串，並累加其對應的字串值  
※需要考慮的字元只有英文小寫  
  
# 解題思路  
這題是 Trie 的延伸題型，所以在解這一題之前，建議要先解過 Trie 的基本題(連結如下)  
https://github.com/Jacky20200711/LeetCode/tree/master/Q208(Implement%20Trie)  
  
這一題最直覺的解法是用 HashTable 儲存所有的字串，再拿 prefix 去比對所有已儲存的字串，  
時間複雜度 = O(prefix.length * 已儲存的字串數量)  
  
如果改用 Trie 去搜尋，  
時間複雜度 = O(prefix.length + 所有 "符合的字串長度 - prefix.length" 的加總)  
  
可以看出當 prefix 很長而且插入字串的數量很龐大的時候，使用 Trie 應該會有更好的效率，  
雖然這一題的測資看起來沒有很大，但我想要練習 Trie 所以採用 Trie 去搜尋，  
而在學會了 Trie 的基本觀念與實作之後，我們可以輕易地將判斷字串結尾的變數改成題目給定的字串值，  
並修改匹配 prefix 的部分以符合這一題的要求，其兩個重點如下  
1.當匹配 prefix 成功之後，當前的指針會指向 prefix 最後一個字元所對應的節點X  
2.由於X底下所有的字串開頭必然符合，所以我們從X開始往下做 DFS 來搜尋出所有的字串即可XD  
  
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
