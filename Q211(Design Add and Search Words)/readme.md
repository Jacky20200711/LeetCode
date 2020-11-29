# 題目網址 & 題目簡述  
https://leetcode.com/problems/design-add-and-search-words-data-structure/  
  
這題沒有直接的 input 與 output，而是需要我們實作一個叫做 WordDictionary 的類別，  
我們的任務是 : 令這個類別可以插入字串，並且快速判斷已儲存的字串中是否包含欲搜尋的字串。  
※題目插入的字串只會包含英文小寫與表示萬用字元的小數點  
  
# 解題思路  
如果不需要考慮萬用字元，則用個 HashTable 就可以輕鬆解決，  
這題的困難點就在於如何判斷 "含有萬用字元的字串" 是否可以 match 到已儲存的某字串，  
目前我所知道的，和從頭 match 字串有關的資料結構只有 Trie  
而且題目的 Hint 也直接告訴我們在解這題之前，應該要先解過關於 Trie 的基本題(連結如下)  
https://github.com/Jacky20200711/LeetCode/tree/master/Q208(Implement%20Trie)  
  
在學會了 Trie 的基本觀念與實作之後，修改搜尋字串的部分以符合這一題的要求，兩個重點如下  
1.若遇到任意字元，必須使用 DFS 來測試當前節點所有的子節點，一路展開所有可能的延伸路徑。  
2.若不是任意字元，則依照原本的方式做線性搜尋(但需要配合第一個重點並改寫成 DFS 的形式)。  
  
# UnitTest 使用的測資  
wordDictionary.AddWord("bad");  
wordDictionary.AddWord("dad");  
wordDictionary.AddWord("mad");  
  
Assert.AreEqual(false, wordDictionary.Search("pad"));  
Assert.AreEqual(true, wordDictionary.Search("bad"));  
Assert.AreEqual(true, wordDictionary.Search(".ad"));  
Assert.AreEqual(true, wordDictionary.Search("b.."));  
Assert.AreEqual(true, wordDictionary.Search("..."));  
Assert.AreEqual(true, wordDictionary.Search("..d"));  
Assert.AreEqual(false, wordDictionary.Search("...."));  
Assert.AreEqual(false, wordDictionary.Search(".."));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q211(Design%20Add%20and%20Search%20Words)/SuccessShot.PNG)  
&emsp;  
&emsp;  
