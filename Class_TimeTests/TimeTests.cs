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
        public void convert_to_Test() ///Конвертирование времени в разные форматы
        {
            Time t1 = new Time(10, 2, 3, 5);
            //Assert.AreEqual(10,0868053436279, t1.convert_to_days(t1));
            // Assert.AreEqual(242.133331298828, t1.convert_to_hours(t1));
             //Assert.AreEqual(14523.0830078125, t1.convert_to_minutes(t1));
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
            Assert.AreEqual(t2.ToString(), Convert.ToString(11) + " days  " + Convert.ToString(14)
                + " hours  " + Convert.ToString(16) + " minutes  " + Convert.ToString(10) + " seconds  ");
        }

        [TestMethod()]
        public void Sub_Test()  ///Вычитание 2х времен
        {
            Time t1 = new Time();
            Time t2 = new Time();
            t2.set_time(5, 7, 8, 1);
            t1.set_time(6, 7, 8, 9);
            t2.SubTime(t1, t2);
            Assert.AreEqual(t2.ToString(), Convert.ToString(1) + " days  " + Convert.ToString(0)
                + " hours  " + Convert.ToString(0) + " minutes  " + Convert.ToString(8) + " seconds  ");
        }
    }
}