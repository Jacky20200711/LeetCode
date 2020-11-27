# 題目網址 & 題目簡述  
https://leetcode.com/problems/3sum/  
  
題目的 input 為一維整數陣列，  
我們的任務是 : 找出陣列中相加為0的三個數字，其所有的組合。  
  
注意事項有三個  
1.每個組合的內部排列必須由小到大，假設其中一個組合為 { a, b, c } 則輸出時要確保 a <= b <= c  
2.答案中不能出現重複的組合  
3.不需要將找出來的組合做排序，  
假設答案有兩種組合 { -4, 2, 2 } 和 { -2, 1, 1 }，則返回的串列可以為下列任意一種  
串列1 = { { -4, 2, 2 }, { -2, 1, 1 } }  
串列2 = { { -2, 1, 1 }, { -4, 2, 2 } }  
  
範例1:  
輸入 = { -1, 0, 1, 2, -1, -4 }  
輸出 = { { -1, -1, 2 }, { -1, 0, 1 } } or { { -1, 0, 1 }, { -1, -1, 2 } }  
  
範例2:  
輸入 = { 0, 0, 0, 0, 0, 0 }  
輸出 = { 0, 0, 0 }  
  
# 解題思路  
1.將原陣列排序，令我們可以使用 Two pointer algorithm，並且令找出的組合保持 a <= b <= c  
2.將 a + b + c = 0 想成 a + b = -c  
3.掃描陣列並且令遇到的每一個數(nums[i])都充當一次 -c (即固定住nums[i]，但若重複出現則跳過)  
4.使用 Two pointer algorithm 從 nums[i+1] ~ nums.last() 搜尋兩數相加為 -c 的所有組合  
  
Two pointer algorithm 的主要用途為 "在已排序的陣列中，搜尋所有兩數相加為特定值的組合"，  
其主要的思路如下  
首先，使用兩個指針，分別指到陣列的最左和最右，  
接著，持續觀察這兩個值相加的狀況，  
若太大則將右指針左移一格，  
若太小則將左指針右移一格，  
若相等則儲存這個組合，並在儲存後將右指針左移一格、左指針右移一格，然後繼續搜尋新的組合。  
  
在這一題中，為了避免儲存到重複的組合，  
若右指針左移之後的值沒有變則繼續左移，若左指針右移之後的值沒有變則繼續右移。  
  
# UnitTest 使用的測資  
// -------------------------------------------------------------  
answer = new List<IList<int>>  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ -1, -1, 2 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ -1,  0, 1 },  
};  
  
verify = UnitTest.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });  
  
Assert.AreEqual(true, HasSameContent(answer, verify));  
// -------------------------------------------------------------  
answer = new List<IList<int>>();  
  
verify = UnitTest.ThreeSum(new int[] { });  
  
Assert.AreEqual(true, HasSameContent(answer, verify));  
// -------------------------------------------------------------  
answer = new List<IList<int>>();  
  
verify = UnitTest.ThreeSum(new int[] { 0 });  
  
Assert.AreEqual(true, HasSameContent(answer, verify));  
// -------------------------------------------------------------  
answer = new List<IList<int>>  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 0, 0, 0 },  
};  
  
verify = UnitTest.ThreeSum(new int[] { 0, 0, 0, 0, 0, 0 });  
  
Assert.AreEqual(true, HasSameContent(answer, verify));  
// -------------------------------------------------------------  
answer = new List<IList<int>>  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ -2, 0, 2 },  
};  
  
verify = UnitTest.ThreeSum(new int[] { -2, 0, 0, 2, 2 });  
  
Assert.AreEqual(true, HasSameContent(answer, verify));  
// -------------------------------------------------------------  
answer = new List<IList<int>>  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ -2, 0, 2 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ -2, 1, 1 },  
};  
  
verify = UnitTest.ThreeSum(new int[] { -2, 0, 1, 1, 2 });  
  
Assert.AreEqual(true, HasSameContent(answer, verify));  
// -------------------------------------------------------------  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q15(3Sum)/SuccessShot.PNG)  
&emsp;  
&emsp;  
