# 題目網址 & 題目簡述  
https://leetcode.com/problems/design-add-and-search-words-data-structure/  
  
這題沒有直接的 input 與 output，而是需要實作一個叫做 WordDictionary 的類別，其任務如下  
1.儲存大量的字串  
2.判斷已儲存的字串中是否包含欲搜尋的字串  
※需要考慮的字元只有英文小寫與萬用字元(小數點)  
  
# 解題思路  
這題是 Trie 的延伸題型，所以在解這一題之前，建議要先解過 Trie 的基本題(連結如下)  
https://github.com/Jacky20200711/LeetCode/tree/master/Q208(Implement%20Trie)  
  
如果不需要考慮萬用字元，則使用 HashTable 就可以輕鬆解決，  
這題的困難點就在於如何判斷 "含有萬用字元的字串" 是否可以 match 到已儲存的某字串，  
我們可以修改 Trie 搜尋字串的部分來解這題，兩個重點如下  
1.若遇到任意字元，必須使用 DFS 來測試當前節點所有的子節點，一路展開所有可能的延伸路徑。  
2.若不是任意字元，則依照原本的方式做線性匹配(但需要改寫成 DFS 的形式以配合第一個重點)。  
  
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
