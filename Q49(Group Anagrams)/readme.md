# 題目網址 & 題目簡述  
https://leetcode.com/problems/group-anagrams/  
  
題目的 Input 為一組字串陣列(只含英文小寫)，我們的任務是: 將易位的字串放在同一組。  
※易位的意思是將字串裡面的字元任意排列，例如 abc 可以排列成 acb bac bca cab cba  
  
範例:  
輸入 = { "abc", "acb", "bac", "bca", "cab", "cba", "x" }  
輸出 = { {"abc", "acb", "bac", "bca", "cab", "cba"}, {"x"} }  
  
# 解題思路  
1.觀察同一組的字串，可以發現對每個字串做字元排序後都會得到一樣的結果，  
例如對 acb bac bca cab cba 分別做字元排序後，都會變成 abc  
  
2.將字元排序後的結果當作 Hash Key，將具有相同 Key 的字串放到同一組即可。  
  
# UnitTest 使用的測資  
[TestMethod()]  
public void GroupAnagramsTest()  
{  
&nbsp;&nbsp;&nbsp;&nbsp;Program UnitTest = new Program();  
&nbsp;&nbsp;&nbsp;&nbsp;// --------------------------------------------------------------------------  
&nbsp;&nbsp;&nbsp;&nbsp;string[] Sample = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };  
&nbsp;&nbsp;&nbsp;&nbsp;IList<IList<string>> Tester = UnitTest.GroupAnagrams(Sample);  
&nbsp;&nbsp;&nbsp;&nbsp;IList<IList<string>> Answer = new List<IList<string>>()  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new List<string>  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"eat", "tea", "ate"  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;},  
  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new List<string>  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"tan", "nat"  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;},  
  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new List<string>  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"bat"  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;},  
&nbsp;&nbsp;&nbsp;&nbsp;};  
  
&nbsp;&nbsp;&nbsp;&nbsp;for(int i = 0; i < Answer.Count; i++)  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(true, Enumerable.SequenceEqual(Tester[i], Answer[i]));  
&nbsp;&nbsp;&nbsp;&nbsp;}  
&nbsp;&nbsp;&nbsp;&nbsp;// --------------------------------------------------------------------------  
&nbsp;&nbsp;&nbsp;&nbsp;Sample = new string[] { "" };  
&nbsp;&nbsp;&nbsp;&nbsp;Tester = UnitTest.GroupAnagrams(Sample);  
&nbsp;&nbsp;&nbsp;&nbsp;Answer = new List<IList<string>>()  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new List<string>  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;""  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;},  
&nbsp;&nbsp;&nbsp;&nbsp;};  
  
&nbsp;&nbsp;&nbsp;&nbsp;for (int i = 0; i < Answer.Count; i++)  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(true, Enumerable.SequenceEqual(Tester[i], Answer[i]));  
&nbsp;&nbsp;&nbsp;&nbsp;}  
&nbsp;&nbsp;&nbsp;&nbsp;// --------------------------------------------------------------------------  
&nbsp;&nbsp;&nbsp;&nbsp;Sample = new string[] { "a" };  
&nbsp;&nbsp;&nbsp;&nbsp;Tester = UnitTest.GroupAnagrams(Sample);  
&nbsp;&nbsp;&nbsp;&nbsp;Answer = new List<IList<string>>()  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new List<string>  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"a"  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;},  
&nbsp;&nbsp;&nbsp;&nbsp;};  
  
&nbsp;&nbsp;&nbsp;&nbsp;for (int i = 0; i < Answer.Count; i++)  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(true, Enumerable.SequenceEqual(Tester[i], Answer[i]));  
&nbsp;&nbsp;&nbsp;&nbsp;}  
&nbsp;&nbsp;&nbsp;&nbsp;// --------------------------------------------------------------------------  
&nbsp;&nbsp;&nbsp;&nbsp;Sample = new string[] { "eat", "eat", "eat" };  
&nbsp;&nbsp;&nbsp;&nbsp;Tester = UnitTest.GroupAnagrams(Sample);  
&nbsp;&nbsp;&nbsp;&nbsp;Answer = new List<IList<string>>()  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new List<string>  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"eat", "eat", "eat"  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;},  
&nbsp;&nbsp;&nbsp;&nbsp;};  
  
&nbsp;&nbsp;&nbsp;&nbsp;for (int i = 0; i < Answer.Count; i++)  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(true, Enumerable.SequenceEqual(Tester[i], Answer[i]));  
&nbsp;&nbsp;&nbsp;&nbsp;}  
&nbsp;&nbsp;&nbsp;&nbsp;// --------------------------------------------------------------------------  
&nbsp;&nbsp;&nbsp;&nbsp;Sample = new string[] { "aba", "aaa", "baa", "aaa", "aab" };  
&nbsp;&nbsp;&nbsp;&nbsp;Tester = UnitTest.GroupAnagrams(Sample);  
&nbsp;&nbsp;&nbsp;&nbsp;Answer = new List<IList<string>>()  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new List<string>  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"aba", "baa", "aab"  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;},  
  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new List<string>  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"aaa", "aaa"  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;},  
&nbsp;&nbsp;&nbsp;&nbsp;};  
  
&nbsp;&nbsp;&nbsp;&nbsp;for (int i = 0; i < Answer.Count; i++)  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.AreEqual(true, Enumerable.SequenceEqual(Tester[i], Answer[i]));  
&nbsp;&nbsp;&nbsp;&nbsp;}  
&nbsp;&nbsp;&nbsp;&nbsp;// --------------------------------------------------------------------------  
}  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q49(Group%20Anagrams)/SuccessShot.PNG)  
&emsp;  
&emsp;  
