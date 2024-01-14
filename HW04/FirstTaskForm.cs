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
    public partial class FirstTaskForm : Form
    {
        public FirstTaskForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.Insert(listBox1.SelectedIndex, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string shortest = listBox1.Items[0].ToString();
                string longest = listBox1.Items[0].ToString();

                for (int i = 1; i < listBox1.Items.Count; i++)
                    if (shortest.Length > listBox1.Items[i].ToString().Length)
                        shortest = listBox1.Items[i].ToString();
                ShortestItemTextBox.Text = shortest;

                for (int i = 1; i < listBox1.Items.Count; i++)
                    if (longest.Length < listBox1.Items[i].ToString().Length)
                        longest = listBox1.Items[i].ToString();
                LongestItemTextBox.Text = longest;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
