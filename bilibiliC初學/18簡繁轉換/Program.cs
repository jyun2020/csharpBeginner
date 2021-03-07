using System;
using System.Collections;

namespace _18簡繁轉換
{
    class Program
    {
        private const string Jian = "一二三四五六七八九十";
        private const string Fan = "壹貳參肆伍陸柒捌玖拾";
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i < Jian.Length; i++)
            {
                ht.Add(Jian[i], Fan[i]);
            }
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(ht[item]);
            }

            //轉換練習
            Console.WriteLine("輸入小寫數字轉換為大寫");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (ht.ContainsKey(str[i]))//如果有包含就印出
                {
                    Console.Write(ht[str[i]]);
                }
                else
                {
                    Console.Write("請輸入正確字串");
                }
            }
        }
    }
}
