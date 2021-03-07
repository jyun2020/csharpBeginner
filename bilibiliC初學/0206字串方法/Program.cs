using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串方法
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 字串轉陣列,陣列轉字串 
            /*   
            string str = "abcdefg";
            //將一個字串轉換為char陣列
            char[] chs = str.ToCharArray();
            for (int i=0; i<= chs.Length; i++) //陣列第二個字符改成b
            {
                chs[2] = 'b';
            }
            for (int i = 0; i <= chs.Length-1; i++) //迴圈印出陣列
            {
                Console.WriteLine(chs[i]);

            }
            str = new string(chs);
            Console.WriteLine(str);
            Console.ReadKey();
            */
            #endregion

            #region 練習:輸入兩個課程,如果一樣輸出一致,不一樣則輸出不一致
            /*
               Console.WriteLine("請輸入第一組課程");
               string lessonOne = Console.ReadLine();
               //lessonOne = lessonOne.ToUpper(); //轉換成大寫
               Console.WriteLine("請輸入第二組課程");
               string lessonTwo = Console.ReadLine();
               //lessonTwo = lessonTwo.ToUpper(); //轉換成大寫
               //if(lessonOne == lessonTwo) 手動轉大寫判斷

               if (lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase)) 
               //Equals判斷,第二個參數可忽略大小寫
               {
                   Console.WriteLine("課程一致");
               }
               else 
               {
                   Console.WriteLine("課程不一致");
               }
               Console.ReadKey();
            */
            #endregion

            #region Split 字串分割
            /*
            string str = "a,b,c d ef g";
            //char[] chs = new chs[23];
            string[] strNew = str.Split(new char[] (',',' '),StringSplitOptions.RemoveEmptyEntries);
            for(int i=0;i<=strNew.Length;i++)
            {
                Console.WriteLine(strNew[i]);
            }
            Console.ReadKey();
            */
            #endregion

            #region 練習:從日期("2008-08-08")分析出年、月、日:2008年8月8日
            //輸入一個日期隔式:2008-01-01,輸出輸入的日期為2008年1月1日
            /*
            Console.WriteLine("輸入一個日期格式如下:2008-01-01");
            string str = Console.ReadLine();

            //char[] chs = {'-'};
            //string[] strNew = str.Split(chs,StringSplitOptions.RemoveEmptyEntries)

            string[] strNew = str.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(strNew[0]+"年"+strNew[1]+"月"+strNew[2]+"日");
            Console.ReadKey();
            */
            #endregion

            #region Replace 字串替換
            /*
            string str = "洪秉鈞";
            str = str.Replace("洪秉鈞", "洪稟莙");
            Console.WriteLine(str);
            Console.ReadKey();
            */
            #endregion

            #region Substring 截取字串
            /*
            string str = "看到我巨槌瑞斯都不會怕的欸";
            str = str.Substring(5); //從第5個(含)列出
            Console.WriteLine(str);
            Console.ReadKey();
            */
            #endregion

            #region Contains 檢查字串是否包含contains
            /*
            string str = "看到.我.巨槌瑞斯.都不會怕.的欸";
            bool b = str.Contains('.');
            Console.WriteLine(b);
            Console.ReadKey();
            */
            #endregion

            #region Startwit,Endwith 以...開始,以...結束
            /*
            string str = "看到我巨槌瑞斯都不會怕的欸";
            bool b = str.StartsWith("看到");
            bool c = str.EndsWith("怕的");
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
            */
            #endregion

            #region Index of 從設定的字串起點開始尋找特定字符

            //string str = "看到我巨槌瑞斯都不會怕怕的欸";
            //int a = str.indexof('巨'); //如果不存在會接收到-1 
            //int b = str.indexof('怕', 10); //第二個參數表示從第x個開始找(包含x)
            //console.writeline(b);
            //console.readkey();

            #endregion

            #region Last IndexOf 從設定的字串往前開始尋找特定字符
            /*
            string path = @"E:\o2jam_韓國(samo)\Music\BGMWinter.ojm"; // \被轉譯了,前面要加@
            int a = path.LastIndexOf('\\');
            Console.WriteLine(a);//a值是23
            string fileName = path.Substring(a+1);
            Console.WriteLine(fileName);
            Console.ReadKey();
            */
            #endregion

            #region 練習:接收用戶輸入的字串,以相反順序輸出(abc>cba)
            /*
            Console.WriteLine("輸入一串文字");
            string str = Console.ReadLine();

            //方法一
            char[] chs = str.ToCharArray();
            string ans = "";
            for (int i = chs.Length-1; i >= 0; i--)
            { 
                ans = ans + chs[i];
            }
            Console.WriteLine(ans);

            //方法二
            char[] chs2 = str.ToCharArray();
            for (int i = 0; i < chs2.Length / 2; i++)
            {
                char temp = chs2[i];
                chs2[i] = chs2[chs2.Length - 1 - i];
                chs2[chs2.Length - 1 - i] = temp;
            }
            str = new string(chs2);
            Console.WriteLine(str);
            Console.ReadKey();
            */
            #endregion

            #region 練習:將用戶輸入的一段英文,以反向輸出(hello c sherp > sherp c hello)
            /*
            Console.WriteLine("請輸入一段英文:");
            string str = Console.ReadLine();
            string[] str2 = str.Split(' ');
            for (int i = str2.Length - 1; i >= 0; i--)
            {
                Console.Write(str2[i]+" ");
            }
            Console.ReadLine();
            */
            #endregion

            #region 練習:從Email取出用戶名及網域名
            /*
            Console.WriteLine("輸入一個信箱");
            string email = Console.ReadLine();
            int a = email.IndexOf("@");
            string Username = email.Substring(0, a);
            Console.WriteLine(Username);

            string Domain = email.Substring(a+1);//未輸入第二個參數預設為到最後一個
            Console.WriteLine(Domain);
            Console.ReadLine();
            */
            #endregion

            #region 練習:文件中存了多少個文章標題
            //作者標題間用若干空格隔開，如果標提>10個字，截取前8個字加上'...'再加一個豎線輸出作者名字。
            /*
            string[] str = File.ReadAllLines("1.txt",Encoding.Default);
            for (int i = 0; i < str.Length; i++)
            {
                string[] NewStr = str[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(NewStr[0].Length > 10 ? NewStr[0].Substring(0, 8) + "......"+"|"+NewStr[1] : NewStr[0]+"|"+NewStr[1]);
                
                //?: 運算子 根據布林運算式是否評估為或，傳回兩個運算式其中之一的結果 true false 。
                //one ? two : three (如果one判斷為是則執行two否則three。
            }
            Console.ReadKey();
            */
            #endregion

            #region 練習:輸入一段文字，找出所有e的位置。(重要)
            /*
            Console.WriteLine("請輸入一段英文:");
            string str = Console.ReadLine();
            int index = str.IndexOf('e'); //找出第1個e的位置
            int i = 1; //計數器
            if (index == -1) //如果第一個都找不到代表根本沒有e
            {
                Console.WriteLine("這段英文沒有e");
            }
            else //有的話就繼續找
            {
                Console.WriteLine("第{0}次e出現的位置是{1}", i, index);//先印出第1個e的位置,再進迴圈
                while (index != -1)//如果沒有e會接收到-1就不執行迴圈
                {
                    i++;
                    index = str.IndexOf('e', index + 1);//從第一個e的位置+1開始找第二個
                    if (index == -1)
                    {
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("第{0}次e出現的位置是{1}", i, index);
                    }
                }
                Console.ReadKey();
            } 
            */
            #endregion

            #region 練習:輸入一段文字，判斷這句話中有沒有瑞斯,如果有就替換成**
            /*
            Console.WriteLine("輸入一段文字");
            string str = Console.ReadLine();
            if (str.Contains("瑞斯"))
            {
                str = str.Replace("瑞斯", "**");
                Console.WriteLine(str);
            }
            else //esle可以不要加
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
            */
            #endregion

            #region 練習:把{"諸葛亮","劉備","關羽"}變成{諸葛亮|劉備|關羽},然後再把|截掉
            /*
            string[] str = { "諸葛亮", "劉備", "關羽" };
            string strNew = "";
            for (int i = 0; i < str.Length - 1; i++)
            {
                strNew += str[i] + "|";
            }
            strNew = strNew + str[str.Length - 1];
            string[] names  = strNew.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
            */
            #endregion
        }
    }
}
