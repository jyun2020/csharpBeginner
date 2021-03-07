using System;
using System.Collections;

namespace _15集合練習
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int[] number = new int[] { 1,2,3};
            //list.Add(1);
            //list.Add('女');
            //list.Add(1.33);
            //list.AddRange(number);

            //list.Clear();//清空list
            //list.Remove(1.333);//根據值刪除元素,如果沒有就沒反應
            //list.RemoveAt(1);//根據位置刪除元素
            //list.RemoveRange(1,2);//從索引開始刪除?個
            //if (list.Contains(2)) //是否包含
            //{
            //    Console.WriteLine("集合中已包含該數據");
            //}
            //else
            //{
            //    list.Add(2);
            //}

            //list元素增加、插入、刪除、清空、排序、反轉
            //list.Insert(1, "我是臨時進來的");//會插在第一個的前面,插入單個元素
            //list.InsertRange(1,number);//專門陣列、串列
            //list.Sort();//升冪排序,類型必須一致,如果元素型別不一樣會報錯,字元依大小寫排序,不是ascii碼
            //list.Reverse();//反轉
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //-----------練習----------------
            //1.寫一個長度為10的集合,在裡面存放10個隨機的數字0~9,每個數字不重複
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int r = random.Next(0, 10);
                if (!list.Contains(r))
                {
                    list.Add(r);
                }
                else
                {
                    i--;
                }
            }
            foreach (object a in list)
            {
                Console.WriteLine(a);
            }
        }
    }
}
