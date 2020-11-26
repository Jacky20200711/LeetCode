# 題目網址 & 題目簡述  
https://leetcode.com/problems/search-in-rotated-sorted-array/  
  
題目的 Input 為排序後會以某個轉軸做左右交換的一維整數陣列(數字不會重複)，以及一個數字(target)，  
我們的任務是: 找出這個數字出現在陣列的索引(若該數字不存在則返回-1)。  
  
範例1:  
輸入 = { 4,5,6,7,0,1,2 } & target = 0  
輸出 = 4  
  
範例2:  
輸入 = { 1 } & target = 0  
輸出 = -1  
  
# 解題思路  
觀察後可以發現，轉軸(pivot)的左右兩邊都會是已排序狀態，  
所以只要找到 pivot 再分別對左右兩邊做二分搜尋即可。  
  
假設 Array = { 4,5,6,7,0,1,2 }，  
則 pivot 的左右兩邊分別為 { 4,5,6,7 } 和 { 0,1,2 }  
我個人是將 pivot 定義成右邊部分的第一個數，所以 pivot 所在的索引為 4  
  
想要找到 pivot 有兩種方法  
1.搜尋整個陣列直到發現下一個數不是變大，而是變小  
2.使用二分搜尋  
EX : 若砍到的值大於 Array 的第一個數，表示 pivot 在右邊  
EX : 若砍到的值小於 Array 的第一個數，表示 pivot 在左邊或恰好為當前砍到的索引  
  
剛開始犯懶使用方法一，雖然可以過關但效率很差，改成方法二後果然效率大幅提升XD  
  
# UnitTest 使用的測資  
Assert.AreEqual(0, unitTest.Search(new int[] { 1, 2, 3 }, 1));  
Assert.AreEqual(0, unitTest.Search(new int[] { 1 }, 1));  
Assert.AreEqual(2, unitTest.Search(new int[] { 3, 0, 1 }, 1));  
Assert.AreEqual(2, unitTest.Search(new int[] { 2, 3, 0, 1 }, 0));  
Assert.AreEqual(4, unitTest.Search(new int[] { 4, 5, 6, 7, 0, 1 }, 0));  
Assert.AreEqual(5, unitTest.Search(new int[] { 4, 5, 6, 1, 2, 3 }, 3));  
Assert.AreEqual(6, unitTest.Search(new int[] { 4, 5, 6, 7, 1, 2, 3 }, 3));  
Assert.AreEqual(1, unitTest.Search(new int[] { 8, 9, 2, 3, 4 }, 9));  
Assert.AreEqual(-1, unitTest.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3));  
Assert.AreEqual(-1, unitTest.Search(new int[] { 1 }, 0));  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q33(Search%20in%20Rotated%20Sorted%20Array)/SuccessShot.PNG)  
&emsp;  
&emsp;  
