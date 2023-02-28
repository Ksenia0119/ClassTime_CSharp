/// @author Maltseva K.V.
/// Реализация  класса "Время"


using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



namespace ClassTime
{
    public class Time
    {
        private int days; ///Дни
        private int hours;///Часы
        private int minutes;///Минуты
        private int seconds;///Секунды

        /// Конструктор (инициализирует поля)
        public Time()
        {
            days = 0;
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public Time(int d, int h, int m, int s)
        {
            this.days = d;
            this.hours = h;
            this.minutes = m;
            this.seconds = s;
        }
        ~Time() { }


        /// Задать время в стандартном формате
        public void set_time(int d, int h, int m, int s)
        {
            set_days(d);
            set_seconds(s);
            set_minutes(m);
            set_hours(h);
        }
        /// Задать секунды
        public void set_seconds(int s)
        {
            if ((s < 0) || (s > 59)) throw new ArgumentException("Invalid argument: seconds");
            seconds = s;
        }
        /// Задать минуты
        public void set_minutes(int m)
        {
            if ((m < 0) || (m > 59)) throw new ArgumentException("Invalid argument: minutes");
            minutes = m;
        }

        /// Задать часы
        public void set_hours(int h)
        {
            if ((h < 0) || (h > 23)) throw new ArgumentException("Invalid argument: hours");
            hours = h;
        }
        /// Задать дни
        public void set_days(int d)
        {
            if (d < 0) throw new ArgumentException("Invalid argument: days");
            days = d;
        }

        /// Преобразовать cекунды в стандартный формат
        public void convert_s_to_std(int t)
        {
            if (t < 0) throw new ArgumentException("Invalid value of time");
            days = t / 86400;
            hours = (t / 3600) % 24;
            minutes = (t / 60) % 60;
            seconds = t % 60;
        }
        /// Получить время в секундах
        public int get_all_time()
        {
            return seconds + minutes * 60 + hours * 3600 + days * 86400;
        }
        /// Получить секунды
        public int get_seconds()
        {
            return seconds;
        }
        /// Получить минуты
        public int get_minutes()
        {

            return minutes;
        }

        /// Получить часы
        public int get_hours()
        {
            return hours;
        }
        /// Получить дни
        public int get_days()
        {
            return days;

        }

        ////Добавить время
        public int AddTime(Time t1, Time t2)
        {
            int T1 = t1.get_all_time();
            int T2 = t2.get_all_time();
            T2 += T1;
            t2.convert_s_to_std(T2);
            return T2;
        }
        ///Вычесть время
        public int SubTime(Time t1, Time t2)
        {
            int T1 = t1.get_all_time();
            int T2 = t2.get_all_time();
            T1 = T1 - T2;
            t2.convert_s_to_std(T1);
            return T1;
        }


        /// Перевести все время в секунды
        public int convert_to_seconds(Time t2)
        {
            return t2.days * 86400 + t2.hours * 3600 + t2.minutes * 60 + t2.seconds;
        }
        ///Перевести все время в минуты
        public float convert_to_minutes(Time t2)
        {

            return (float)(t2.days * 1440 + t2.hours * 60 + t2.minutes + t2.seconds / 60.0);
        }
        /// Перевести все время в часы
        public float convert_to_hours(Time t2)
        {

            return ((float)(t2.days * 24 + t2.hours + t2.minutes / 60.0 + t2.seconds / 60.0));
        }

        /// Перевести все время в сутки
        public float convert_to_days(Time t2)
        {
            return (float)(days + hours / 24.0 + minutes / 1440.0 + seconds / 3600.0);
        }
        // Переопределение метода ToString. Каждый объект в языке С# получает метод ToString, который возращает строковое представление данного объекта.
        // При создании пользовательского класса необходимо переопределить метод,чтобы передать информацию о типе
        /// Преобразовать в строку всё время
        override public string ToString()
        {
            return Convert.ToString(days) + " days " + Convert.ToString(hours) + " hours " + Convert.ToString(minutes) + " minutes " + Convert.ToString(seconds) + " seconds";
        }
    }
}
