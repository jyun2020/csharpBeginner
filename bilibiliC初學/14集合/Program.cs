using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14集合
{
    class Program
    {
        static void Main(string[] args)
        {   //陣列大小為不可變

            //int[] number = new int[5] { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}
            //Console.ReadLine();

            //創建串列
            ArrayList List = new ArrayList();
            //串列增加元素,什麼都可以加,會自動打包成物件
            //List.Add(1);
            //List.Add('南');
            //List.Add(300m);
            //List.Add(1.5);
            //foreach (object a in List)//為object類型
            //{
            //    Console.WriteLine(a);
            //}

            //如果加入物件的元素
            int[] number = new int[] { 1,2,3,4,5};
            person p = new person();
            //List.Add(number);
            //List.Add(p);
            //List.Add(List);
            ////方法一: 輸出時轉換
            //for (int i = 0; i < List.Count; i++)
            //{
            //    if (List[i] is int[])
            //    {
            //        for (int j = 0; j < ((int[])(List[i])).Length; j++)//把object轉換成int[]再迴圈輸出
            //        {
            //            Console.WriteLine(((int[])List[i])[j]);
            //        }
            //    }
            //    else if (List[i] is person)//把object轉換成person物件
            //    {
            //        ((person)List[i]).personsay();
            //    }
            //    else
            //    {
            //        Console.WriteLine(List[i]);
            //    }
            //}


            //方法二:添加陣列及串列,用AddRange
            //List.AddRange(number);
            //List.AddRange(List);
            //for (int i = 0; i < List.Count; i++)
            //{
            //    Console.WriteLine(List[i]);
            //}

        }
        public class person
        {
            public void personsay()
            {
                Console.WriteLine("我是人");
            }
        }
    }
}
