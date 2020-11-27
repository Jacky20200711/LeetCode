# 題目網址 & 題目簡述  
https://leetcode.com/problems/generate-parentheses/  
  
題目的 input 為一個數字N，我們的任務是 : 找出所有 "存在N組括號配對" 的字串。  
  
舉例，若 N = 3，其中一個有效字串為 s = "((()))"  
若抽離一組括號配對後，s = "(())"  
再抽離一組括號配對後，s = "()"  
再抽離一組括號配對後，s = ""  
我們的目標就是找出所有 "在抽離N組括號配對後會變成空子串" 的字串。  
  
範例1:  
輸入 = 3  
輸出 = { "((()))", "(()())", "(())()", "()(())", "()()()" }  
  
範例2:  
輸入 = 1  
輸出 = { "()" }  
  
# 解題思路  
使用遞迴，持續在當前字串中添加左括號或右括號來製造出所有可能的字串，過程中只有兩種情況需要注意  
1.若右括號比左括號多，或是左括號的數量大於N時則返回  
2.若右括號成功放入N個則表示找到一組答案，儲存當前字串並返回  
  
# UnitTest 使用的測資  
// --------------------------------------------------------------  
answer = new List<string>  
{  
&nbsp;&nbsp;&nbsp;&nbsp;"((()))", "(()())", "(())()", "()(())", "()()()"  
};  
  
verify = UnitTest.GenerateParenthesis(3);  
  
Assert.AreEqual(true, HasSameContent(answer, verify));  
// --------------------------------------------------------------  
answer = new List<string>  
{  
&nbsp;&nbsp;&nbsp;&nbsp;"()"  
};  
  
verify = UnitTest.GenerateParenthesis(1);  
  
Assert.AreEqual(true, HasSameContent(answer, verify));  
// --------------------------------------------------------------  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q22(Generate%20Parentheses)/SuccessShot.PNG)  
&emsp;  
&emsp;  
