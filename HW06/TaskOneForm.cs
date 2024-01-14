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
    public partial class TaskOneForm : Form
    {
        public TaskOneForm()
        {
            InitializeComponent();

            this.Width = pictureBox1.Width - 100;
            this.Height = pictureBox1.Height - 100;
            pictureBox1.Location = new Point(0, 0);

            vScrollBar1.Maximum = pictureBox1.Height - ClientSize.Height + hScrollBar1.Height;
            hScrollBar1.Maximum = pictureBox1.Height - ClientSize.Height + hScrollBar1.Height;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point(0, -vScrollBar1.Value);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point(-hScrollBar1.Value, 0);
        }
    }
}
