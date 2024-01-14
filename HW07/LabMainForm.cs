using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Kotv_lesson7
{
    public partial class LabMainForm : Form
    {
        private static List<Student> students = new List<Student>();
        private static string Path = @"Students.xml";

        public LabMainForm()
        {
            InitializeComponent();
            this.LoadStudents();
            foreach (var item in students)
                listBox1.Items.Add(item);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm();
            addEditForm.Text = "AddForm";
            if (addEditForm.ShowDialog() == DialogResult.Yes)
            {
                Student st = addEditForm.Student;
                students.Add(st);

                listBox1.Items.Add(st);
            }
            this.SaveStudents();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Студент не вибраний");
                return;
            }

            AddEditForm addEditForm = new AddEditForm();
            addEditForm.Text = "EditForm";

            Student selectedSt = listBox1.SelectedItem as Student;

            addEditForm.Student = selectedSt;

            if (addEditForm.ShowDialog() == DialogResult.Yes)
            {
                Student st = addEditForm.Student;
                listBox1.Items[listBox1.SelectedIndex] = st;
            }

            students.Clear();
            foreach (Student st in listBox1.Items)
                students.Add(st);

            this.SaveStudents();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Студент не вибраний");
                return;
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            students.Clear();
            foreach (Student st in listBox1.Items)
                students.Add(st);
            this.SaveStudents();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            students.Clear();
            foreach (Student st in listBox1.Items)
                students.Add(st);
            this.SaveStudents();
        }

        private void SaveStudents()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Student>));
            using (var writer = new StreamWriter(Path))
            {
                xmlSerializer.Serialize(writer, students);
            }

        }
        private void LoadStudents()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Student>));
            using (var reader = new StreamReader(Path))
            {
                var studs = (List<Student>)xmlSerializer.Deserialize(reader);
                students = studs;
            }
        }
    }
}
