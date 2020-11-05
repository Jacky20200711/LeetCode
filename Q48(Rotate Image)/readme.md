# 題目網址 & 題目簡述  
https://leetcode.com/problems/rotate-image/  
  
題目的 Input 為 N*N 的陣列，我們必須將此陣列的值做順時鐘90度的旋轉。  
  
範例輸入:  
Sample =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;{ 1, 2, 3 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 4, 5, 6 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 7, 8, 9 },  
};  
  
範例輸出:  
Sample =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;{ 7, 4, 1 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 8, 5, 2 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 9, 6, 3 },  
};  
  
# 解題思路  
觀察一陣子之後，發現將陣列中的行列互換即可，  
第一 row 的值對應到倒數第一 col 的值，  
第二 row 的值對應到倒數第二 col 的值，  
...以此類推  
  
實作的時候我採用最直覺的作法，先宣告一個新陣列，  
然後將每一 row 的值對應並寫入到新陣列的 col，  
最後再將新陣列的值(即旋轉過後的值)寫回到原陣列。  
  
舉例:  
假設原陣列 =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;{ 1, 2, 3 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 4, 5, 6 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 7, 8, 9 },  
};  
  
宣告的新陣列 =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;{ 0, 0, 0 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 0, 0, 0 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 0, 0, 0 },  
};  
  
進行第一輪的行列對應後，  
新陣列 =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;{ 0, 0, 1 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 0, 0, 2 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 0, 0, 3 },  
};  
  
進行第二輪的行列對應後，  
新陣列 =  
{  
&nbsp;&nbsp;&nbsp;&nbsp;{ 0, 4, 1 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 0, 5, 2 },  
&nbsp;&nbsp;&nbsp;&nbsp;{ 0, 6, 3 },  
};  
...以此類推  
  
# UnitTest 使用的測資  
這題 Input 和 Output 的邏輯很單純，使用題目的測資即可。  
//----------------------------------------  
// 第一筆測資  
int[][] Sample = new int[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 1, 2, 3 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 4, 5, 6 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 7, 8, 9 },  
};  
  
UnitTest.Rotate(Sample);  
  
int[][] Answer = new int[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 7, 4, 1 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 8, 5, 2 },  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 9, 6, 3 },  
};  
  
for(int i = 0; i < Sample.Length; i++)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;for (int j = 0; j < Sample.Length; j++)  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;if(Sample[i][j] != Answer[i][j])  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.Fail();  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}  
&nbsp;&nbsp;&nbsp;&nbsp;}  
}  
//----------------------------------------  
// 第二筆測資  
Sample = new int[][]  
{  
    new int[]{ 1 }  
};  
  
UnitTest.Rotate(Sample);  
  
Answer = new int[][]  
{  
&nbsp;&nbsp;&nbsp;&nbsp;new int[]{ 1 }  
};  
  
for (int i = 0; i < Sample.Length; i++)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;for (int j = 0; j < Sample.Length; j++)  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;if (Sample[i][j] != Answer[i][j])  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assert.Fail();  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}  
&nbsp;&nbsp;&nbsp;&nbsp;}  
}  
//----------------------------------------  
  
# 提交結果  
![image](https://raw.githubusercontent.com/Jacky20200711/LeetCode/master/Q48(Rotate%20Image)/SuccessShot.PNG)  
&emsp;  
&emsp;  
