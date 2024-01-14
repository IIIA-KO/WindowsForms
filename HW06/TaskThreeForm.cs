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
    public partial class TaskThreeForm : Form
    {
        public TaskThreeForm()
        {
            InitializeComponent();
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            RTextBox.Text = RTrackBar.Value.ToString();
            GTextBox.Text = GTrackBar.Value.ToString();
            BTextBox.Text = BTrackBar.Value.ToString();

            int red = RTrackBar.Value;
            int green = GTrackBar.Value;
            int blue = BTrackBar.Value;

            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
