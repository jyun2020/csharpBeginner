using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 繼承_構造函數問題
{   

    //子類別無法繼承父類別的建構子
    //子類別會默認調用父類別無參數的建構子
    //解決方法:
    //1.在父類別中,加一個無參數的建構子
    //2.常用的,是在子類別中顯示調用父類別的建構子,使用Base關鍵字
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("小明", 18, '男', 001);
            Teacher t = new Teacher("大衛", 33, '男', 45000);
        }
    }
    public class Person
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        char gender;
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Person(string name, int age, char gender) //子類別不會繼承有參數的建構子
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public Person() //方法一(砍掉這個就會出錯)
        { }
    }
    public class Student : Person
    {
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Student(string name, int age, char gender,int id) : base(name, age, gender)
        {
            //方法二:不用再this.name = name
            //因為父類別已經做好
            this.Id = id; //學生專有的屬性,父類別沒有就要補充
        }
    }
    public class Teacher : Person
    {
        double salary;
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Teacher(string name, int age, char gender, Double salary) : base(name, age, gender)
        {
            //方法二:不用再this.name = name
            //因為父類別已經做好
            this.Salary = salary; //學生專有的屬性,父類別沒有就要補充
        }
    }
}
