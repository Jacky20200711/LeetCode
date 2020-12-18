# 題目網址 & 題目簡述  
https://leetcode.com/problems/remove-duplicate-letters/  
  
題目的 input 為一個字串，  
我們的任務是 : 去除重複出現的字母，令每個字母都只出現一次。  
  
注意事項:  
1.輸入的字串只會包含小寫字母  
2.答案裡面的字元順序，必須和原字串中的順序相同  
舉例 : 若輸入 = "ccba" 則輸出 = "cba"  
  
3.若可能的答案有多個，則必須取字典順序最小的那個  
舉例 : 若輸入 = "bcabc" 則可能的答案 = { "bca", "bac", "cab", "abc" }  
我們必須令答案 = "abc"  
  
其他範例:  
輸入 = "cbacdcbc"  
輸出 = "acdb"  
  
# 解題思路  
首先，創建一個 stack 來儲存當前答案(使用 char[] 來模擬 stack 的效率比較好)，  
接著，計算各個字母的出現頻率，另外還需要一個用來標記各字母是否被拜訪過的 HashTable，  
然後掃描字串，當遇到未拜訪的字元X時，進行下列的步驟使答案可以保持最小的字典順序  
1.若X比當前答案的最後一個字元Y小，且Y之後還會再度出現(即頻率不為0)，則將Y從當前的答案中取出  
2.重複步驟一，直到取出所有該取出的字元後，將X添加到當前的答案尾端  
  
以 "bcabc" 舉例  
一開始先將第1個字元 "b" 直接添加到答案，並且更新頻率和拜訪標記，  
然後從第2個字元開始掃描字串，  
首先遇到 "c"，由於該字元比 "b" 大而且尚未被拜訪，  
所以添加到答案並將 "c" 標記成已拜訪，此時答案 = "bc"  
  
再來遇到 "a"，  
由於 "a" 比當前答案的最後一個字元 "c" 小且尚未被拜訪，且 "c" 後面還會再度出現，  
所以我們取出 "c" 並將 "c" 標記成未拜訪，此時答案 = "b"  
  
由於 "a" 仍然比當前答案的最後一個字元 "b" 小，且 "b" 後面還會再度出現，  
所以我們取出 "b" 並將 "b" 標記成未拜訪，當前答案 = ""  
  
而在取出所有該取出的字元後，  
我們將 "a" 添加到答案並將 "a" 標記成已拜訪，當前答案 = "a"  
  
接著繼續往下掃描字串，  
再來遇到 "b"，由於該字元比 "a" 大且尚未被拜訪，所以直接添加到答案，此時答案 = "ab"  
再來遇到 "c"，由於該字元比 "a" 大且尚未被拜訪，所以直接添加到答案，此時答案 = "abc"  
掃描完畢，最終的答案 = "abc"  
  
# UnitTest 使用的測資  
Assert.AreEqual("abc", UnitTest.RemoveDuplicateLetters("bcabc"));  
Assert.AreEqual("acdb", UnitTest.RemoveDuplicateLetters("cbacdcbc"));  
Assert.AreEqual("a", UnitTest.RemoveDuplicateLetters("a"));  
Assert.AreEqual("abcde", UnitTest.RemoveDuplicateLetters("eabcde"));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q316(Remove%20Duplicate%20Letters)/SuccessShot.PNG)  
&emsp;  
&emsp;  
