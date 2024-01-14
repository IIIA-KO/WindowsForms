using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManager.Database;

namespace TaskManager.Controls
{
    public partial class TaskViewer : UserControl
    {

        #region Constructor

        /// <summary>
        /// Cosntructor
        /// </summary>
        public TaskViewer()
        {
            InitializeComponent();

            if (this.DesignMode)
            {
                ClearTaskData();
            }
        }
        
        #endregion

        #region Properties

        /// <summary>
        /// get control image
        /// </summary>
        public Bitmap Image
        {

            get
            {

                Bitmap b = new Bitmap(this.Width, this.Height);
                Rectangle newRect = new Rectangle(

                  2,
                  2,
                  this.Width,
                  this.Height);


                this.DrawToBitmap(b, newRect);


                return b;
            }
        }
        
        #endregion

        #region Public Methods

        /// <summary>
        /// load task detail
        /// </summary>
        /// <param name="task">task</param>
        public void SetTaskDetail(Task task)
        {
            if (task == null)
            {
                ClearTaskData();
                return;
            }

            lblTitle.Text = task.Title;
            textEditor1.PlainText = task.Description;

            lblStartDate.Text = task.StartDate.ToShortDateString();
            lblEndDate.Text = task.EndDate.ToShortDateString();
            lblDuration.Text = task.Duration.ToString() + " " + task.DurationType;
            lblPercentComplete.Text = task.PercentComplete + "%";
            lblStatus.Text = task.Status;
            lblPriority.Text = task.Priority;


            lblDueDate.Text = (task.DueDate.HasValue) ? task.DueDate.Value.ToShortDateString() : string.Empty;
            lblCategory.Text = (task.Category != null) ? task.Category.Name : string.Empty;

            lblResources.Text = GetResourceList(task);


        }
        
        #endregion

        #region Private Methods

        /// <summary>
        /// Get comma separate list for resources
        /// </summary>
        /// <param name="task">task</param>
        /// <returns>CSV of resource name</returns>
        private string GetResourceList(Task task)
        {

            string strToReturn = string.Empty;
            if (!task.Resource.IsLoaded)
            {
                task.Resource.Load();
            }

            string[] resNames = new string[task.Resource.Count];

            int i = 0;
            foreach (Resource res in task.Resource)
                resNames[i++] = res.ResourceName;


            return string.Join(", ", resNames);
        }

        /// <summary>
        /// set empty value in control
        /// </summary>
        private void ClearTaskData()
        {
            lblTitle.Text = string.Empty;
            textEditor1.PlainText = string.Empty;


            lblStartDate.Text = string.Empty;
            lblEndDate.Text = string.Empty;
            lblDuration.Text = string.Empty;
            lblPercentComplete.Text = string.Empty;
            lblStatus.Text = string.Empty;
            lblPriority.Text = string.Empty;
            lblResources.Text = string.Empty;

            lblDueDate.Text = string.Empty;
            lblCategory.Text = string.Empty;

        } 

        #endregion

    }
}
