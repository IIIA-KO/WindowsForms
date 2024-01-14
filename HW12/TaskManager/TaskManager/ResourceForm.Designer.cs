namespace TaskManager
{
    partial class ResourceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceForm));
            this.gvResources = new System.Windows.Forms.DataGridView();
            this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvResources)).BeginInit();
            this.SuspendLayout();
            // 
            // gvResources
            // 
            this.gvResources.AllowUserToAddRows = false;
            this.gvResources.AllowUserToDeleteRows = false;
            this.gvResources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvResources.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResourceName,
            this.EmailAddress,
            this.ResourceCode,
            this.Edit});
            this.gvResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvResources.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvResources.Location = new System.Drawing.Point(0, 0);
            this.gvResources.Name = "gvResources";
            this.gvResources.ReadOnly = true;
            this.gvResources.RowHeadersVisible = false;
            this.gvResources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResources.Size = new System.Drawing.Size(720, 417);
            this.gvResources.TabIndex = 0;
            this.gvResources.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResources_CellClick);
            // 
            // ResourceName
            // 
            this.ResourceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ResourceName.DataPropertyName = "ResourceName";
            this.ResourceName.FillWeight = 30F;
            this.ResourceName.HeaderText = "Name";
            this.ResourceName.Name = "ResourceName";
            this.ResourceName.ReadOnly = true;
            // 
            // EmailAddress
            // 
            this.EmailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.FillWeight = 30F;
            this.EmailAddress.HeaderText = "Email";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            // 
            // ResourceCode
            // 
            this.ResourceCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ResourceCode.DataPropertyName = "ResourceCode";
            this.ResourceCode.FillWeight = 40F;
            this.ResourceCode.HeaderText = "Code";
            this.ResourceCode.Name = "ResourceCode";
            this.ResourceCode.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Edit.FillWeight = 50.76142F;
            this.Edit.HeaderText = "-";
            this.Edit.Image = global::TaskManager.Properties.Resources.edit;
            this.Edit.MinimumWidth = 25;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Width = 25;
            // 
            // ResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 417);
            this.Controls.Add(this.gvResources);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResourceForm";
            this.Text = "Manage Resources";
            this.Load += new System.EventHandler(this.ResourceForm_Load);
            this.Shown += new System.EventHandler(this.ResourceForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gvResources)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvResources;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceCode;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}