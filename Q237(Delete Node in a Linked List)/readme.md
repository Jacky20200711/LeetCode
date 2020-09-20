# 題目網址 & 題目簡述  
https://leetcode.com/problems/delete-node-in-a-linked-list/  
   
題目的 Input 為要被刪除的 Node，我們並不需要關注 Output，只需要思考怎麼刪除這個 Node !  

範例:  
假設題目的 LinkedList = [4,5,1,9]，Input 為第 2 個 Node  
則在刪除該 Node 之後，LinkedList = [4,1,9]  
  
# 解題思路  
這題雖然簡單，但剛開始思考的時候，我的腦袋居然一片空白 = =   
以前在刪除 Node 的時候，都是從頭搜尋想要刪除的 Node(暫稱X)，  
然後將 X 的上一個 Node 指向 X 的下一個 Node，但這題卻刻意讓你無法存取 X 之前的 Node  

仔細思考一陣子之後，總算想到了一個簡單的方法，步驟如下  
1.將 X 的下一個 Node(暫稱Y) 的 Value 放到 X  
2.將 X 指向 Y 的下一個 Node  

結果就變成實際被刪除的 Node 為 Y ， 但卻能達成和刪除 X 一樣的效果，  
另外，由於這題給定的 Node 不會是最後一個 Node，所以不會出現沒有 Y 可以刪除的情況。  

# UnitTest 使用的測資  
這題實作太過簡單，所以沒有開專案與測試，而是直接寫在 LeetCode 的頁面後提交。   
  
# 提交結果  
![image](https://github.com/Jacky20200711/LeetCodeWithUnitTest/blob/master/Q237(Delete Node%20in%20a%20Linked%20List)/SuccessShot.PNG?raw=true)
&emsp;
&emsp;
