using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TaskButton1_Click(object sender, EventArgs e)
        {
            TaskOneForm taskOneForm = new TaskOneForm();

            this.Hide();
            taskOneForm.ShowDialog();
            this.Show();
        }

        private void TaskButton2_Click(object sender, EventArgs e)
        {
            TaskTwoForm taskTwoForm = new TaskTwoForm();

            this.Hide();
            taskTwoForm.ShowDialog();
            this.Show();
        }

        private void TaskButton3_Click(object sender, EventArgs e)
        {
            TaskThreeForm taskThreeForm = new TaskThreeForm();

            this.Hide();
            taskThreeForm.ShowDialog();
            this.Show();
        }

    }
}
