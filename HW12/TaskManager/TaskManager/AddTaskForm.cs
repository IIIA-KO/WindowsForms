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
using System.Collections;

namespace TaskManager
{
    public partial class AddTaskForm : Form
    {

        #region Data Members

        TaskManagerEntities _taskMgrEntity = new TaskManagerEntities();
        private int _taskID = 0;
        List<Resource> _resourceList = null;

        #endregion

        #region Properties

        /// <summary>
        /// get/set resource list
        /// </summary>
        private List<Resource> ResourceList
        {
            get
            {
                if (_resourceList == null)
                {
                    _resourceList = new List<Resource>();
                }

                return _resourceList;
            }
            set
            {
                _resourceList = value;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// constructor
        /// </summary>
        public AddTaskForm()
            : this(0)
        {

        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="taskID">task id</param>
        public AddTaskForm(int taskID)
        {
            
            InitializeComponent();

            _taskID = taskID;
            btnDelete.Visible = (taskID > 0);

            // initialize Form
            InitForm();

            if (taskID > 0)
            {
                LoadTask();
            }
            else
            {

            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// get/set task id
        /// </summary>
        public int TaskID
        {
            get { return _taskID; }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// method to initialize form
        /// </summary>
        private void InitForm()
        {
            BindCategory();
            BindResource();
            Utility.BindTaskDurationTypeCombo(cmbDurationType, true);
            Utility.BindTaskPriorityCombo(cmbPriority, true);
            Utility.BindTaskStatusCombo(cmbStatus, true);
            Utility.BindTaskColorCategoryCombo(cmbColorCategory, true);
            Utility.BindTaskFlagCombo(cmbTaskFlag, true);

        }

        /// <summary>
        /// Bind category 
        /// </summary>
        private void BindCategory()
        {

            List<Category> cList = _taskMgrEntity.Category.ToList();

            Category nCat = new Category();

            nCat.Name = "";
            cList.Insert(0, nCat);

            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryID";

            cmbCategory.DataSource = cList;



        }

        /// <summary>
        /// Bind resource list
        /// </summary>
        private void BindResource()
        {
            ResourceList = _taskMgrEntity.Resource.ToList();
            //chkListResource.SelectionMode = SelectionMode.MultiSimple; 
            foreach (Resource res in ResourceList)
            {
                chkListResource.Items.Add(res.ResourceName);
            }

        }

        /// <summary>
        /// Method to validate form data
        /// </summary>
        /// <returns>true, if all data is valid</returns>
        private bool ValidateForm()
        {
            bool res = true;

            #region Validate name

            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                errorProvider1.SetError(txtTitle, "Please provide task title.");
                res = false;
            }
            else
            {
                errorProvider1.SetError(txtTitle, string.Empty);
            }

            #endregion


            return res;
        }

        /// <summary>
        /// method to load task
        /// </summary>
        public void LoadTask()
        {

            Task task = GetTask(TaskID);

            if (task != null)
            {

                txtDescription.PlainText = task.Description;

                if (task.DueDate.HasValue)
                {
                    dtpDueDate.Checked = true;
                    dtpDueDate.Value = task.DueDate.Value;
                }
                else
                {
                    dtpDueDate.Checked = false;
                    dtpDueDate.Text = string.Empty;
                }

                nudDuration.Value = task.Duration;
                cmbDurationType.Text = task.DurationType;
                dtpEndDate.Value = task.EndDate;
                nudPercentComplete.Value = task.PercentComplete;
                cmbPriority.Text = task.Priority;
                cmbTaskFlag.Text = task.Flag;
                cmbColorCategory.Text = task.ColorCategory;

                if (task.Category != null)
                {
                    cmbCategory.Text = task.Category.Name;
                }

                //task.ParentTaskID 
                //task.Resource.Add  

                dtpStartDate.Value = task.StartDate;
                cmbStatus.Text = task.Status;
                txtTitle.Text = task.Title;


                if (!task.Resource.IsLoaded)
                    task.Resource.Load();

                foreach (Resource resource in task.Resource)
                {
                    CheckGridResource(resource);
                }

            }

        }

        /// <summary>
        /// Check checklist of resources
        /// </summary>
        /// <param name="resource">resource</param>
        private void CheckGridResource(Resource resource)
        {

            int index = ResourceList.IndexOf(resource);
            if (index >= 0)
            {
                chkListResource.SetItemChecked(index, true);
                //chkListResource.SelectedItems.Add(chkListResource.Items[index]);
            }


            // gvResourceName.RefreshEdit();
        }

        /// <summary>
        /// save/update task
        /// </summary>
        private void SaveTask()
        {

            Task task = null;
            bool isNew = false;

            if (TaskID > 0)
            {

                task = GetTask(TaskID);
                if (!task.Resource.IsLoaded)
                    task.Resource.Load();
            }

            if (task == null)
            {
                task = new Database.Task();
                isNew = true;
            }



            task.Description = txtDescription.PlainText;
            if (dtpDueDate.Checked)
            {
                task.DueDate = GetDateTime(dtpDueDate.Value);
            }
            else
            {
                task.DueDate = null;
            }

            task.Duration = (int)nudDuration.Value;
            task.DurationType = cmbDurationType.Text;
            task.EndDate = GetDateTime(dtpEndDate.Value);
            task.PercentComplete = (int)nudPercentComplete.Value;
            task.Priority = cmbPriority.Text;
            task.ColorCategory = cmbColorCategory.Text;
            task.Flag = cmbTaskFlag.Text;

            Category category = null;
            if (cmbCategory.SelectedIndex > 0)
            {
                category = _taskMgrEntity.Category.Where("it.CategoryID=" + cmbCategory.SelectedValue).First();
            }
            task.Category = category;
            //task.ParentTaskID 
            //task.Resource.Add  

            task.StartDate = GetDateTime(dtpStartDate.Value);
            task.Status = cmbStatus.Text;
            task.Title = txtTitle.Text;


            // save resource
            SaveResource(task);

            if (isNew)
            {
                _taskMgrEntity.AddToTask(task);
            }

            _taskMgrEntity.SaveChanges();

        }

        /// <summary>
        /// save resource 
        /// </summary>
        /// <param name="task">task</param>
        private void SaveResource(Task task)
        {

            for (int i = 0; i < ResourceList.Count; i++)
            {

                Resource res = ResourceList[i];

                bool selected = chkListResource.CheckedIndices.Contains(i);

                Resource resource = GetResource(task, res.ResourceID);

                if (selected && resource == null)
                {
                    task.Resource.Add(res);
                }
                else if (!selected && resource != null)
                {
                    task.Resource.Remove(resource);
                }


            }


        }

        /// <summary>
        /// Fiond resource from task
        /// </summary>
        /// <param name="task">task</param>
        /// <param name="resourceID">resource id</param>
        /// <returns>resource</returns>
        private Resource GetResource(Task task, int resourceID)
        {
            List<Resource> rL = task.Resource.Where(x => x.ResourceID == resourceID).ToList();

            Resource res = null;
            if (rL.Count > 0)
            {
                res = rL[0];
            }
            return res;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="cmbTime"></param>
        /// <returns></returns>
        private DateTime GetDateTime(DateTime date)
        {

            date = Convert.ToDateTime(date.ToShortDateString());


            return date;
        }

        /// <summary>
        /// get task
        /// </summary>
        /// <param name="taskID">task id</param>
        /// <returns>task</returns>
        private Task GetTask(int taskID)
        {
            var matchs = from res in _taskMgrEntity.Task
                         where res.TaskID == taskID
                         select res;

            Task task = matchs.First();

            return task;
        }

        #endregion

        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                Utility.ShowErrorMessage("Please provide valid information.", "Error to save task.");
                return;
            }


            SaveTask();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gvResourceName_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool m = (e.Value == null) ? false : Convert.ToBoolean(e.Value.ToString());
                e.Value = m;
            }
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            //    cmbColorCategory.DrawMode = DrawMode.OwnerDrawVariable;

        }

        private void cmbColorCategory_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void cmbTaskFlag_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void cmbTaskFlag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = Utility.ShowConfirmationBox("Are you sure, you want to delete task.", "Confirmation");

            if (dlgResult == DialogResult.Yes)
            {
                Task task = GetTask(TaskID);

                if (task != null)
                {
                    _taskMgrEntity.DeleteObject(task);
                    _taskMgrEntity.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }



        }

        #endregion

    }
}
