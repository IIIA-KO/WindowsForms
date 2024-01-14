using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManager.Window7;
using TaskManager.Database;
using System.Data.Objects;
using TaskManager.Common;
using System.Diagnostics;
using TaskManager.Controls;

namespace TaskManager
{
    public partial class TaskManagerMainForm : Form
    {

        #region Data Members

        private ResourceForm _resourceForm = null;
        private TaskForm _taskForm = null;
        private TaskGanttChartForm _taskGanttChartForm = null;
        private CategoryForm _categoryForm = null;
        private AddTaskForm _addTaskForm = null;
        TaskThumbnail _taskThumbnail = null;


        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskManagerMainForm()
        {
            InitializeComponent();
        }

        #endregion
     
        #region Public Methods

        /// <summary>
        /// Open add new recource form
        /// </summary>
        public void OpenAddNewResourceForm()
        {
            OpenAddNewResourceForm(0);
        }

        /// <summary>
        /// open add new resource form
        /// </summary>
        /// <param name="resourceID">resource id</param>
        public void OpenAddNewResourceForm(int resourceID)
        {
            AddResourceForm frmAddResource = new AddResourceForm(resourceID);

            if (frmAddResource.ShowDialog() == DialogResult.OK)
            {
                RefreshResource();
            }
        }

        /// <summary>
        /// open add new task form
        /// </summary>
        public void OpenAddNewTaskForm()
        {
            OpenAddNewTaskForm(0);
        }

        /// <summary>
        /// open add new task form
        /// </summary>
        /// <param name="taskID">task id</param>
        public void OpenAddNewTaskForm(int taskID)
        {
            WindowState = FormWindowState.Maximized;

            if (_addTaskForm == null || _addTaskForm.IsDisposed)
            {
                _addTaskForm = new AddTaskForm(taskID);
            }
            else if (_addTaskForm.Visible)
            {
                
                Utility.ShowErrorMessage("Please Close opened task.", "Task Open");
                return;
            }


            TaskBar.ClearProgressValue();

            if (_addTaskForm.ShowDialog() == DialogResult.OK)
            {
                RefreshTask();
                CreateJumpList();
                CreateThumbnail();

            }


            _addTaskForm.Dispose();
            _addTaskForm = null;
        }

        /// <summary>
        /// open add new category form
        /// </summary>
        public void OpenAddNewCategoryForm()
        {
            OpenAddNewCategoryForm(0);
        }

