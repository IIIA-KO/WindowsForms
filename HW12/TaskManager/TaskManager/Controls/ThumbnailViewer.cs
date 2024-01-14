using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManager.Database;
using TaskManager.Common;

namespace TaskManager.Controls
{
    public partial class ThumbnailViewer : UserControl
    {

        #region Properties

        /// <summary>
        /// get image of control
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

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public ThumbnailViewer()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Method to load data from task
        /// </summary>
        /// <param name="task">task</param>
        public void LoadTaskData(Task task)
        {

            if (task != null)
            {
                PopulateTaskDetail(task);
            }
            else
            {
                ClearData(); 
            }

        }
             
        #endregion

        #region Private Methods

        /// <summary>
        /// populate task data
        /// </summary>
        /// <param name="task">task</param>
        private void PopulateTaskDetail(Task task)
        {
            lblTitle.Text = task.Title;
            lblDescription.Text = task.Description;

            if (task.Priority.Length > 0)
            {
                TaskPriority priority = (TaskPriority)Enum.Parse(typeof(TaskPriority), task.Priority);
                pbPriority.Image = Utility.GetTaskPriorityImage(priority);
            }
            else
            {
                pbPriority.Image = Properties.Resources.Empty;
            }


            if (task.Flag.Length > 0)
            {
                TaskFlag flag = (TaskFlag)Enum.Parse(typeof(TaskFlag), task.Flag);
                pbFlag.Image = Utility.GetTaskFalgImage(flag);
            }
            else
            {
                pbFlag.Image = Properties.Resources.Empty;
            }

            if (task.ColorCategory.Length > 0)
            {
                TaskCategory category = (TaskCategory)Enum.Parse(typeof(TaskCategory), task.ColorCategory);
                pbColor.Image = Utility.GetCategoryImage(category);
            }
            else
            {
                pbColor.Image = Properties.Resources.Empty;
            }
        }

        /// <summary>
        /// Set empty data in controls
        /// </summary>
        private void ClearData()
        {
            lblTitle.Text = string.Empty;
            lblDescription.Text = string.Empty;

            pbPriority.Image = Properties.Resources.Empty;

            pbFlag.Image = Properties.Resources.Empty;
            pbColor.Image = Properties.Resources.Empty;
            
            
        }
        
        #endregion

    }
}
