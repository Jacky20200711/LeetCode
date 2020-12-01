# 題目網址 & 題目簡述  
https://leetcode.com/problems/top-k-frequent-words/  
  
這題的 input 為一個字串陣列，以及一個數字k，  
我們的任務是 : 將字串按照出現的頻率進行排序之後，取出頻率最高的前k個字串。  
  
注意事項:  
1.字串只會包含英文小寫  
2.數字k必然有效，所以不用考慮越界的問題  
3.頻率相同的字串必須按照字典順序(舉例:若 "bb" 和 "aa" 的出現頻率相同，則 "aa" 必須排在前面)  
  
範例1:  
輸入 = { "i", "love", "leetcode", "i", "love", "coding" }，k = 2  
輸出 = { "i", "love" }  
  
範例2:  
輸入 = { "cc", "bb", "cc", "aa", "bb", "aa" }，k = 3  
輸出 = { "aa", "bb", "cc" }  
  
# 解題思路  
這題是 Trie 的延伸題型，所以在解這一題之前，建議要先解過 Trie 的基本題(連結如下)  
https://github.com/Jacky20200711/LeetCode/tree/master/Q208(Implement%20Trie)  
  
這題最直覺的解法是用 Dictionary 儲存所有的字串與對應的頻率，再設法取出儲存的資訊並排序，  
但這個解法的麻煩點在於取出資訊的過程中，我想不出有效率的辦法來令取出的字串能夠按照字典排序，  
所以改用 Trie 來做，因為在使用 DFS 搜尋 Trie 儲存的字串時，可以確保搜出來的字串會按照字典順序，  
而在取出來所有的字串後，再用 LINQ 的 OrderBy 以頻率來排序即可，  
其中 OrderBy 為穩定排序，可以確保已經按照字典排序好的兩個字串，就算頻率相同也絕對不會左右交換。  
  
總結這一題實作的流程如下  
1.建立 Trie 並將判斷字串結尾的變數改成出現頻率，預設為0(表示不屬於任何字串的尾端)  
2.插入題目給的字串，在到達底端時累加其頻率變數(此變數不為0即表示當前節點為某個已儲存字串的尾端)  
3.使用 DFS 取出所有的字串與對應的頻率(為了方便，我建立了一個類別來封裝字串與對應的頻率)  
4.使用 LINQ 對這些類別以頻率(從大到小)進行排序  
5.取出前k個類別裡面的字串  
  
# UnitTest 使用的測資  
words = new string[]{ "i", "love", "leetcode", "i", "love", "coding" };  
verify = UnitTest.TopKFrequent(words, 2);  
answer = new List<string>{ "i", "love" };  
Assert.AreEqual(true, Enumerable.SequenceEqual(answer, verify));  
  
words = new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" };  
verify = UnitTest.TopKFrequent(words, 4);  
answer = new List<string> { "the", "is", "sunny", "day" };  
Assert.AreEqual(true, Enumerable.SequenceEqual(answer, verify));  
  
words = new string[] { "cc", "bb", "cc", "aa", "bb", "aa" };  
verify = UnitTest.TopKFrequent(words, 3);  
answer = new List<string> { "aa", "bb", "cc" };  
Assert.AreEqual(true, Enumerable.SequenceEqual(answer, verify));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q692(Top%20K%20Frequent%20Words)/SuccessShot.PNG)  
&emsp;  
&emsp;  
