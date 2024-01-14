using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManager.Common;
using TaskManager.Database;
using System.Diagnostics;
using TaskManager.Window7;

namespace TaskManager
{
    public partial class TaskForm : Form
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Load Task List
        /// </summary>
        public void LoadTaskList()
        {
            TaskManagerEntities taskMgrEntity = new TaskManagerEntities();
            string whereClause = GetWhereClause();

            gvTasks.AutoGenerateColumns = false;

            if (string.IsNullOrEmpty(whereClause))
            {
                gvTasks.DataSource = taskMgrEntity.Task.Include("Category");
            }
            else
            {
                gvTasks.DataSource =  taskMgrEntity.Task.Include("Category").Include("Resource").Where(whereClause);
            }

            /// FORMAT GRID ROW
            FormatGridRow();

            if (gvTasks.Rows.Count > 0)
            {
                gvTasks.Rows[0].Selected = true;
                LoadSelectedTaskDetail();
            }

        }

        /// <summary>
        /// format grid row
        /// </summary>
        private void FormatGridRow()
        {

            foreach (DataGridViewRow gridRow in gvTasks.Rows)
            {
                Task task = gridRow.DataBoundItem as Task;

                String stringValue = task.Status;
                if (!string.IsNullOrEmpty(stringValue))
                {
                    TaskStatus status = (TaskStatus)Enum.Parse(typeof(TaskStatus), stringValue);

                    if (status == TaskStatus.Completed)
                    {

                        gridRow.DefaultCellStyle.Font  = new Font(gvTasks.RowsDefaultCellStyle.Font, FontStyle.Strikeout);
                        gridRow.DefaultCellStyle.ForeColor = Color.LightGray;

                    }
                    else
                    {
                        //   gridRow.DefaultCellStyle.Font = new Font(gvTasks.RowsDefaultCellStyle.Font, FontStyle.Regular);
                    }
                }
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// get where clause
        /// </summary>
        /// <returns>where clause</returns>
        private string GetWhereClause()
        {

            string whereClause = "";

            if (cmbPriority.SelectedIndex > 0)
            {
                whereClause = ConcatWhereClause(whereClause, "it.Priority = '" + cmbPriority.Text + "'", string.Empty);
            }



            if (cmbStatus.SelectedIndex > 0)
            {
                whereClause = ConcatWhereClause(whereClause, "it.Status = '" + cmbStatus.Text + "'", "AND");
            }

            if (cmbCategory.SelectedIndex > 0)
            {
                whereClause = ConcatWhereClause(whereClause, "it.Category.CategoryID = " + cmbCategory.SelectedValue.ToString(), "AND");
            }

            if (cmbColorCategory.SelectedIndex > 0)
            {
                whereClause = ConcatWhereClause(whereClause, "it.ColorCategory = '" + cmbColorCategory.Text + "'",  "AND");
            }

            if (cmbFlag.SelectedIndex > 0)
            {
                whereClause = ConcatWhereClause(whereClause, "it.Flag = '" + cmbFlag.Text + "'", "AND");
            }


            return whereClause;

        }

        /// <summary>
        /// concat where clause
        /// </summary>
        /// <param name="whereClasue">where clause</param>
        /// <param name="newClause">new clause</param>
        /// <param name="operators">operator</param>
        /// <returns>concated where clause</returns>
        private string ConcatWhereClause(string whereClasue, string newClause, string operators)
        {
            if (whereClasue.Length > 0)
            {
                return whereClasue + " " + operators + " " + newClause;
            }
            else
            {
                return newClause;
            }
        }

        /// <summary>
        /// Bind drop downs
        /// </summary>
        private void BindDropDowns()
        {
            Utility.BindTaskPriorityCombo(cmbPriority, true);
            Utility.BindTaskStatusCombo(cmbStatus, true);
            Utility.BindTaskColorCategoryCombo(cmbColorCategory, true);
            Utility.BindTaskFlagCombo(cmbFlag, true);  

            BindCategoryDropDown();
        }

        /// <summary>
        /// bind category drop down
        /// </summary>
        private void BindCategoryDropDown()
        {
            TaskManagerEntities taskMgrEntity = new TaskManagerEntities();
            List<Category> categoryList = taskMgrEntity.Category.ToList();

            Category newCategory = new Category();
            categoryList.Insert(0, newCategory);

            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = categoryList;

        }

        /// <summary>
        /// Show add task form
        /// </summary>
        /// <param name="taskID">task id</param>
        private void ShowAddTaskForm(int taskID)
        {
            TaskManagerMainForm parentForm = MdiParent as TaskManagerMainForm;

            if (parentForm != null)
            {
                parentForm.OpenAddNewTaskForm(taskID);
            }
        }

        /// <summary>
        /// load selected task detail
        /// </summary>
        private void LoadSelectedTaskDetail()
        {
            if (gvTasks.SelectedRows != null && gvTasks.SelectedRows.Count > 0)
            {
                Task task = gvTasks.SelectedRows[0].DataBoundItem as Task;

                taskViewer1.SetTaskDetail(task);

               
                TaskBar.SetProgressValue(task.PercentComplete); 
            }
                else
                {
                    TaskBar.ClearProgressValue(); 
                }
        }
           
        /// <summary>
        /// format priority cell format
        /// </summary>
        /// <param name="e">event args</param>
        private void FormatPriorityCell(DataGridViewCellFormattingEventArgs e)
        {
            // Ensure that the value is a string.
            String stringValue = e.Value as string;
            if (stringValue == null) return;


            // Set the cell ToolTip to the text value.
            DataGridViewCell cell = gvTasks[e.ColumnIndex, e.RowIndex];



            cell.ToolTipText = stringValue;


            // Replace the string value with the image value.
            switch (stringValue.ToLower())
            {
                case "high":
                    e.Value = Properties.Resources.High_Priority;
                    break;

                case "low":
                    e.Value = Properties.Resources.Low_Priority;
                    break;
                case "medium":
                    e.Value = Properties.Resources.Medium_Priority;
                    break;

                default:
                    e.Value = Properties.Resources.Empty;
                    break;
            }

        }

        /// <summary>
        /// format color cell format
        /// </summary>
        /// <param name="e">event args</param>
        private void FormatColorCell(DataGridViewCellFormattingEventArgs e)
        {
            // Ensure that the value is a string.
            String stringValue = e.Value as string;
            if (stringValue == null) return;


            // Set the cell ToolTip to the text value.
            DataGridViewCell cell = gvTasks[e.ColumnIndex, e.RowIndex];



            cell.ToolTipText = stringValue;

            if (!string.IsNullOrEmpty(stringValue))
            {
                TaskCategory category = (TaskCategory)Enum.Parse(typeof(TaskCategory), stringValue);

                // Replace the string value with the image value.
                switch (category)
                {
                    case TaskCategory.Blue:
                        e.Value = Properties.Resources.BlueCat;
                        break;

                    case TaskCategory.Green:
                        e.Value = Properties.Resources.GreenCat;
                        break;

                    case TaskCategory.Orange:
                        e.Value = Properties.Resources.OrangeCat;
                        break;
                    case TaskCategory.Purple:
                        e.Value = Properties.Resources.PurpleCat;
                        break;
                    case TaskCategory.Red:
                        e.Value = Properties.Resources.RedCat;
                        break;
                    case TaskCategory.Yellow:
                        e.Value = Properties.Resources.YellowCat;
                        break;

                    default:
                        e.Value = Properties.Resources.Empty;
                        break;
                }
            }
            else
            {
                e.Value = Properties.Resources.Empty;
            }

        }

        /// <summary>
        /// format flag cell format
        /// </summary>
        /// <param name="e">event args</param>
        private void FormatFlagCell(DataGridViewCellFormattingEventArgs e)
        {
            // Ensure that the value is a string.
            String stringValue = e.Value as string;
            if (stringValue == null) return;


            // Set the cell ToolTip to the text value.
            DataGridViewCell cell = gvTasks[e.ColumnIndex, e.RowIndex];



            cell.ToolTipText = stringValue;

            if (!string.IsNullOrEmpty(stringValue))
            {
                TaskFlag flag = (TaskFlag)Enum.Parse(typeof(TaskFlag), stringValue);

                // Replace the string value with the image value.
                e.Value = Utility.GetTaskFalgImage(flag);
            }
            else
            {
                e.Value = Properties.Resources.Empty;
            }

        }

        #endregion

        #region Events

        private void TaskForm_Shown(object sender, EventArgs e)
        {
            BindDropDowns();
            LoadTaskList();
        }
           
        private void gvTasks_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            LoadSelectedTaskDetail();


        }

        private void gvTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = gvTasks.Columns[e.ColumnIndex];

            if (column.Name.Equals("Priority"))
            {
                FormatPriorityCell(e);
            }
            else if (column.Name.Equals("ColorCategory"))
            {
                FormatColorCell(e);
            }
            else if (column.Name.Equals("TaskFlags"))
            {
                FormatFlagCell(e);
            }
            


        }

        private void gvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = gvTasks.Columns[e.ColumnIndex];
                if (column.Name == "EditTask")
                {

                    Task task = gvTasks.Rows[e.RowIndex].DataBoundItem as Task;
                    if (task != null)
                    {
                        ShowAddTaskForm(task.TaskID);
                    }
                }

            }
        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTaskList();
        }

        #endregion

    }
}
