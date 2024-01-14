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
    public partial class FindForm : Form
    {
        private List<Project> Projects;

        public FindForm(List<Project> projects)
        {
            InitializeComponent();
            Projects = projects;
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        TasksListBox.Items.Clear();
                        foreach (Project p in Projects)
                            TasksListBox.Items.AddRange(p.ToDos.Where(t => t.Priority == TaskPriority.Low).ToArray());
                        break;


                    case 1:
                        TasksListBox.Items.Clear();
                        foreach (Project p in Projects)
                            TasksListBox.Items.AddRange(p.ToDos.Where(t => t.Priority == TaskPriority.Medium).ToArray());
                        break;


                    case 2:
                        TasksListBox.Items.Clear();
                        foreach (Project p in Projects)
                            TasksListBox.Items.AddRange(p.ToDos.Where(t => t.Priority == TaskPriority.High).ToArray());
                        break;


                    case 3:
                        TasksListBox.Items.Clear();
                        foreach (Project p in Projects)
                            TasksListBox.Items.AddRange(p.ToDos.Where(t => !string.IsNullOrWhiteSpace(t.PathToAttachedFile)).ToArray());
                        break;


                    case 4:
                        TasksListBox.Items.Clear();

                        foreach (Project p in Projects)
                            TasksListBox.Items.AddRange(p.ToDos.Where(t => t.DeadLine != DateTime.MinValue).ToArray());
                        break;


                    case 5:
                        TasksListBox.Items.Clear();
                        foreach (Project p in Projects)
                            TasksListBox.Items.AddRange(p.ToDos.Where(t => t.DeadLine == DateTime.MinValue).ToArray());
                        break;


                    case 6:
                        TasksListBox.Items.Clear();
                        foreach (Project p in Projects)
                            TasksListBox.Items.AddRange(p.ToDos.ToArray());

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
    }
}
