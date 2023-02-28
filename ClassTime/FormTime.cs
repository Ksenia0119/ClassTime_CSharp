/// @author Maltseva K.V.
/// Реализация  класса "Время"


using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;



namespace ClassTime
{
    public partial class Form_Time : Form
    {  ///Все переменные  в c# имеют ссылочный тип 
       ///Ссылки на объекты
        Time Time1 = new Time();
        Time Time2 = new Time();
        Time Time3 = new Time();
        private Color mistake_color = Color.FromArgb(211, 110, 112);
        private Color form_color = Color.FromArgb(175, 238, 238);
        public Form_Time()
        {
            InitializeComponent();
            this.BackColor = form_color;
        }
        ///Проверка корректности ввода данных
        private int CheckTime()
        {
            int chet = 0;
            if (Convert.ToInt32(textBox_days1.Text) < 0)
            {
                textBox_days1.BackColor = mistake_color; 
                chet++;
                labelError.Text = "Неправильно задан день";
            }
            else textBox_days1.BackColor = Color.White;
          


            if (Convert.ToInt32(textBox_hours1.Text) < 0 || (Convert.ToInt32(textBox_hours1.Text) > 23))
            {
                textBox_hours1.BackColor = mistake_color;
                chet++;
                labelError.Text = "Неправильно заданы часы";
            }
            else textBox_hours1.BackColor = Color.White;
          

            if (Convert.ToInt32(textBox_minutes1.Text) < 0 || (Convert.ToInt32(textBox_minutes1.Text) > 59))
            {
                textBox_minutes1.BackColor = mistake_color;
                chet++;
                labelError.Text = "Неправильно заданы минуты";
            }
            else textBox_minutes1.BackColor = Color.White;
       

            if (Convert.ToInt32(textBox_seconds1.Text) < 0 || (Convert.ToInt32(textBox_seconds1.Text) > 59))
            {
                textBox_seconds1.BackColor = mistake_color;
                chet++;
                labelError.Text = "Неправильно заданы секунды";
            }
            else textBox_seconds1.BackColor = Color.White;
           

            if (Convert.ToInt32(textBox_days2.Text) < 0)
            {
                textBox_days2.BackColor = mistake_color;
                chet++;
                labelError.Text = "Неправильно задан день";
            }
            else textBox_days2.BackColor = Color.White;
           


            if (Convert.ToInt32(textBox_hours2.Text) < 0 || (Convert.ToInt32(textBox_hours2.Text) > 23))
            {
                textBox_hours2.BackColor = mistake_color;
                chet++;
                labelError.Text = "Неправильно заданы часы";
            }
            else textBox_hours2.BackColor = Color.White;
        

            if (Convert.ToInt32(textBox_minutes2.Text) < 0 || (Convert.ToInt32(textBox_minutes2.Text) > 59))
            {
                textBox_minutes2.BackColor = mistake_color;
                chet++;
                labelError.Text = "Неправильно заданы минуты";
            }
            else textBox_minutes2.BackColor = Color.White;
           

            if (Convert.ToInt32(textBox_seconds2.Text) < 0 || (Convert.ToInt32(textBox_seconds2.Text) > 59))
            {
                textBox_seconds2.BackColor = mistake_color;
                chet++;
                labelError.Text = "Неправильно заданы секунды";
            }
            else textBox_seconds2.BackColor = Color.White;

            return chet;
        }

        

        ///Задать время
        private void SetTime()
        {
          
            try
            {
                Time1.set_days(Convert.ToInt32(textBox_days1.Text));
                Time1.set_hours(Convert.ToInt32(textBox_hours1.Text));
                Time1.set_minutes(Convert.ToInt32(textBox_minutes1.Text));
                Time1.set_seconds(Convert.ToInt32(textBox_seconds1.Text));
                Time2.set_days(Convert.ToInt32(textBox_days2.Text));
                Time2.set_hours(Convert.ToInt32(textBox_hours2.Text));
                Time2.set_minutes(Convert.ToInt32(textBox_minutes2.Text));
                Time2.set_seconds(Convert.ToInt32(textBox_seconds2.Text));

            }
            catch (ArgumentException er)
            {
                labelError.Text = er.Message;
            }
        }



        ///Перевод времени в разные форматы
        private void button1_convert_Click(object sender, EventArgs e)
        {

            if (CheckTime() == 0)
            {
                SetTime();
                textBox_resultSeconds.Text = Time1.get_all_time().ToString();
                textBox_resultHours.Text = Time1.convert_to_hours(Time1).ToString();
                textBox_resultDays.Text = Time1.convert_to_days(Time1).ToString();
                textBox_resultMinutes.Text = Time1.convert_to_minutes(Time1).ToString();
            }
        }


        ///Сложение 2х времен
        private void button1_add_Click(object sender, EventArgs e)
        {
            if (CheckTime() == 0) 
            {
                SetTime();

                Time2.AddTime(Time1, Time2);
                textBox_result_all.Text = " New Time = " + "\n" + Time2.get_days().ToString() + " days " + Time2.get_hours().ToString() +
                                " hours " + Time2.get_minutes().ToString() + " minutes " + Time2.get_seconds().ToString() + " seconds ";
                labelError.Text = "";
            }


        }


        /// Вычитание 2х времен
        private void button1_sub_Click(object sender, EventArgs e)
        {

            if (CheckTime() == 0)
            {
                SetTime();
                Time2.SubTime(Time1, Time2);
                textBox_result_all.Text = " New Time = " + "\n" + Time2.get_days().ToString() + " days " + Time2.get_hours().ToString() +
                                " hours " + Time2.get_minutes().ToString() + " minutes " + Time2.get_seconds().ToString() + " seconds ";
                labelError.Text = "";
            }
        }

       
    }
}