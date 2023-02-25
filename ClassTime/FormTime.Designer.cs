/// @author Maltseva K.V.
/// Реализация  класса "Время"

namespace ClassTime
{
    partial class Form_Time
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelError = new System.Windows.Forms.Label();
            this.textBox_result_all = new System.Windows.Forms.TextBox();
            this.textBox_resultDays = new System.Windows.Forms.TextBox();
            this.textBox_resultMinutes = new System.Windows.Forms.TextBox();
            this.textBox_resultHours = new System.Windows.Forms.TextBox();
            this.textBox_resultSeconds = new System.Windows.Forms.TextBox();
            this.button1_sub = new System.Windows.Forms.Button();
            this.button1_add = new System.Windows.Forms.Button();
            this.textBox_seconds2 = new System.Windows.Forms.TextBox();
            this.textBox_minutes2 = new System.Windows.Forms.TextBox();
            this.textBox_hours2 = new System.Windows.Forms.TextBox();
            this.textBox_days2 = new System.Windows.Forms.TextBox();
            this.button1_convert = new System.Windows.Forms.Button();
            this.textBox_seconds1 = new System.Windows.Forms.TextBox();
            this.textBox_minutes1 = new System.Windows.Forms.TextBox();
            this.textBox_hours1 = new System.Windows.Forms.TextBox();
            this.textBox_days1 = new System.Windows.Forms.TextBox();
            this.label4_seconds = new System.Windows.Forms.Label();
            this.label3_minutes = new System.Windows.Forms.Label();
            this.label2_hours = new System.Windows.Forms.Label();
            this.label1_days = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(38, 393);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 44;
            // 
            // textBox_result_all
            // 
            this.textBox_result_all.Location = new System.Drawing.Point(192, 136);
            this.textBox_result_all.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_result_all.Multiline = true;
            this.textBox_result_all.Name = "textBox_result_all";
            this.textBox_result_all.Size = new System.Drawing.Size(351, 168);
            this.textBox_result_all.TabIndex = 43;
            // 
            // textBox_resultDays
            // 
            this.textBox_resultDays.Location = new System.Drawing.Point(40, 325);
            this.textBox_resultDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_resultDays.Name = "textBox_resultDays";
            this.textBox_resultDays.Size = new System.Drawing.Size(100, 22);
            this.textBox_resultDays.TabIndex = 42;
            // 
            // textBox_resultMinutes
            // 
            this.textBox_resultMinutes.Location = new System.Drawing.Point(307, 325);
            this.textBox_resultMinutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_resultMinutes.Name = "textBox_resultMinutes";
            this.textBox_resultMinutes.Size = new System.Drawing.Size(100, 22);
            this.textBox_resultMinutes.TabIndex = 41;
            // 
            // textBox_resultHours
            // 
            this.textBox_resultHours.Location = new System.Drawing.Point(175, 325);
            this.textBox_resultHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_resultHours.Name = "textBox_resultHours";
            this.textBox_resultHours.Size = new System.Drawing.Size(100, 22);
            this.textBox_resultHours.TabIndex = 40;
            // 
            // textBox_resultSeconds
            // 
            this.textBox_resultSeconds.Location = new System.Drawing.Point(443, 325);
            this.textBox_resultSeconds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_resultSeconds.Name = "textBox_resultSeconds";
            this.textBox_resultSeconds.Size = new System.Drawing.Size(100, 22);
            this.textBox_resultSeconds.TabIndex = 39;
            // 
            // button1_sub
            // 
            this.button1_sub.Location = new System.Drawing.Point(41, 214);
            this.button1_sub.Margin = new System.Windows.Forms.Padding(4);
            this.button1_sub.Name = "button1_sub";
            this.button1_sub.Size = new System.Drawing.Size(132, 28);
            this.button1_sub.TabIndex = 38;
            this.button1_sub.Text = "Вычесть";
            this.button1_sub.UseVisualStyleBackColor = true;
            this.button1_sub.Click += new System.EventHandler(this.button1_sub_Click);
            // 
            // button1_add
            // 
            this.button1_add.Location = new System.Drawing.Point(40, 175);
            this.button1_add.Margin = new System.Windows.Forms.Padding(4);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(132, 28);
            this.button1_add.TabIndex = 37;
            this.button1_add.Text = "Сложить";
            this.button1_add.UseVisualStyleBackColor = true;
            this.button1_add.Click += new System.EventHandler(this.button1_add_Click);
            // 
            // textBox_seconds2
            // 
            this.textBox_seconds2.Location = new System.Drawing.Point(443, 95);
            this.textBox_seconds2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_seconds2.Name = "textBox_seconds2";
            this.textBox_seconds2.Size = new System.Drawing.Size(100, 22);
            this.textBox_seconds2.TabIndex = 36;
            this.textBox_seconds2.Text = "5";
            // 
            // textBox_minutes2
            // 
            this.textBox_minutes2.Location = new System.Drawing.Point(307, 95);
            this.textBox_minutes2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_minutes2.Name = "textBox_minutes2";
            this.textBox_minutes2.Size = new System.Drawing.Size(100, 22);
            this.textBox_minutes2.TabIndex = 35;
            this.textBox_minutes2.Text = "2";
            // 
            // textBox_hours2
            // 
            this.textBox_hours2.Location = new System.Drawing.Point(175, 95);
            this.textBox_hours2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hours2.Name = "textBox_hours2";
            this.textBox_hours2.Size = new System.Drawing.Size(100, 22);
            this.textBox_hours2.TabIndex = 34;
            this.textBox_hours2.Text = "3";
            // 
            // textBox_days2
            // 
            this.textBox_days2.Location = new System.Drawing.Point(41, 95);
            this.textBox_days2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_days2.Name = "textBox_days2";
            this.textBox_days2.Size = new System.Drawing.Size(100, 22);
            this.textBox_days2.TabIndex = 33;
            this.textBox_days2.Text = "2";
            // 
            // button1_convert
            // 
            this.button1_convert.Location = new System.Drawing.Point(41, 248);
            this.button1_convert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1_convert.Name = "button1_convert";
            this.button1_convert.Size = new System.Drawing.Size(132, 28);
            this.button1_convert.TabIndex = 32;
            this.button1_convert.Text = "Перевести время";
            this.button1_convert.UseVisualStyleBackColor = true;
            this.button1_convert.Click += new System.EventHandler(this.button1_convert_Click);
            // 
            // textBox_seconds1
            // 
            this.textBox_seconds1.Location = new System.Drawing.Point(443, 56);
            this.textBox_seconds1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_seconds1.Name = "textBox_seconds1";
            this.textBox_seconds1.Size = new System.Drawing.Size(100, 22);
            this.textBox_seconds1.TabIndex = 31;
            this.textBox_seconds1.Text = "5";
            // 
            // textBox_minutes1
            // 
            this.textBox_minutes1.Location = new System.Drawing.Point(307, 56);
            this.textBox_minutes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_minutes1.Name = "textBox_minutes1";
            this.textBox_minutes1.Size = new System.Drawing.Size(100, 22);
            this.textBox_minutes1.TabIndex = 30;
            this.textBox_minutes1.Text = "3";
            // 
            // textBox_hours1
            // 
            this.textBox_hours1.Location = new System.Drawing.Point(175, 56);
            this.textBox_hours1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_hours1.Name = "textBox_hours1";
            this.textBox_hours1.Size = new System.Drawing.Size(100, 22);
            this.textBox_hours1.TabIndex = 29;
            this.textBox_hours1.Text = "2";
            // 
            // textBox_days1
            // 
            this.textBox_days1.Location = new System.Drawing.Point(41, 56);
            this.textBox_days1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_days1.Name = "textBox_days1";
            this.textBox_days1.Size = new System.Drawing.Size(100, 22);
            this.textBox_days1.TabIndex = 28;
            this.textBox_days1.Text = "10";
            // 
            // label4_seconds
            // 
            this.label4_seconds.AutoSize = true;
            this.label4_seconds.Location = new System.Drawing.Point(441, 25);
            this.label4_seconds.Name = "label4_seconds";
            this.label4_seconds.Size = new System.Drawing.Size(64, 16);
            this.label4_seconds.TabIndex = 27;
            this.label4_seconds.Text = "Секунды";
            // 
            // label3_minutes
            // 
            this.label3_minutes.AutoSize = true;
            this.label3_minutes.Location = new System.Drawing.Point(305, 25);
            this.label3_minutes.Name = "label3_minutes";
            this.label3_minutes.Size = new System.Drawing.Size(58, 16);
            this.label3_minutes.TabIndex = 26;
            this.label3_minutes.Text = "Минуты";
            // 
            // label2_hours
            // 
            this.label2_hours.AutoSize = true;
            this.label2_hours.Location = new System.Drawing.Point(171, 25);
            this.label2_hours.Name = "label2_hours";
            this.label2_hours.Size = new System.Drawing.Size(40, 16);
            this.label2_hours.TabIndex = 25;
            this.label2_hours.Text = "Часы\r\n";
            // 
            // label1_days
            // 
            this.label1_days.AutoSize = true;
            this.label1_days.Location = new System.Drawing.Point(37, 25);
            this.label1_days.Name = "label1_days";
            this.label1_days.Size = new System.Drawing.Size(32, 16);
            this.label1_days.TabIndex = 24;
            this.label1_days.Text = "Дни";
            // 
            // Form_Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 419);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBox_result_all);
            this.Controls.Add(this.textBox_resultDays);
            this.Controls.Add(this.textBox_resultMinutes);
            this.Controls.Add(this.textBox_resultHours);
            this.Controls.Add(this.textBox_resultSeconds);
            this.Controls.Add(this.button1_sub);
            this.Controls.Add(this.button1_add);
            this.Controls.Add(this.textBox_seconds2);
            this.Controls.Add(this.textBox_minutes2);
            this.Controls.Add(this.textBox_hours2);
            this.Controls.Add(this.textBox_days2);
            this.Controls.Add(this.button1_convert);
            this.Controls.Add(this.textBox_seconds1);
            this.Controls.Add(this.textBox_minutes1);
            this.Controls.Add(this.textBox_hours1);
            this.Controls.Add(this.textBox_days1);
            this.Controls.Add(this.label4_seconds);
            this.Controls.Add(this.label3_minutes);
            this.Controls.Add(this.label2_hours);
            this.Controls.Add(this.label1_days);
            this.Name = "Form_Time";
            this.Text = "Счетчик времени";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBox_result_all;
        private System.Windows.Forms.TextBox textBox_resultDays;
        private System.Windows.Forms.TextBox textBox_resultMinutes;
        private System.Windows.Forms.TextBox textBox_resultHours;
        private System.Windows.Forms.TextBox textBox_resultSeconds;
        private System.Windows.Forms.Button button1_sub;
        private System.Windows.Forms.Button button1_add;
        private System.Windows.Forms.TextBox textBox_seconds2;
        private System.Windows.Forms.TextBox textBox_minutes2;
        private System.Windows.Forms.TextBox textBox_hours2;
        private System.Windows.Forms.TextBox textBox_days2;
        private System.Windows.Forms.Button button1_convert;
        private System.Windows.Forms.TextBox textBox_seconds1;
        private System.Windows.Forms.TextBox textBox_minutes1;
        private System.Windows.Forms.TextBox textBox_hours1;
        private System.Windows.Forms.TextBox textBox_days1;
        private System.Windows.Forms.Label label4_seconds;
        private System.Windows.Forms.Label label3_minutes;
        private System.Windows.Forms.Label label2_hours;
        private System.Windows.Forms.Label label1_days;
    }
}

