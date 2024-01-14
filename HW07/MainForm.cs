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
    public partial class MainForm : Form
    {
        //Child child = new Child();
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowChildButton_Click(object sender, EventArgs e)
        {
            //if (child != null) child.Close();
            //Child child = new Child();
            //child.Show(); | child.ShowDialog();

            //1
            //Child child = new Child();
            //child.textBox1.Text = textBox1.Text;

            //2
            //Child child = new Child(textBox1.Text);
            //child.Show();

            //3
            //Child child = new Child();
            //child.ShowDialog(textBox1.Text);

            //4.1
            //Child child = new Child();
            //child.MyProperty = textBox1.Text;
            //child.ShowDialog();
            //textBox1.Text = child.MyProperty;

            //4.2 - BEST
            using (Child child = new Child())
            {
                child.MyProperty = textBox1.Text;
                if (child.ShowDialog() == DialogResult.Yes)
                    textBox1.Text = child.MyProperty;
            }
        }
    }
}