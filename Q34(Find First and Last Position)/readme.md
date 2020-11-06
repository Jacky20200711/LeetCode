# 題目網址 & 題目簡述  
https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/  
  
題目的 Input 為一個排序過的一維陣列，以及一個數字，  
我們的任務是: 找出這個數字第一次和最後一次出現在陣列的索引。  
  
範例輸入1:  
Array = { 5, 7, 7, 8, 8, 10 } & TargetNumber = 8  
  
範例輸出1:  
Output = { 3, 4 }  
  
範例輸入2:  
Array = { 1, 1, 1, 1, 1 } & TargetNumber = 1  
  
範例輸出2:  
Output = { 0, 4 }  
  
※ 若 TargetNumber 不在陣列中，則返回 { -1, -1 }  
  
# 解題思路  
先做一次二分搜尋，假設取得的目標數字索引為X，則將陣列看成兩個部分:  
Part1.陣列最前端~Array[X-1]  
Part2.Array[X+1]~陣列最尾端  
  
然後對 Part1 做二分搜尋，若成功搜尋到，則令X往左移動到新索引，  
重複這個步驟直到找不到目標數字為止，最後X會停在第一次出現該數字的索引。  
  
接著對 Part2 做二分搜尋，若成功搜尋到，則令X往右移動到新索引，  
重複這個步驟直到找不到目標數字為止，最後X會停在最後一次出現該數字的索引。  
  
# UnitTest 使用的測資  
int[] sample = new int[] { 5, 7, 7, 8, 8, 10 };  
int[] verify = UnitTest.SearchRange(sample, 6);  
int[] answer = new int[] { -1, -1 };  
Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));  
  
sample = new int[] { 5, 7, 7, 8, 8, 10 };  
verify = UnitTest.SearchRange(sample, 8);  
answer = new int[] { 3, 4 };  
Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));  
  
sample = new int[] { };  
verify = UnitTest.SearchRange(sample, 0);  
answer = new int[] { -1, -1 };  
Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));  
  
sample = new int[] { 1,1,1,1,1,1,1,1,1,1};  
verify = UnitTest.SearchRange(sample, 1);  
answer = new int[] { 0, 9 };  
Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q34(Find%20First%20and%20Last%20Position)/SuccessShot.PNG)  
&emsp;  
&emsp;  
