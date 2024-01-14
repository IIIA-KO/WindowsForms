using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class SecondTaskForm : Form
    {
        public SecondTaskForm()
        {
            InitializeComponent();
        }

        //Я захотів 3 варіант
        private double f1(double x)
        {
            return 2 * x * Math.Pow(Math.E, -x);
        }
        private double f2(double x)
        {
            return Math.Pow((x - 1), 3) + Math.Cos(Math.Pow(x, 3));
        }
        private double f3(double x)
        {
            return 2 * Math.Sqrt(Math.Pow(x, 3)) * Math.Sin(Math.Pow(x, 3));
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(XminTextBox.Text) || string.IsNullOrWhiteSpace(XmaxTextBox.Text)
                    || string.IsNullOrWhiteSpace(StepTextBox.Text) || string.IsNullOrWhiteSpace(ATextBox.Text))
                    throw new Exception("Поле пусте");

                string ResultString = "";

                double min = double.Parse(XminTextBox.Text);
                double max = double.Parse(XmaxTextBox.Text);
                double step = double.Parse(StepTextBox.Text);
                double aValue = double.Parse(ATextBox.Text);
                while (min <= max)
                {
                    if (min <= 0)
                    {
                        ResultString = $"При x = {min}, y = {f1(min):N8}";
                    }
                    else if (min > 0 && min <= aValue)
                    {
                        ResultString = $"При x = {min}, y = {f2(min):N8}";
                    }
                    else ResultString = $"При x = {min}, y = {f3(min):N8}";
                    listBox1.Items.Add(ResultString);
                    min += step;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
