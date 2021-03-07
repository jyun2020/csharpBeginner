using System;
using System.Collections;

namespace _17鍵值對集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,2);//鍵值都是object類型,鍵不可重複
            ht.Add('1', 3);
            ht.Add(3, "小紅");
            ht.Add("小王", 87);
            ht[4] = "小黑";
            ht[4] = "小山";//這種寫法鍵一樣不會報錯,但只會顯示後面那個
            for (int i = 0; i < ht.Count; i++)
            {
                Console.WriteLine(ht[i]);//只會出現2和小紅
            }

            //Hashtable輸出方法:
            //var為推斷類型,根據給他的值轉變型別
            //宣告var一定要給初值
            foreach (var a in ht.Keys)
            {
                Console.WriteLine("鍵---{0}#值---{1}",a,ht[a]);
            }
        }
    }
}
