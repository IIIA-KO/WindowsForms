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
    public partial class CategoryForm : Form
    {

        #region Constructor

        public CategoryForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// load all categories
        /// </summary>
        public void LoadCategoryList()
        {

            TaskManagerEntities sqlTaskMgr = new TaskManagerEntities();

            gvCategory.AutoGenerateColumns = false;
            gvCategory.DataSource = sqlTaskMgr.Category;

        }

        #endregion

        #region Private Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryID"></param>
        private void ShowAddCategoryForm(int categoryID)
        {
            TaskManagerMainForm parentForm = MdiParent as TaskManagerMainForm;

            if (parentForm != null)
            {
                parentForm.OpenAddNewCategoryForm(categoryID);
            }
        }

        #endregion

        #region Event

        private void CategoryForm_Shown(object sender, EventArgs e)
        {
            LoadCategoryList();
        }

        private void gvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = gvCategory.Columns[e.ColumnIndex];
                if (column.Name == "Edit")
                {

                    Category category = gvCategory.Rows[e.RowIndex].DataBoundItem as Category;
                    if (category != null)
                    {
                        ShowAddCategoryForm(category.CategoryID);
                    }
                }

            }

        }
        
        #endregion

    }
}
