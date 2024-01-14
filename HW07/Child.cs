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
    public partial class Child : Form
    {

        public string MyProperty
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }


        public Child()
        {
            InitializeComponent();
        }
        public Child(string text) : this()
        {
            textBox1.Text = text;
        }

        public DialogResult ShowDialog(string text)
        {
            textBox1.Text = text;
            return ShowDialog();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
