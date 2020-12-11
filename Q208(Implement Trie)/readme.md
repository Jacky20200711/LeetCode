# 題目網址 & 題目簡述  
https://leetcode.com/problems/implement-trie-prefix-tree/  
  
這題沒有直接的 input 與 output，而是需要實作一個叫做 Trie 的類別，其任務如下  
1.儲存大量的字串  
2.判斷欲查詢的字串是否為已儲存的字串之一  
3.判斷已儲存的字串之中，是否含有欲查詢的 prefix  
※需要考慮的字元只有英文小寫  
  
# 解題思路  
這題的重點在於如何快速判斷 "已插入的字串中" 是否含有特定的 prefix，  
如果使用 HashTable 把出現過的 prefix 全部儲存下來，則會將整體的時間複雜度拉高到O(n^2)，  
為了更有效率的解決這個問題，可以改用一種叫做 Trie 的樹狀結構，假設只考慮小寫的 26 個字母，  
那麼 Trie 的每個節點都會包含 26 個節點，分別代表對應的 26 個字母是否存在。  
  
想像有一個指針P，在一開始的時候指向 Trie 的根節點，  
則插入 "ab" 的運作情況大致如下  
剛開始 P['a'] = null  
  
插入字元 a 之後，指針P前往新增的節點  
P['a'] = new Node()  
P = P['a']  
  
插入字元 b 之後，指針P前往新增的節點，並在欲插入字串的結尾做標記  
P['b'] = new Node()  
P = P['b']  
P.IsStringEnd = true  
  
若要判斷是否插入過特定字串，兩個重點  
1.從 Trie 的根節點持續往下檢查對應的字母節點，若中途發現對應的節點為空則表示該字串不存在。  
2.若對應的字母節點都不為空，還必須檢查最後到達的節點是否為之前插入的某字串尾端。  
  
若要判斷已插入的字串中是否含有特定的前序，兩個重點  
1.從 Trie 的根節點持續往下檢查對應的字母節點，若中途發現對應的節點為空則表示該前序不存在。  
2.若對應的字母節點都不為空即表示搜尋成功。  
  
藉由這個特殊的資料結構，我們成功地將插入、搜尋、前序搜尋，其整體的複雜度降成了O(n)~XD  
  
# UnitTest 使用的測資  
trie.Insert("apple");  
Assert.AreEqual(true, trie.Search("apple"));  
Assert.AreEqual(false, trie.Search("app"));  
Assert.AreEqual(true, trie.StartsWith("app"));  
trie.Insert("app");  
Assert.AreEqual(true, trie.Search("app"));  
Assert.AreEqual(false, trie.Search("appl"));  
Assert.AreEqual(true, trie.StartsWith("appl"));  
Assert.AreEqual(false, trie.Search("bbc"));  
Assert.AreEqual(false, trie.StartsWith("bbc"));  
trie.Insert("bbc");  
Assert.AreEqual(true, trie.Search("bbc"));  
Assert.AreEqual(true, trie.StartsWith("bbc"));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q208(Implement%20Trie)/SuccessShot.PNG)  
&emsp;  
&emsp;  
