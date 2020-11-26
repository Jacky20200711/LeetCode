# 題目網址 & 題目簡述  
https://leetcode.com/problems/move-zeroes/  
  
題目的 Input 為一個數字陣列，我們必須將陣列裡面的零全部往後挪，  
非零的部分則保持原本的順序。  
  
範例1:  
輸入 = [0,1,0,3,12]  
輸出 = [1,3,12,0,0]  
  
範例2:  
輸入 = [1,0,3,2,0]  
輸出 = [1,3,2,0,0]  
  
# 解題思路  
持續將遇到的非零數字往左填，最後再從右邊往左填入零(零的數量 = 陣列長度 - 非零數字的數量)  
  
舉例:  
當 Input = [0,1,0,3,4]  
從頭往右搜尋，發現非零數字1 -> 將1填入nums[0] -> 當前陣列 = [1,1,0,3,4]  
繼續往右搜尋，發現非零數字3 -> 將3填入nums[1] -> 當前陣列 = [1,3,0,3,4]  
繼續往右搜尋，發現非零數字4 -> 將4填入nums[2] -> 當前陣列 = [1,3,4,3,4]  
  
我們在中途遇到了3個非零數字，所以零的數量 = 5 - 3 = 2  
從右邊填入第1個零後，當前陣列 = [1,3,12,3,0]  
從右邊填入第2個零後，當前陣列 = [1,3,12,0,0] = 正確的 Output  
  
# UnitTest 使用的測資  
arr1 = new int[] {};  
arr2 = new int[] {};  
Assert.AreEqual(true, testClass.MoveZeroes(arr1, arr2));  
  
arr1 = new int[] { 1,2 };  
arr2 = new int[] { 1,2 };  
Assert.AreEqual(true, testClass.MoveZeroes(arr1, arr2));  
  
arr1 = new int[] { 0,0,0,1,2 };  
arr2 = new int[] { 1,2,0,0,0 };  
Assert.AreEqual(true, testClass.MoveZeroes(arr1, arr2));  
  
arr1 = new int[] { 0, 1, 0, 3, 12 };  
arr2 = new int[] { 1, 3, 12, 0, 0 };  
Assert.AreEqual(true, testClass.MoveZeroes(arr1, arr2));  
  
# 提交結果  
![image](https://github.com/Jacky20200711/LeetCode/blob/master/Q283(Move%20Zeroes)/SuccessShot.PNG?raw=true)  
&emsp;  
&emsp;  
