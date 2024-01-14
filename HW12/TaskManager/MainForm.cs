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

using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Drawing.Layout;
using Newtonsoft.Json;

namespace TaskManager
{
    public partial class MainForm : Form
    {
        private readonly string Path = @"ToDoList.json";
        public static List<Project> Projects;



        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Path))
                {
                    Projects = LoadAllJson();
                    ProjectsListBox.Items.AddRange(Projects.ToArray());

                }
                if (ProjectsListBox.Items.Count == 0)
                {
                    Projects = new List<Project>();

                    SetBolleanValue(false);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }



        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                CreateTaskForm createTaskForm = new CreateTaskForm(false);

                if (createTaskForm.ShowDialog() == DialogResult.Yes)
                {
                    ToDo Task = createTaskForm.Task;

                    Project project = ProjectsListBox.SelectedItem as Project;

                    if (project != null)
                    {
                        foreach (ToDo toDo in project.ToDos)
                        {
                            if (Task.Name == toDo.Name)
                                throw new Exception("Помилка: задача з такою назвою в цьому проекті вже існує");
                        }
                        project.ToDos.Add(Task);

                        Refresh();
                        SaveAllJson();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private void CreateProjectToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                CreateProjectForm createProjectForm = new CreateProjectForm(false);

                if (createProjectForm.ShowDialog() == DialogResult.Yes)
                {
                    Project project = createProjectForm.Project;

                    if (project != null)
                    {
                        foreach (Project pr in ProjectsListBox.Items)
                        {
                            if (pr.Name == project.Name)
                                throw new Exception("Проект з такою назвою вже існує");
                        }

                        Projects.Add(project);
                        ProjectsListBox.Items.Clear();
                        ProjectsListBox.Items.AddRange(Projects.ToArray());
                    }

                    SetBolleanValue(true);

                    ProjectsListBox.SelectedIndex = 0;


                    Refresh();
                    SaveAllJson();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }



        private void DeleteTaskToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Project project = ProjectsListBox.SelectedItem as Project;
                if (project != null)
                {
                    ToDo toDo = TasksListBox.SelectedItem as ToDo;
                    if (toDo != null)
                    {
                        project.ToDos.Remove(toDo);
                    }
                }

                Refresh();
                SaveAllJson();
                MessageBox.Show("Задачу було видалено");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private void DeleteProjectToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Project project = ProjectsListBox.SelectedItem as Project;
                if (project != null)
                {
                    ProjectsListBox.Items.Remove(project);
                    Projects.Remove(project);
                }

                if (ProjectsListBox.Items.Count == 0)
                    SetBolleanValue(false);

                Refresh();
                SaveAllJson();
                MessageBox.Show("Проект було видалено");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }




        private void FindToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                FindForm findForm = new FindForm(Projects);
                findForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }



        private void EditProjectToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProjectsListBox.SelectedIndex == -1)
                    throw new Exception("Проект не вибраний");

                CreateProjectForm editForm = new CreateProjectForm(true);

                Project selectedPr = ProjectsListBox.SelectedItem as Project;

                editForm.Project = selectedPr;

                if (editForm.ShowDialog() == DialogResult.Yes)
                {
                    Project pr = editForm.Project;
                    Projects[ProjectsListBox.SelectedIndex] = pr;
                }

                ProjectsListBox.Items.Clear();
                ProjectsListBox.Items.AddRange(Projects.ToArray());

                Refresh();
                SaveAllJson();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private void EditTaskToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TasksListBox.SelectedIndex == -1)
                    throw new Exception("Задача не вибрана");

                Project project = ProjectsListBox.SelectedItem as Project;

                CreateTaskForm editTaskForm = new CreateTaskForm(true);

                ToDo selectedTask = TasksListBox.SelectedItem as ToDo;

                editTaskForm.Task = selectedTask;

                if (editTaskForm.ShowDialog() == DialogResult.Yes)
                {
                    ToDo toDo = editTaskForm.Task;
                    project.ToDos[TasksListBox.SelectedIndex] = toDo;
                }

                ProjectsListBox.Items.Clear();
                ProjectsListBox.Items.AddRange(Projects.ToArray());

                Refresh();
                SaveAllJson();
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
                TasksListBox.Items.Clear();
                Project project = ProjectsListBox.SelectedItem as Project;

                if (project != null)
                {
                    foreach (ToDo task in project.ToDos)
                    {
                        if (task != null)
                        {
                            TasksListBox.Items.Add(task);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }



        private void SavePDF()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All PDF Files|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;

                PdfDocument pdfDocument = new PdfDocument();

                PdfPage pdfPage = pdfDocument.AddPage();

                XGraphics xGraphics = XGraphics.FromPdfPage(pdfPage);

                XTextFormatter tf = new XTextFormatter(xGraphics);

                XFont xFontTask = new XFont("Arial", 12);
                XFont xFontProject = new XFont("Arial", 14, XFontStyle.Bold);

                double Y = -xFontProject.Size;

                for (int i = 0; i < ProjectsListBox.Items.Count; i++)
                {
                    Project project = ProjectsListBox.Items[i] as Project;

                    if (i != 0)
                        tf.DrawString("", xFontProject, XBrushes.Black, new XRect(0, Y += xFontProject.Size, pdfPage.Width, pdfPage.Height), XStringFormats.TopLeft);

                    tf.DrawString(project.Name + ":", xFontProject, XBrushes.Black, new XRect(0, Y += xFontProject.Size, pdfPage.Width, pdfPage.Height), XStringFormats.TopLeft);

                    for (int j = 0; j < project.ToDos.Count; j++)
                    {
                        tf.DrawString($"{j + 1}    {project.ToDos[j]}", xFontTask, XBrushes.Black, new XRect(0, Y += xFontProject.Size + 1, pdfPage.Width, pdfPage.Height), XStringFormats.TopLeft);
                    }
                }

                pdfDocument.Save(path);

                MessageBox.Show("Повідомлення: PDF файл було збережено");
            }
        }
        private void SavePDFButton_Click(object sender, EventArgs e)
        {
            try
            {
                SavePDF();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }




        private void задачіНаМісяцьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarTaskVievForm calendarTaskVievForm = new CalendarTaskVievForm(CalendarViev.Month, Projects);
            calendarTaskVievForm.ShowDialog();
        }
        private void задачіНаТижденьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarTaskVievForm calendarTaskVievForm = new CalendarTaskVievForm(CalendarViev.Week, Projects);
            calendarTaskVievForm.ShowDialog();
        }
        private void задачіНаДеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarTaskVievForm calendarTaskVievForm = new CalendarTaskVievForm(CalendarViev.Day, Projects);
            calendarTaskVievForm.ShowDialog();
        }



        private void переглянутиПрикріпленийФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToDo toDo = TasksListBox.SelectedItem as ToDo;
                if (toDo != null && !string.IsNullOrWhiteSpace(toDo.PathToAttachedFile))
                {
                    System.Diagnostics.Process MyProc = new System.Diagnostics.Process();
                    MyProc.StartInfo.FileName = toDo.PathToAttachedFile;
                    MyProc.Start();
                }
                else
                {
                    throw new Exception("Задача не містить файлу");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }



        private void Refresh()
        {
            if (ProjectsListBox.SelectedIndex != -1)
                ProjectsListBox_SelectedIndexChanged(null, null);
        }
        private void SetBolleanValue(bool value)
        {
            EditTaskToolStripButton.Enabled = value;
            редагуватиЗадачуToolStripMenuItem.Enabled = value;

            EditProjectToolStripButton.Enabled = value;
            редагуватиПроектToolStripMenuItem.Enabled = value;

            CreateTaskToolStripButton.Enabled = value;
            CreateTaskToolStripMenuItem.Enabled = value;

            SavePDFButton.Enabled = value;
            зберегтиPDFToolStripMenuItem.Enabled = value;

            DeleteTaskToolStripButton.Enabled = value;
            видалитиЗадачуToolStripMenuItem.Enabled = value;

            DeleteProjectToolStripButton.Enabled = value;
            видалитиПроектToolStripMenuItem.Enabled = value;

            FindToolStripButton.Enabled = value;
            FindTaskToolStripMenuItem.Enabled = value;

            CalendarToolStripMenuItem.Enabled = value;
        }
        private void SaveAllJson()
        {
            try
            {
                var serializer = new Newtonsoft.Json.JsonSerializer();
                using (StreamWriter fs = new StreamWriter(Path))
                {
                    using (var jsonTextWriter = new JsonTextWriter(fs))
                    {
                        serializer.Serialize(fs, Projects);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<Project> LoadAllJson()
        {
            List<Project> lst = null;
            try
            {
                lst = JsonConvert.DeserializeObject<List<Project>>(File.ReadAllText(Path));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lst;
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAllJson();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAllJson();
            Application.Exit();
        }



        private void ProjectsListBox_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.StringFormat))
                    e.Effect = DragDropEffects.Move;
                else
                    e.Effect = DragDropEffects.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private void ProjectsListBox_DragLeave(object sender, EventArgs e)
        {
            try
            {
                ToDo toDo = TasksListBox.SelectedItem as ToDo;

                int i = ProjectsListBox.IndexFromPoint(ProjectsListBox.PointToClient(MousePosition));
                Projects[i].ToDos.Add(toDo);

                TasksListBox.Items.Remove(toDo);


                int SelInd = ProjectsListBox.SelectedIndex;
                Projects[SelInd].ToDos.Remove(toDo);
                ProjectsListBox.SelectedIndex = i;
                Refresh();


                ProjectsListBox.Items.Clear();
                ProjectsListBox.Items.AddRange(Projects.ToArray());
                Refresh();

                SaveAllJson();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private void TasksListBox_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (TasksListBox.SelectedIndex >= 0 && e.Button == MouseButtons.Left)
                    DoDragDrop(TasksListBox.SelectedItem, DragDropEffects.Move);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
    }
}
