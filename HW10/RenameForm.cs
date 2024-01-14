using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW10
{
    public partial class RenameForm : Form
    {
        public string FileName { get; set; }
        public RenameForm(string fileName)
        {
            InitializeComponent();
            textBox1.Text = fileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                this.Close();
                throw new Exception("Файл не може мати пусту назву");
            }
            FileName = textBox1.Text;
            DialogResult = DialogResult.Yes;
        }
    }
}
