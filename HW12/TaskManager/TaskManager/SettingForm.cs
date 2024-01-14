using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManager.Common;

namespace TaskManager
{
    public partial class SettingForm : Form
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public SettingForm()
        {
            InitializeComponent();
        }
        
        #endregion

        #region Private Methods

        /// <summary>
        /// Bind jump list type drop down
        /// </summary>
        private void BindJumpListSettingDropDown()
        {
            string[] values = (string[])Enum.GetNames(typeof(JumpListDisplayStyle));

            cmbDisplalStyle.Items.Clear();
            foreach (string str in values)
                cmbDisplalStyle.Items.Add(str);


            cmbDisplalStyle.Text = Utility.JumpListDisplayStyle.ToString();
        }
        
        #endregion

        #region Events

        private void SettingForm_Load(object sender, EventArgs e)
        {
            BindJumpListSettingDropDown();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowTaskListBy = cmbDisplalStyle.Text;
            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
        #endregion

    }
}
