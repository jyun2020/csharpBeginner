using System;
using System.Collections;

namespace _16集合練習和長度問題
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //將奇數及偶數放到不同的集合中,並求出最大值,最小值,總和  
            //ArrayList oddlist = new ArrayList();
            //ArrayList evenlist = new ArrayList();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 != 0)
            //    {
            //        oddlist.Add(nums[i]);
            //    }
            //    else
            //    {
            //        evenlist.Add(nums[i]);
            //    }
            //}
            //foreach (object a in oddlist)
            //{
            //    Console.Write(a);
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //foreach (object a in evenlist)
            //{
            //    Console.Write(a);
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //int oddsum = 0;
            //int oddmax = (int)oddlist[0];
            //int oddmin = (int)oddlist[0];
            //for (int i = 0; i < oddlist.Count; i++)
            //{
            //    oddsum += (int)oddlist[i];
            //    if ((int)oddlist[i] > oddmax)
            //    {
            //        oddmax = (int)oddlist[i];
            //    }
            //    else
            //    { 
            //        oddmin = (int)oddlist[i];
            //    }
            //}
            //Console.WriteLine("奇數列:總合為{0},最大值為{1},最小值為{2}", oddsum, oddmax, oddmin);

            //int evensum = 0;
            //int evenmax = (int)evenlist[0];
            //int evenmin = (int)evenlist[0];
            //for (int i = 0; i < evenlist.Count; i++)
            //{
            //    evensum += (int)evenlist[i];
            //    if ((int)evenlist[i] > evenmax)
            //    {
            //        evenmax = (int)evenlist[i];
            //    }
            //    else
            //    {
            //        evenmin = (int)evenlist[i];
            //    }
            //}
            //Console.WriteLine("偶數列:總合為{0},最大值為{1},最小值為{2}", evensum, evenmax, evenmin);


            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add(6);
            //list.Add(7);
            //list.Add(8);
            //list.Add(9);
            //Console.WriteLine(list.Count);//串列中實際有的個數
            //Console.WriteLine(list.Capacity);//向內存申請開闢的空間數,如果一開始有指定個數,就會以那個數值倍數增長
            //Console.ReadKey();

        }
    }
}
