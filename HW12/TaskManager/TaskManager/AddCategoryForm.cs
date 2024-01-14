using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManager.Database;
using TaskManager.Common;

namespace TaskManager
{
    public partial class AddCategoryForm : Form
    {
       
        #region Data members

        private int _categoryID = 0;
 TaskManagerEntities _taskMgrEntity = new TaskManagerEntities();

        #endregion

        #region Properties

        /// <summary>
        /// get category id
        /// </summary>
        public int CategoryID
        {
            get { return _categoryID; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
         public AddCategoryForm()
            : this(0)
        {

        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="categoryID">category id</param>
         public AddCategoryForm(int categoryID)
        {
            InitializeComponent();

            _categoryID = categoryID;
            btnDelete.Visible = (categoryID > 0);


            if (categoryID > 0)
                LoadCategory();
        }


        #endregion
        
        #region Private Methods

        /// <summary>
        /// Method to validate form data
        /// </summary>
        /// <returns>true, if all data is valid</returns>
        private bool ValidateForm()
        {
            bool res = true;
            #region Validate name

            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "Please provide category name.");
                res = false;
            }
            else
            {
                errorProvider1.SetError(txtName, string.Empty);
            }

            #endregion



            return res;
        }

        /// <summary>
        /// method to load category
        /// </summary>
        private void LoadCategory()
        {

            Category category = GetCategory(CategoryID);

            if (category != null)
            {
                txtName.Text = category.Name;
                txtDesciption.PlainText = category.Description;
                
            }

        }

        /// <summary>
        /// save/update category
        /// </summary>
        private void SaveCategory()
        {

            Category  category = null;
            bool isNew = false;

            if (CategoryID  > 0)
            {
                category = GetCategory(CategoryID);
            }

            if (category == null)
            {
                category = new Category();
                isNew = true;
            }

            category.Name = txtName.Text.Trim();
            category.Description = txtDesciption.PlainText;
            

            if (isNew)
            {
                _taskMgrEntity.AddToCategory(category);

            }

            _taskMgrEntity.SaveChanges();

        }

        /// <summary>
        /// get category by id
        /// </summary>
        /// <param name="categoryID">category id</param>
        /// <returns>category</returns>
        private Category GetCategory(int categoryID)
        {
            var matchs = from res in _taskMgrEntity.Category
                         where res.CategoryID == categoryID
                         select res;

            Category category = matchs.First();

            return category;
        }

        #endregion
        
        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {

                Utility.ShowErrorMessage("Please provide valid information.", "Error to save resource.");
                return;
            }


            SaveCategory();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = Utility.ShowConfirmationBox("Are you sure, you want to delete category.", "Confirmation");

            if (dlgResult == DialogResult.Yes)
            {
                Category  category = GetCategory(CategoryID);

                if (category != null)
                {
                    _taskMgrEntity.DeleteObject(category);
                    _taskMgrEntity.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }

        }

        #endregion

    }
}
