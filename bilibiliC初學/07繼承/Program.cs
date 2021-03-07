using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 繼承
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Age = 30; //Person的age
            teacher.Name = "張三";//Person的Name
            teacher.Gender = '男';//Person的Gender
            teacher.Salary = 100000; //Teacher的Salary
            teacher.Teach(); //Teacher的方法
            teacher.CHLSS(); //Person的方法
            Console.ReadKey();

            Student student = new Student();
            student.Age = 10; //學生繼承老師,但老師繼承人類,所以還是Person的Age(傳遞性)

        }
        //共同有的屬性:姓名、年齡、性別。方法:吃喝拉撒睡
        public class Person
        {
            string _names;
            public string Name
            {
                get { return _names; }
                set { _names = value; }
            }

            int _Age;
            public int Age
            {
                get { return _Age; }
                set { _Age = value; }
            }

            char _Gender;
            public char Gender
            {
                get { return _Gender; }
                set { _Gender = value; }
            }

            public void CHLSS()
            {
                Console.WriteLine("吃喝拉撒睡");
            }
        }

        //定義老師的類別 (獨有的屬性:薪水。方法:講課) 
        //老師的類別使用繼承的方法 後面加:Person
        public class Teacher : Person //"單一性":不能繼承多的父類別
        {
            int _Salary;
            public int Salary
            {
                get { return _Salary; }
                set { _Salary = value; }
            }

            public void Teach()
            {
                Console.WriteLine("講課");
            }
        }

        //定義學生的類別 (獨有的屬性:學號。方法:聽課)
        //學生繼承老師類別
        public class Student:Teacher
        {
            int _id;
            public int id
            {
                get { return _id; }
                set { _id = value; }
            }
    
            public void Study()
            {
                Console.WriteLine("聽課");
            }
        }

        //定義工程師的類別 (獨有的屬性:女朋友。方法:寫程式)
        //未使用繼承的方法 
        public class Programmer
        {
            string _names;
            public string Name
            {
                get { return _names; }
                set { _names = value; }
            }

            int _Age;
            public int Age
            {
                get { return _Age; }
                set { _Age = value; }
            }

            char _Gender;
            public char Gender
            {
                get { return _Gender; }
                set { _Gender = value; }
            }

            string _Girlfriend;
            public string Girlfriend
            {
                get { return _Girlfriend; }
                set { _Girlfriend = value; }
            }

            public void CHLSS()
            {
                Console.WriteLine("吃喝拉撒睡");
            }

            public void Code()
            {
                Console.WriteLine("寫程式");
            }
        }
    }
}
