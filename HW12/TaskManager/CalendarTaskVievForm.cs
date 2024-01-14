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
    public enum CalendarViev
    {
        Month,
        Week,
        Day
    }

    public partial class CalendarTaskVievForm : Form
    {
        private CalendarViev viev;

        private List<Project> Projects;

        public CalendarTaskVievForm(CalendarViev calendarViev, List<Project> projects)
        {
            InitializeComponent();

            this.viev = calendarViev;

            Projects = projects;
        }

        private void CalendarTaskVievForm_Load(object sender, EventArgs e)
        {
            try
            {
                TasksListBox.Items.Clear();

                ProjectsListBox.Items.AddRange(Projects.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        private void ProjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Project project = ProjectsListBox.SelectedItem as Project;

                TasksListBox.Items.Clear();

                switch (viev)
                {
                    case CalendarViev.Month:
                        this.Text = "Задачі на місяць";
                        foreach (ToDo toDo in project.ToDos)
                        {
                            if (toDo.DeadLine != DateTime.MinValue)
                            {
                                if (toDo.DeadLine >= DateTime.Now && toDo.DeadLine <= DateTime.Now.AddDays(30))
                                {
                                    TasksListBox.Items.Add(toDo);
                                }
                            }
                            else
                            {
                                if (toDo.TimerToDo.Interval > 0 && toDo.TimerToDo.Interval <= (86400000 * (DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - DateTime.Now.Day)))
                                {
                                    TasksListBox.Items.Add(toDo);
                                }
                            }
                        }
                        break;

                    case CalendarViev.Week:
                        this.Text = "Задачі на тиждень";
                        foreach (ToDo toDo in project.ToDos)
                        {
                            if (toDo.DeadLine != DateTime.MinValue)
                            {
                                if (toDo.DeadLine >= DateTime.Now && toDo.DeadLine <= DateTime.Now.AddDays(7))
                                {
                                    TasksListBox.Items.Add(toDo);
                                }
                            }
                            else
                            {
                                if (toDo.TimerToDo.Interval > 0 && toDo.TimerToDo.Interval <= (86400000 * 7))
                                {
                                    TasksListBox.Items.Add(toDo);
                                }
                            }
                        }
                        break;

                    case CalendarViev.Day:
                        this.Text = "Задачі на день";
                        foreach (ToDo toDo in project.ToDos)
                        {
                            if (toDo.DeadLine != DateTime.MinValue)
                            {
                                if (toDo.DeadLine == DateTime.Today)
                                {
                                    TasksListBox.Items.Add(toDo);
                                }
                            }
                            else
                            {
                                if (toDo.TimerToDo.Interval > 0 && toDo.TimerToDo.Interval <= 86400000)
                                {
                                    TasksListBox.Items.Add(toDo);
                                }
                            }
                        }
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