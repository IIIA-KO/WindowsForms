using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManager.Database;
using System.Data.Objects;
using TaskManager.Common;

namespace TaskManager
{
    public partial class TaskGanttChartForm : Form
    {

        #region Constructor

        /// <summary>
        /// constructor
        /// </summary>
        public TaskGanttChartForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Load Task List
        /// </summary>
        public void LoadTaskList()
        {
            TaskManagerEntities taskMgrEntity = new TaskManagerEntities();
            string whereClause = GetWhereClause();

            ObjectQuery<Task> tasks = null; 

          
            if (string.IsNullOrEmpty(whereClause))
            {
               tasks = taskMgrEntity.Task.Include("Category");
            }
            else
            {
                tasks = taskMgrEntity.Task.Include("Category").Include("Resource").Where(whereClause);
            }


            List<Task> taskList = new List<Task>();

            if (tasks != null)
                taskList = tasks.ToList();


            ganttViewer1.LoadTasks(taskList); 
        }

        /// <summary>
        /// show add task form
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
                whereClause = ConcatWhereClause(whereClause, "it.ColorCategory = '" + cmbColorCategory.Text + "'", "AND");
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
        
        #endregion

        #region Events

        private void TaskGanttChartForm_Load(object sender, EventArgs e)
        {
            BindDropDowns();
            LoadTaskList();
        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTaskList();
        }
        
        private void ganttViewer1_OnTaskOpenEvent(object sender, TaskManager.Common.OpenTaskEventArgs e)
        {
            ShowAddTaskForm(e.TaskID);
        }

        #endregion

    }
}
