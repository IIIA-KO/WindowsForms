using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using TaskManager.Database;
using TaskManager.Common;

namespace TaskManager
{
    public partial class AddResourceForm : Form
    {

        #region Data members

        TaskManagerEntities _taskMgrEntity = new TaskManagerEntities();
        private int _resourceID = 0;

        #endregion

        #region Properties

        /// <summary>
        /// get resource id
        /// </summary>
        public int ResourceID
        {
            get { return _resourceID; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// constructor
        /// </summary>
        public AddResourceForm()
            : this(0)
        {

        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="resourceID">resource id</param>
        public AddResourceForm(int resourceID)
        {
            InitializeComponent();

            _resourceID = resourceID;
            btnDelete.Visible = (resourceID > 0);
            if (resourceID > 0)
                LoadResource();
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
                errorProvider1.SetError(txtName, "Please provide resource name.");
                res = false;
            }
            else
            {
                errorProvider1.SetError(txtName, string.Empty);
            }

            #endregion

            #region Email Address

            if (!string.IsNullOrEmpty(txtEmailAddress.Text.Trim()))
            {

                string exp = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

                if (!Regex.IsMatch(txtEmailAddress.Text, exp))
                {
                    errorProvider1.SetError(txtEmailAddress, "Please provide valid email address.");
                    res = false;
                }
                else
                {
                    errorProvider1.SetError(txtEmailAddress, string.Empty);
                }

            }
            else
            {
                errorProvider1.SetError(txtEmailAddress, string.Empty);
            }

            #endregion

            return res;
        }

        /// <summary>
        /// method to load resource
        /// </summary>
        private void LoadResource()
        {

            Resource resource = GetResource(ResourceID);

            if (resource != null)
            {
                txtName.Text = resource.ResourceName;
                txtCode.Text = resource.ResourceCode;
                txtEmailAddress.Text = resource.EmailAddress;
                textEditor1.PlainText = resource.ResourceDetail;
            }

        }

        /// <summary>
        /// save/update resource
        /// </summary>
        private void SaveResource()
        {

            Resource resource = null;
            bool isNew = false;

            if (ResourceID > 0)
            {
                resource = GetResource(ResourceID);
            }

            if (resource == null)
            {
                resource = new Database.Resource();
                isNew = true;
            }

            resource.ResourceName = txtName.Text.Trim();
            resource.EmailAddress = txtEmailAddress.Text.Trim();
            resource.ResourceCode = txtCode.Text.Trim();
            resource.ResourceDetail = textEditor1.PlainText;

            if (isNew)
            {
                _taskMgrEntity.AddToResource(resource);

            }

            _taskMgrEntity.SaveChanges();

        }

        /// <summary>
        /// get resource
        /// </summary>
        /// <param name="resourceID">resource id</param>
        /// <returns>resource</returns>
        private Resource GetResource(int resourceID)
        {
            var matchs = from res in _taskMgrEntity.Resource
                         where res.ResourceID == resourceID
                         select res;

            Resource resource = matchs.First();

            return resource;
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


            SaveResource();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dlgResult = Utility.ShowConfirmationBox("Are you sure, you want to delete resource.", "Confirmation");

            if (dlgResult == DialogResult.Yes)
            {
                Resource resource = GetResource(ResourceID);

                if (resource != null)
                {
                    _taskMgrEntity.DeleteObject(resource);
                    _taskMgrEntity.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }


        }

        #endregion

    }
}
