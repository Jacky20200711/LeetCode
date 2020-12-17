# 題目網址 & 題目簡述  
https://leetcode.com/problems/restore-ip-addresses/  
  
題目的 input 為一個字串(只會包含數字字元)，  
我們的任務是 : 找出這個字串可能代表的 IP Address !  
  
範例1:  
輸入 = "25525511135"  
輸出 = { "255.255.11.135", "255.255.111.35" }  
  
範例2:  
輸入 = ""  
輸出 = {}  
  
# 解題思路  
使用遞迴製造出所有可能的情況，  
假設 IP Address 有 A.B.C.D 四個部分，每個遞迴的堆疊會對應到其中一個部份，  
假設當前在堆疊X，則我們會在X嘗試製造當前的部分。  
  
以 "25525511135" 舉例  
在第一層的遞迴會開始製造A部分，其流程大概如下  
1.從 index = 0 開始取1個字元(即令A部分 = "2")  
2.將當前A部分的右界傳入第二層，以讓下一層遞迴從該位置製造B部分  
3.遞迴搜尋完畢後，移除當前儲存的A部分(準備製造另一個可能的A)  
  
※接下來的過程中要小心越界  
※若是0開頭則為不合法的數字，直接返回即可  
4.從 index = 0 開始取2個字元(即令A部分 = "25")  
5.將當前A部分的右界傳入第二層，以讓下一層遞迴從該位置製造B部分  
6.遞迴搜尋完畢後，移除當前儲存的A部分(準備製造另一個可能的A)  
  
7.從 index = 0 開始取3個字元(即令A部分 = "255")  
8.將當前A部分的右界傳入第二層，以讓下一層遞迴從該位置製造B部分  
9.遞迴搜尋完畢後即返回，因為每個部份只可能是1~3位數。  
  
若遞迴的過程中，當前的右界到達了字串尾端並且已經湊齊了四個部分，表示我們成功找到一組答案，  
若遞迴的過程中，當前的右界到達了字串尾端但尚未湊齊四個部分則直接返回。  
  
重新整理一下，整個遞迴函數的實作流程大概如下  
1.檢查當前的右界位置，以及是否湊齊了四個部分  
2.從當前位置開始取1個字元組成當前部分，之後遞迴取下一個部分  
3.從當前位置開始取2個字元組成當前部分，之後遞迴取下一個部分(注意越界 & 開頭是否為0)  
4.從當前位置開始取3個字元組成當前部分，之後遞迴取下一個部分(注意越界 & 當前部分是否小於256)  
  
# UnitTest 使用的測資  
Answer = new List<string> { "255.255.11.135", "255.255.111.35" };  
Verify = UnitTest.RestoreIpAddresses("25525511135");  
Assert.AreEqual(true, CompareStrList(Answer, Verify));  
  
Answer = new List<string> { "0.0.0.0" };  
Verify = UnitTest.RestoreIpAddresses("0000");  
Assert.AreEqual(true, CompareStrList(Answer, Verify));  
  
Answer = new List<string> { "1.1.1.1" };  
Verify = UnitTest.RestoreIpAddresses("1111");  
Assert.AreEqual(true, CompareStrList(Answer, Verify));  
  
Answer = new List<string> { "0.10.0.10", "0.100.1.0" };  
Verify = UnitTest.RestoreIpAddresses("010010");  
Assert.AreEqual(true, CompareStrList(Answer, Verify));  
  
Answer = new List<string> { "1.0.10.23", "1.0.102.3", "10.1.0.23", "10.10.2.3", "101.0.2.3" };  
Verify = UnitTest.RestoreIpAddresses("101023");  
Assert.AreEqual(true, CompareStrList(Answer, Verify));  
  
Answer = new List<string> { };  
Verify = UnitTest.RestoreIpAddresses("0");  
Assert.AreEqual(true, CompareStrList(Answer, Verify));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q93(Restore%20IP%20Addresses)/SuccessShot.PNG)  
&emsp;  
&emsp;  
