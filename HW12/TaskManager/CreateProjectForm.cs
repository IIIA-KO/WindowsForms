using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class CreateProjectForm : Form
    {
        public Project Project { get; set; }

        private bool isEdit = false;

        public CreateProjectForm(bool IsEdit)
        {
            InitializeComponent();
            isEdit = IsEdit;
        }

        private void CreateProjectForm_Load(object sender, EventArgs e)
        {
            if (isEdit) Text = "Редагувати проект";
            else Text = "Створити проект";

            if (Project != null && isEdit)
            {
                NameTextBox.Text = Project.Name;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                throw new Exception("Щоб створити проект необхідно ввести ім'я проекту");

            if (!isEdit)
            {
                Project = new Project(NameTextBox.Text);
            }
            else
            {
                Project.Name = NameTextBox.Text;
            }

            DialogResult = DialogResult.Yes;
        }
    }
}
