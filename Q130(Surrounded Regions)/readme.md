# 題目網址 & 題目簡述  
https://leetcode.com/problems/surrounded-regions/  
  
題目的 Input 為一組二維陣列(只含O和X兩種字元)，我們的任務是 : 將被X包圍的O字元全部設成X字元。  
※注意，邊界的外圍不算是X，所以範例的第一個字元不算是被X包圍。  
  
範例輸入 = {  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{ 'O', 'X', 'X', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{ 'X', 'O', 'O', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{ 'X', 'X', 'O', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{ 'X', 'X', 'X', 'O'},  
};  
  
範例輸出 = {  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{ 'O', 'X', 'X', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{ 'X', 'X', 'X', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{ 'X', 'X', 'X', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{ 'X', 'X', 'X', 'O'},  
};  
  
# 解題思路  
觀察後可以發現，若同一區域(即沒有被X阻隔)的所有O字元中，有位在邊界的O字元，  
則表示這個區域的O字元不會被包圍(因為可以從邊界外圍逃跑XD)，反之則會被包圍。  
  
代碼流程大概如下  
1.搜尋尚未拜訪過的O字元  
2.從該字元使用 BFS 來取得同一區域(即沒有被X阻隔)的所有O字元  
3.判斷這一區域的O字元是否有出現在邊界，若沒有則將這個區域的所有O字元設成X  
4.重複上述步驟  
  
# UnitTest 使用的測資  
// -------------------------------------------------------------  
char[][] region =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'X', 'X', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'O', 'O', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'X', 'O', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'O', 'X', 'X'},  
};  
  
char[][] answer =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'X', 'X', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'X', 'X', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'X', 'X', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'O', 'X', 'X'},  
};  
  
unitTest.Solve(region);  
  
Assert.AreEqual(true, HasSameContent(region, answer));  
// -------------------------------------------------------------  
region = new char[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'O', 'X', 'X', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'O', 'O', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'X', 'O', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'X', 'X', 'O'},  
};  
  
answer = new char[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'O', 'X', 'X', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'X', 'X', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'X', 'X', 'X'},  
&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'X', 'X', 'X', 'O'},  
};  
  
unitTest.Solve(region);  
  
Assert.AreEqual(true, HasSameContent(region, answer));  
// -------------------------------------------------------------  
region = new char[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'O' },  
};  
  
answer = new char[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new char[] { 'O' },  
};  
  
unitTest.Solve(region);  
  
Assert.AreEqual(true, HasSameContent(region, answer));  
// -------------------------------------------------------------  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q130(Surrounded%20Regions)/SuccessShot.PNG)  
&emsp;  
&emsp;  
