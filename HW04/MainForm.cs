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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FirstTaskButton_Click(object sender, EventArgs e)
        {
            FirstTaskForm firstTaskForm = new FirstTaskForm();

            firstTaskForm.MdiParent = this;
            firstTaskForm.Dock = DockStyle.Fill;
            firstTaskForm.Show();
            this.Show();
        }

        private void SecondTaskButton_Click(object sender, EventArgs e)
        {
            SecondTaskForm secondTaskForm = new SecondTaskForm();

            secondTaskForm.MdiParent = this;
            secondTaskForm.Dock = DockStyle.Fill;
            secondTaskForm.Show();
            this.Show();
        }
    }
}
