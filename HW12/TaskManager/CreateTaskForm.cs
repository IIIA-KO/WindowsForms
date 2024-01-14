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
    public partial class CreateTaskForm : Form
    {
        private bool isEdit = false;

        public ToDo Task { get; set; }

        public string Path = string.Empty;

        public CreateTaskForm(bool IsEdit)
        {
            InitializeComponent();
            isEdit = IsEdit;
        }

        private void CreateTaskForm_Load(object sender, EventArgs e)
        {
            if (isEdit) this.Text = "Редагувати задачу";
            else this.Text = "Створити задачу";

            if (Task != null && isEdit)
            {
                TaskTextBox.Text = Task.Name;

                switch (Task.Priority)
                {
                    case TaskPriority.Low:
                        PriorityComboBox.SelectedIndex = 0; break;

                    case TaskPriority.Medium:
                        PriorityComboBox.SelectedIndex = 1; break;

                    case TaskPriority.High:
                        PriorityComboBox.SelectedIndex = 2; break;
                }

                if (Task.DeadLine == DateTime.MinValue)
                {
                    TimerRadioButton.Checked = true;
                    TimeComboBox.SelectedIndex = 1;

                    TimeCountTextBox.Text = (Task.TimerToDo.Interval / 3600000).ToString();
                }
                else
                {
                    DeadLineRadioButton.Checked = true;
                    DateTimePicker.Value = Task.DeadLine;
                }

                if (Task.Tags.Count != 0) TagsTextBox.Text = String.Join(", ", Task.Tags);
                if (!string.IsNullOrWhiteSpace(Task.Comment)) CommentTextBox.Text = Task.Comment;
                if (!string.IsNullOrWhiteSpace(Task.PathToAttachedFile)) Path = Task.PathToAttachedFile;
            }
            else
            {
                PriorityComboBox.SelectedIndex = 0;
                TimeComboBox.SelectedIndex = 0;
            }
        }

        private void RadioButtonsChanged(object sender, EventArgs e)
        {
            if (DeadLineRadioButton.Checked)
            {
                DateTimePicker.Enabled = true;
                TimeComboBox.Enabled = false;
                TimeCountTextBox.Enabled = false;
                TimeCountTextBox.Text = "";
                TimeComboBox.SelectedIndex = 0;
            }
            if (TimerRadioButton.Checked)
            {
                TimeComboBox.Enabled = true;
                TimeCountTextBox.Enabled = true;
                DateTimePicker.Enabled = false;
                DateTimePicker.Value = DateTime.Today;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TaskTextBox.Text))
            {
                throw new Exception("Потрібно ввести, що потрібно зробити");
            }

            if (!DeadLineRadioButton.Checked && !TimerRadioButton.Checked)
            {
                throw new Exception("Потрібно встановити дедлайн для задачі");
            }

            if (TimerRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(TimeCountTextBox.Text))
                {
                    throw new Exception($"Потрібно встановити кількість {TimeComboBox.SelectedItem} для створення задачі");
                }
            }

            string TaskToDo = TaskTextBox.Text;
            DateTime DeadLine = DateTimePicker.Value;

            TaskPriority Priority = TaskPriority.Low;
            switch (PriorityComboBox.SelectedIndex)
            {
                case 0: Priority = TaskPriority.Low; break;
                case 1: Priority = TaskPriority.Medium; break;
                case 2: Priority = TaskPriority.High; break;

                default: throw new Exception("Недопустиме значення для приорітету");
            }

            List<string> Tags;
            if (!string.IsNullOrWhiteSpace(TagsTextBox.Text))
            {
                Tags = TagsTextBox.Text.Split(',').ToList();
            }
            else
            {
                Tags = new List<string>();
            }

            string Comment;
            if (!string.IsNullOrWhiteSpace(CommentTextBox.Text))
            {
                Comment = CommentTextBox.Text;
            }
            else
            {
                Comment = string.Empty;
            }

            if (DeadLineRadioButton.Checked)
            {
                Task = new ToDo(TaskToDo, DeadLine, Priority, Tags, Comment, Path);
            }
            if (TimerRadioButton.Checked)
            {
                if (!int.TryParse(TimeCountTextBox.Text, out int millieseconds))
                {
                    throw new Exception("Час на виконання задачі має бути цілим числом");
                }
                if (millieseconds <= 0)
                {
                    throw new Exception("Час на виконання задачі має бути більше 0");
                }

                switch (TimeComboBox.SelectedIndex)
                {
                    case 0:
                        if (millieseconds > 35791)
                        {
                            MessageBox.Show("Максимальне значення хвилин для дедлайну - 35791");
                            millieseconds = 35791;
                        }
                        millieseconds *= 60000;
                        break;

                    case 1:
                        if (millieseconds > 596)
                        {
                            MessageBox.Show("Максимальне значення годин для дедлайну - 596");
                            millieseconds = 596;
                        }
                        millieseconds *= 3600000;
                        break;

                    case 2:
                        if (millieseconds > 24)
                        {
                            MessageBox.Show("Максимальне значення днів для дедлайну - 24");
                            millieseconds = 24;
                        }
                        millieseconds *= 86400000; break;
                }

                Task = new ToDo(TaskToDo, Priority, Tags, Comment, Path, millieseconds);
            }
            DialogResult = DialogResult.Yes;
        }

        private void SearchFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Path = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
