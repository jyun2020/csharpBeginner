using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 繼承練習
{
    class Program
    {
        static void Main(string[] args)
        {/*寫一個Reporter和Progremmer的類別
          * Driver類他們都有一個打招呼的方法
          * 不同的是Reporter打招呼是說"大家好,我叫xx,我的愛好是xxx"
          * Progremmer的是說"大家好,我叫xx,我今年x歲,已經工作x年了"
          * Driver:"大家好,我叫xx,我的駕駛年齡為xx"
          */

            /*  思考有類別有何種屬性
                Reporter:姓名,愛好
                Progremmer:姓名,年齡,工作年分
                Driver:姓名,駕駛年齡
            */
            Reporter reporter = new Reporter();
            reporter.Name = "小明";
            reporter.Hobby = "偷拍";
            Progremner progremner = new Progremner();
            progremner.Name = "小王";
            progremner.Age = 22;
            progremner.Worktime = 3;
            Driver driver = new Driver();
            driver.Name = "小山";
            driver.DriveTime = 10;

            reporter.ReporterSayHello();
            progremner.ProgremmerSayHello();
            driver.DriverSayHELLO();
        }
        public class Person
        {
            string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
        public class Reporter : Person
        {
            string hobby;
            public string Hobby
            {
                get { return hobby;}
                set { hobby = value; }
            }
            public void ReporterSayHello()
            {
                Console.WriteLine("大家好,我叫{0},我的愛好是{1}",this.Name,this.Hobby);
            }

        }
        public class Progremner : Person
        {
            int worktime;
            public int Worktime
            {
                get { return worktime; }
                set { worktime = value; }
            }
            int age;
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public void ProgremmerSayHello()
            {
                Console.WriteLine("大家好,我叫{0},我今年{1}歲,已經工作{2}年了",this.Name,this.Age,this.Worktime);
            }
        }
        public class Driver : Person
        {
            int driveTime;
            public int DriveTime
            {
                get { return driveTime; }
                set { driveTime = value; }
            }
            public void DriverSayHELLO()
            {
                Console.WriteLine("大家好,我叫{0},我的駕駛年齡為{1}",this.Name,this.DriveTime); 
            }
        }
    }
}
