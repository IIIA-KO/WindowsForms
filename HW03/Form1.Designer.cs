namespace HW3
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Date1Label = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Task2Label = new System.Windows.Forms.Label();
            this.YearRadioButton = new System.Windows.Forms.RadioButton();
            this.MonthRadioButton = new System.Windows.Forms.RadioButton();
            this.DayRadioButton = new System.Windows.Forms.RadioButton();
            this.MinuteRadioButton = new System.Windows.Forms.RadioButton();
            this.SecondRadioButton = new System.Windows.Forms.RadioButton();
            this.Task1Label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ChooseDateLabel = new System.Windows.Forms.Label();
            this.Task1Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ResultLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Date1Label);
            this.panel2.Controls.Add(this.dateTimePicker3);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.Task2Label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(384, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 450);
            this.panel2.TabIndex = 1;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(50, 341);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 31);
            this.ResultLabel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Оберіть дату:";
            // 
            // Date1Label
            // 
            this.Date1Label.AutoSize = true;
            this.Date1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date1Label.Location = new System.Drawing.Point(15, 191);
            this.Date1Label.Name = "Date1Label";
            this.Date1Label.Size = new System.Drawing.Size(134, 24);
            this.Date1Label.TabIndex = 9;
            this.Date1Label.Text = "Оберіть дату:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(19, 218);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 8;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.ResultLabelChange);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(19, 290);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.ResultLabelChange);
            // 
            // Task2Label
            // 
            this.Task2Label.AutoSize = true;
            this.Task2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Task2Label.Location = new System.Drawing.Point(3, 9);
            this.Task2Label.Name = "Task2Label";
            this.Task2Label.Size = new System.Drawing.Size(98, 20);
            this.Task2Label.TabIndex = 6;
            this.Task2Label.Text = "Завдання 2";
            // 
            // YearRadioButton
            // 
            this.YearRadioButton.AutoSize = true;
            this.YearRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearRadioButton.Location = new System.Drawing.Point(258, 187);
            this.YearRadioButton.Name = "YearRadioButton";
            this.YearRadioButton.Size = new System.Drawing.Size(71, 28);
            this.YearRadioButton.TabIndex = 0;
            this.YearRadioButton.TabStop = true;
            this.YearRadioButton.Text = "Роки";
            this.YearRadioButton.UseVisualStyleBackColor = true;
            // 
            // MonthRadioButton
            // 
            this.MonthRadioButton.AutoSize = true;
            this.MonthRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthRadioButton.Location = new System.Drawing.Point(258, 221);
            this.MonthRadioButton.Name = "MonthRadioButton";
            this.MonthRadioButton.Size = new System.Drawing.Size(83, 28);
            this.MonthRadioButton.TabIndex = 1;
            this.MonthRadioButton.TabStop = true;
            this.MonthRadioButton.Text = "Місяці";
            this.MonthRadioButton.UseVisualStyleBackColor = true;
            // 
            // DayRadioButton
            // 
            this.DayRadioButton.AutoSize = true;
            this.DayRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayRadioButton.Location = new System.Drawing.Point(258, 255);
            this.DayRadioButton.Name = "DayRadioButton";
            this.DayRadioButton.Size = new System.Drawing.Size(57, 28);
            this.DayRadioButton.TabIndex = 2;
            this.DayRadioButton.TabStop = true;
            this.DayRadioButton.Text = "Дні";
            this.DayRadioButton.UseVisualStyleBackColor = true;
            // 
            // MinuteRadioButton
            // 
            this.MinuteRadioButton.AutoSize = true;
            this.MinuteRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinuteRadioButton.Location = new System.Drawing.Point(258, 289);
            this.MinuteRadioButton.Name = "MinuteRadioButton";
            this.MinuteRadioButton.Size = new System.Drawing.Size(105, 28);
            this.MinuteRadioButton.TabIndex = 3;
            this.MinuteRadioButton.TabStop = true;
            this.MinuteRadioButton.Text = "Хвилини";
            this.MinuteRadioButton.UseVisualStyleBackColor = true;
            // 
            // SecondRadioButton
            // 
            this.SecondRadioButton.AutoSize = true;
            this.SecondRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondRadioButton.Location = new System.Drawing.Point(258, 323);
            this.SecondRadioButton.Name = "SecondRadioButton";
            this.SecondRadioButton.Size = new System.Drawing.Size(104, 28);
            this.SecondRadioButton.TabIndex = 4;
            this.SecondRadioButton.TabStop = true;
            this.SecondRadioButton.Text = "Секунди";
            this.SecondRadioButton.UseVisualStyleBackColor = true;
            // 
            // Task1Label
            // 
            this.Task1Label.AutoSize = true;
            this.Task1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Task1Label.Location = new System.Drawing.Point(3, 9);
            this.Task1Label.Name = "Task1Label";
            this.Task1Label.Size = new System.Drawing.Size(98, 20);
            this.Task1Label.TabIndex = 5;
            this.Task1Label.Text = "Завдання 1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 227);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // ChooseDateLabel
            // 
            this.ChooseDateLabel.AutoSize = true;
            this.ChooseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDateLabel.Location = new System.Drawing.Point(12, 200);
            this.ChooseDateLabel.Name = "ChooseDateLabel";
            this.ChooseDateLabel.Size = new System.Drawing.Size(134, 24);
            this.ChooseDateLabel.TabIndex = 7;
            this.ChooseDateLabel.Text = "Оберіть дату:";
            // 
            // Task1Button
            // 
            this.Task1Button.Location = new System.Drawing.Point(55, 328);
            this.Task1Button.Name = "Task1Button";
            this.Task1Button.Size = new System.Drawing.Size(121, 23);
            this.Task1Button.TabIndex = 8;
            this.Task1Button.Text = "Розрахувати";
            this.Task1Button.UseVisualStyleBackColor = true;
            this.Task1Button.Click += new System.EventHandler(this.Task1Button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Task1Button);
            this.panel1.Controls.Add(this.ChooseDateLabel);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Task1Label);
            this.panel1.Controls.Add(this.SecondRadioButton);
            this.panel1.Controls.Add(this.MinuteRadioButton);
            this.panel1.Controls.Add(this.DayRadioButton);
            this.panel1.Controls.Add(this.MonthRadioButton);
            this.panel1.Controls.Add(this.YearRadioButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 450);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Task2Label;
        private System.Windows.Forms.RadioButton YearRadioButton;
        private System.Windows.Forms.RadioButton MonthRadioButton;
        private System.Windows.Forms.RadioButton DayRadioButton;
        private System.Windows.Forms.RadioButton MinuteRadioButton;
        private System.Windows.Forms.RadioButton SecondRadioButton;
        private System.Windows.Forms.Label Task1Label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label ChooseDateLabel;
        private System.Windows.Forms.Button Task1Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Date1Label;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