        /// <summary>
        /// open add new category form
        /// </summary>
        /// <param name="categoryID">category id </param>
        public void OpenAddNewCategoryForm(int categoryID)
        {
            AddCategoryForm frmAddcategory = new AddCategoryForm(categoryID);

            if (frmAddcategory.ShowDialog() == DialogResult.OK)
            {
                RefreshCategory();
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// method to open child window form
        /// </summary>
        /// <param name="childForm">child form</param>
        private void OpenChildForm(Form childForm)
        {

            TaskBar.ClearProgressValue();
            childForm.MdiParent = this;            
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        /// <summary>
        /// open resource form
        /// </summary>
        private void OpenResourceForm()
        {

            if (_resourceForm == null || _resourceForm.IsDisposed)
            {
                _resourceForm = new ResourceForm();
            }

            OpenChildForm(_resourceForm);

        }

        /// <summary>
        /// open task form
        /// </summary>
        private void OpenTaskForm()
        {

            if (_taskForm == null || _taskForm.IsDisposed)
            {
                _taskForm = new TaskForm();
            }

            OpenChildForm(_taskForm);

        }

        /// <summary>
        /// open gantt chart form
        /// </summary>
        private void OpenTaskGnattChartForm()
        {

            if (_taskGanttChartForm == null || _taskGanttChartForm.IsDisposed)
            {
                _taskGanttChartForm = new TaskGanttChartForm();
            }

            OpenChildForm(_taskGanttChartForm);

        }
        
        /// <summary>
        /// open category form
        /// </summary>
        private void OpenCategoryForm()
        {

            if (_categoryForm == null || _categoryForm.IsDisposed)
            {
                _categoryForm = new CategoryForm();
            }

            OpenChildForm(_categoryForm);

        }

        /// <summary>
        /// refresh task
        /// </summary>
        private void RefreshTask()
        {
            if (_taskForm != null && !_taskForm.IsDisposed)
            {
                _taskForm.LoadTaskList();

            }
        }

        /// <summary>
        /// refresh resource
        /// </summary>
        private void RefreshResource()
        {
            if (_resourceForm != null && !_resourceForm.IsDisposed)
            {
                _resourceForm.LoadResourceList();

            }
          
        }

        /// <summary>
        /// refresh category
        /// </summary>
        private void RefreshCategory()
        {
            if (_categoryForm != null && !_categoryForm.IsDisposed)
            {
                _categoryForm.LoadCategoryList();

            }
        }
                
        /// <summary>
        /// open task setting
        /// </summary>
        private void OpenTaskSettingForm()
        {
            SettingForm frmSetting = new SettingForm();

            if (frmSetting.ShowDialog() == DialogResult.OK)
            {
                CreateJumpList();
            }
        }

        /// <summary>
        /// create jump list
        /// </summary>
        private void CreateJumpList()
        {
            TaskManagerEntities taskMgrEntity = new TaskManagerEntities();

            IQueryable<Task> tasks = null;

            switch (Utility.JumpListDisplayStyle)
            {
                case JumpListDisplayStyle.ColorCategory:
                    {
                        tasks = taskMgrEntity.Task.Where("it.ColorCategory != ''");
                        break;
                    }
                case JumpListDisplayStyle.Flag:
                    {

                        tasks = taskMgrEntity.Task.Where("it.Flag != ''");
                        break;
                    }

                case JumpListDisplayStyle.Priority:
                    {

                        tasks = taskMgrEntity.Task.Where("it.Priority != ''");
                        break;
                    }

            }





            TaskJumpList _list = new TaskJumpList();
            _list.ShowTaskList(tasks, Utility.JumpListDisplayStyle);
        }

        /// <summary>
        /// create tabbed thumbnail
        /// </summary>
        private void CreateThumbnail()
        {
            TaskManagerEntities ent = new TaskManagerEntities();
            List<Task> list = ent.Task.Where("it.Status != '" + TaskStatus.Completed + "'").ToList();

            if (_taskThumbnail == null)
            {
                _taskThumbnail = new TaskThumbnail(this, this.Handle, list);
            }
            else
            {
                _taskThumbnail.RefreshTaskThumbnail(list); 
            }


        }
        
        #endregion

        #region Event

        #region Form Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

            CreateJumpList();

            CreateThumbnail();

            OpenTaskForm();
        }

        [System.Diagnostics.DebuggerNonUserCode]   
        protected override void WndProc(ref Message m)
        {
             
            if (m.Msg == WindowMessageHelper.JumplistEvent)
            {
                int taskID = m.WParam.ToInt32();

                OpenAddNewTaskForm(taskID);
            }

            base.WndProc(ref m);

        }

        #endregion

        #region Tool Bar Events

        private void mnuToolAddNewResource_Click(object sender, EventArgs e)
        {
            OpenAddNewResourceForm();
        }

        private void mnuToolResource_Click(object sender, EventArgs e)
        {
            OpenResourceForm();
        }

        private void mnuToolAddNewTask_Click(object sender, EventArgs e)
        {
            OpenAddNewTaskForm();
        }

        private void mnuToolTaskList_Click(object sender, EventArgs e)
        {
            OpenTaskForm();
        }

        private void mnuToolAddNewCategory_Click(object sender, EventArgs e)
        {
            OpenAddNewCategoryForm();
        }
        
        private void mnuToolSetting_Click(object sender, EventArgs e)
        {
            OpenTaskSettingForm();
        }
        
        private void categoryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCategoryForm();
        }

        private void tsbViewResources_Click(object sender, EventArgs e)
        {
            OpenResourceForm();
        }

        private void tsbAddResource_Click(object sender, EventArgs e)
        {
            OpenAddNewResourceForm();
        }

        private void tsbAddNewTask_Click(object sender, EventArgs e)
        {
            OpenAddNewTaskForm();
        }

        private void tsbTask_Click(object sender, EventArgs e)
        {
            OpenTaskForm();
        }

        private void tsbViewCategory_Click(object sender, EventArgs e)
        {
            OpenCategoryForm();
        }

        private void tsbAddCategory_Click(object sender, EventArgs e)
        {
            OpenAddNewCategoryForm();
        }
        
        private void tsbSetting_Click(object sender, EventArgs e)
        {
            OpenTaskSettingForm();
        }


        private void tsmClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        private void tsmtaskGantt_Click(object sender, EventArgs e)
        {
            OpenTaskGnattChartForm();
        }
       
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenTaskGnattChartForm();
        }

        #endregion
        
    }
}
