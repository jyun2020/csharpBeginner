using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "";
            StringBuilder sb = new StringBuilder(); //00:00:00.0103726
            Stopwatch sw = new Stopwatch(); //00:00:00.0000705

            sw.Start();
            for (int i = 0; i <= 10000; i++) 
            {
                //str += "i";  
                sb.Append("i");
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
