using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10類別轉換
{
    class Program
    {
        static void Main(string[] args)
        {   //物件初始化器Person p = new Person() { name = "小明", age = 12, gender = '男' };
            //里氏轉換
            //子類別可以把值給父類別,如果父類別中裝的是子類別的值,可以將父類別強制轉成對應的子類別
            Person person;
            Student student = new Student("阿花",18,'女',001);
            person = student;//new Person("人類",11'女');
            //person還是父類別

            //忍術!類別轉換術!
            Student newStudent = (Student)person;
            //person變成子類別了

            //如果有兩個子類別都是繼承同一個父類別,兩個子類別不能互相轉換,因為內部屬性方法不一樣
        }
    }
    public class Person
    {   //這種get set方法和前幾章的做法一樣
        //但是如果要設定值就要在建構子內設定
        public string name //自動產生一個private屬性
        {
            get;
            set;
        }
        public int age
        {
            get;
            set;
        }
        public char gender
        {
            get;
            set;
        }
        public Person(string name, int age, char gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public string PersonSayHello()
        {
            return ("我是人類");
        }
    }


    public class Student : Person
    { 
        public int id
        {
            get;
            set;
        }
        public Student(string name, int age, char gender, int id) : base(name, age, gender)
        {
            this.id = id;
        }
        public string StudentSayHello()
        {
            return ("我是學生");
        }
    }
}
