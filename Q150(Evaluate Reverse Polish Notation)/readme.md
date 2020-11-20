# 題目網址 & 題目簡述  
https://leetcode.com/problems/evaluate-reverse-polish-notation/  
  
題目的 Input 為一個表示 Postfix 運算式的字串陣列(只包含整數或加減乘除)，  
我們的任務是 : 計算這個運算式的結果。  
※題目保證運算式絕對有效，所以不需要考慮除以零的問題。  
※除法只需要取整數的部分，小數的部分可直接忽略。  
  
範例1:  
輸入 = { "3", "2", "-" }  
輸出 = 1  
  
範例2:  
輸入 = { "3", "2", "/" }  
輸出 = 1  
  
# 解題思路  
原本撰寫計算機的時候，需要將運算式從中序(Infix)轉成後序(Postfix)以方便程式做計算，  
但這一題直接給了 Postfix 的運算式，所以我們直接對它做運算即可。  
  
代碼的流程大概如下  
1.創建一個 Stack  
2.循序掃描 Postfix 運算式，若遇到數字則加入 Stack，反之則 Pop 出兩個數字做運算後再 Push 回去。  
3.最後的計算結果位在 Stack 的頂端，將它 Pop 出來即可。  
  
# UnitTest 使用的測資  
Assert.AreEqual(9, unitTest.EvalRPN(new string[] { "2", "1", "+", "3", "\*" }));  
Assert.AreEqual(6, unitTest.EvalRPN(new string[] { "4", "13", "5", "/", "+" }));  
Assert.AreEqual(2, unitTest.EvalRPN(new string[] { "2" }));  
Assert.AreEqual(1, unitTest.EvalRPN(new string[] { "3", "2", "-" }));  
Assert.AreEqual(1, unitTest.EvalRPN(new string[] { "3", "2", "/" }));  
Assert.AreEqual(22,unitTest.EvalRPN(new string[] { "10", "6", "9", "3", "+", "-11", "\*", "/", "\*", "17", "+", "5", "+" }));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q150(Evaluate%20Reverse%20Polish%20Notation)/SuccessShot.PNG)  
&emsp;  
&emsp;  
