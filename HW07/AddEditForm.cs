using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kotv_lesson7
{
    public partial class AddEditForm : Form
    {
        public Student Student { get; set; }
        public AddEditForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Ви не ввели ім'я");
                return;
            }
            if (string.IsNullOrWhiteSpace(AvgTextBox.Text))
            {
                MessageBox.Show("Ви не ввели оцінку");
                return;
            }

            if (this.Text == "AddForm")
            {
                string name = NameTextBox.Text;

                DateTime date = dateTimePicker1.Value;

                double avg = double.Parse(AvgTextBox.Text.Replace('.', ','));

                Student = new Student(name, date, avg);
            }
            else
            {
                string name = NameTextBox.Text;

                DateTime date = dateTimePicker1.Value;

                if (AvgTextBox.Text.Contains('.'))
                    AvgTextBox.Text.Replace('.', ',');
                double avg = double.Parse(AvgTextBox.Text);

                Student = new Student(name, date, avg);
            }
            DialogResult = DialogResult.Yes;
            this.Close();
        }


        private void AddEditForm_Load(object sender, EventArgs e)
        {
            if (Student != null && this.Text == "EditForm")
            {
                NameTextBox.Text = Student.Name;
                dateTimePicker1.Value = Student.Birth;
                AvgTextBox.Text = Student.AvgMarks.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
