using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            DateTime Date = dateTimePicker1.Value;
            var Diff = (Now - Date);

            if (YearRadioButton.Checked)
            {
                DateTime now = DateTime.Today;
                int dif = now.Year - Date.Year;
                if (Date > now.AddYears(-dif)) dif--;

                if (dif < 0)
                    MessageBox.Show("Некоректна дата");
                else
                    MessageBox.Show(dif.ToString());
            }
            if (MonthRadioButton.Checked)
            {
                double dif = 12 * (Now.Year - Date.Year) + (Now.Month - Date.Month);

                if (dif < 0)
                    MessageBox.Show("Некоректна дата");
                else
                    MessageBox.Show(dif.ToString());
            }
            if (DayRadioButton.Checked)
            {
                double dif = Diff.TotalDays;

                if (dif < 0)
                    MessageBox.Show("Некоректна дата");
                else
                    MessageBox.Show(dif.ToString());
            }
            if (MinuteRadioButton.Checked)
            {
                double dif = Diff.TotalMinutes;

                if (dif < 0)
                    MessageBox.Show("Некоректна дата");
                else
                    MessageBox.Show(dif.ToString());
            }
            if (SecondRadioButton.Checked)
            {
                double dif = Diff.TotalSeconds;

                if (dif < 0)
                    MessageBox.Show("Некоректна дата");
                else
                    MessageBox.Show(dif.ToString());
            }
        }

        private void ResultLabelChange(object sender, EventArgs e)
        {
            ResultLabel.Text = Math.Abs((dateTimePicker3.Value - dateTimePicker2.Value).Days).ToString();
        }
    }
}
