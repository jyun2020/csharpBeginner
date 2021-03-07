using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12類別轉換練習
{
    class Program
    {
        static void Main(string[] args)
        {
            //寫5個類別,讓這5個類別繼承於同一個父類別,輸出10個打招呼的方法,並且是隨機的
            Random r = new Random(); //新增亂數物件
            Person[] prs = new Person[10]; //新增10個Person類別的陣列
            for (int i = 0; i < prs.Length; i++) //迴圈跑陣列
            {
                int OOPnumber = r.Next(1, 7); //亂數1~6
                switch (OOPnumber)
                {
                    case 1: prs[i] = new Student();
                        break;
                    case 2:
                        prs[i] = new Teacher();
                        break;
                    case 3:
                        prs[i] = new Progremmer();
                        break;
                    case 4:
                        prs[i] = new Driver();
                        break;
                    case 5:
                        prs[i] = new Ninja();
                        break;
                    case 6:
                        prs[i] = new Person();
                        break;
                }
            }
            for (int i = 0; i < prs.Length; i++)
            {
                Convert(prs[i]);
            }
            Console.ReadKey();
        }
        public static void Convert(Person prs) //轉換的方法
        {
            if (prs is Student)
            {
                ((Student)prs).StudentSayHello();
            }
            else if (prs is Teacher)
            {
                ((Teacher)prs).TeacherSayHello();
            }
            else if (prs is Progremmer)
            {
                ((Progremmer)prs).ProgremmerSayHello();
            }
            else if (prs is Driver)
            {
                ((Driver)prs).DriverSayHello();
            }
            else if (prs is Ninja)
            {
                ((Ninja)prs).NinjaSayHello();
            }
            else
            {
                prs.PersonSayHello();
            }

        }
        public class Person
        {
            public void PersonSayHello()
            {
                Console.WriteLine("我是人類");
            }
        }
        public class Student : Person
        {
            public void StudentSayHello()
            {
                Console.WriteLine("我是學生");
            }
        }
        public class Teacher : Person
        {
            public void TeacherSayHello()
            {
                Console.WriteLine("我是老師");
            }
        }
        public class Progremmer : Person
        {
            public void ProgremmerSayHello()
            {
                Console.WriteLine("我是工程師");
            }
        }
        public class Driver : Person
        {
            public void DriverSayHello()
            {
                Console.WriteLine("我是司機");
            }
        }
        public class Ninja : Person
        {
            public void NinjaSayHello()
            {
                Console.WriteLine("我是忍者");
            }
        }
    }
}
