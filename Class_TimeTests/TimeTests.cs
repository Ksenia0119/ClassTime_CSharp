/// @author Maltseva K.V.
/// Реализация  класса "Время"



using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTime.Tests
{
    [TestClass()]
    public class TimeTests
    {
        [TestMethod()]
        public void TimeTest()  /// Тест конструктора
        {
            Time t1 = new Time(4, 54, 32, 41);
            Assert.AreEqual(4, t1.get_days());
            Assert.AreEqual(54, t1.get_hours());
            Assert.AreEqual(32, t1.get_minutes());
            Assert.AreEqual(41, t1.get_seconds());

        }

        [TestMethod()]
        public void TimeSets()  /// Тест сеттеров
        {
            Time t1 = new Time();
            t1.set_days(6);
            t1.set_hours(15);
            t1.set_minutes(23);
            t1.set_seconds(33);
            Assert.AreEqual(6, t1.get_days());
            Assert.AreEqual(15, t1.get_hours());
            Assert.AreEqual(23, t1.get_minutes());
            Assert.AreEqual(33, t1.get_seconds());
        }

        [TestMethod()]
        public void get_all_timeTest() /// Получение всего времени в секундах
        {
            Time t1 = new Time(6, 23, 42, 12);
            Assert.AreEqual(603732, t1.get_all_time());
        }


        [TestMethod()]
        public void convert_to_Test() ///Конвертирование времени 
        {
            Time t1 = new Time(10, 2, 3, 5);
        
            Assert.AreEqual(871385, t1.convert_to_seconds(t1));

        }

        [TestMethod()]
        public void Add_Test() ///Сложение 2х времен
        {
            Time t1 = new Time();
            Time t2 = new Time();
            t1.set_time(5, 7, 8, 1);
            t2.set_time(6, 7, 8, 9);
            t2.AddTime(t1, t2);
            Assert.AreEqual(t2.ToString(), "11 days 14 hours 16 minutes 10 seconds");
        }

        [TestMethod()]
        public void Add2_Test() ///Сложение 2х времен
        {
            Time t1 = new Time();
            Time t2 = new Time();
            t1.set_time(25, 19, 6, 10);
            t2.set_time(6, 4, 7, 8);
            t2.AddTime(t1, t2);
            Assert.AreEqual(t2.ToString(), "31 days 23 hours 13 minutes 18 seconds");
        }

        [TestMethod()]
        public void Add3_Test() ///Сложение 2х времен
        {
            Time t1 = new Time();
            Time t2 = new Time();
            t1.set_time(0, 0, 8, 10);
            t2.set_time(10, 17, 28, 9);
            t2.AddTime(t1, t2);
            Assert.AreEqual(t2.ToString(), "10 days 17 hours 36 minutes 19 seconds");
        }

        [TestMethod()]
        public void Sub_Test()  ///Вычитание 2х времен
        {
            Time t1 = new Time();
            Time t2 = new Time();
            t2.set_time(5, 7, 8, 1);
            t1.set_time(6, 7, 8, 9);
            t2.SubTime(t1, t2);
            Assert.AreEqual(t2.ToString(), "1 days 0 hours 0 minutes 8 seconds");
        }
        [TestMethod()]
        public void Sub2_Test()  ///Вычитание 2х времен
        {
            Time t1 = new Time();
            Time t2 = new Time();
            t2.set_time(6, 7, 8, 9);
            t1.set_time(12, 4, 7, 0);
            t2.SubTime(t1, t2);
            Assert.AreEqual(t2.ToString(), "5 days 20 hours 58 minutes 51 seconds");
        }

        [TestMethod()]
        public void Sub3_Test()  ///Вычитание 2х времен
        {
            Time t1 = new Time();
            Time t2 = new Time();
            t2.set_time(1, 2, 39, 54);
            t1.set_time(35, 0, 0, 58);
            t2.SubTime(t1, t2);
            Assert.AreEqual(t2.ToString(), "33 days 21 hours 21 minutes 4 seconds");
        }
    }
}