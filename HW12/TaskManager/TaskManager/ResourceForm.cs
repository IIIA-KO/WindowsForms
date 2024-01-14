using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManager.Database;

namespace TaskManager
{
    public partial class ResourceForm : Form
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public ResourceForm()
        {
            InitializeComponent();
        }

        #endregion
        
        #region Public Methods

        /// <summary>
        /// Load all resource list
        /// </summary>
        public void LoadResourceList()
        {
            TaskManagerEntities sqlTaskMgr = new TaskManagerEntities();

            gvResources.AutoGenerateColumns = false;
            gvResources.DataSource = sqlTaskMgr.Resource;


        }

        #endregion

        #region Private Methods

        /// <summary>
        /// show add/edit resource form
        /// </summary>
        /// <param name="resourceID">resource id</param>
        private void ShowAddResourceForm(int resourceID)
        {
            TaskManagerMainForm parentForm = MdiParent as TaskManagerMainForm;

            if (parentForm != null)
            {
                parentForm.OpenAddNewResourceForm(resourceID);
            }
        }

        #endregion

        #region Events

        private void ResourceForm_Load(object sender, EventArgs e)
        {

        }

        private void ResourceForm_Shown(object sender, EventArgs e)
        {
            LoadResourceList();
        }

        private void gvResources_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = gvResources.Columns[e.ColumnIndex];
                if (column.Name == "Edit")
                {

                    Resource resource = gvResources.Rows[e.RowIndex].DataBoundItem as Resource;
                    if (resource != null)
                    {
                        ShowAddResourceForm(resource.ResourceID);
                    }
                }

            }

        }

        #endregion

    }
}
