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
    public partial class TaskTwoForm : Form
    {
        public TaskTwoForm()
        {
            InitializeComponent();
            timer1.Start();
            TimeLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HoursLabel.Text = DateTime.Now.Hour.ToString();
            MinutesLabel.Text = DateTime.Now.Minute.ToString();
            SecondsLabel.Text = DateTime.Now.Second.ToString();

            HoursProgressBar.Value = DateTime.Now.Hour;
            MinutesProgressBar.Value = DateTime.Now.Minute;
            SecondsProgressBar.Value = DateTime.Now.Second;
        }
    }
}
