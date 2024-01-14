namespace TaskManager
{
    partial class TaskForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.gvTasks = new System.Windows.Forms.DataGridView();
            this.Priority = new System.Windows.Forms.DataGridViewImageColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentComplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorCategory = new System.Windows.Forms.DataGridViewImageColumn();
            this.TaskFlags = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditTask = new System.Windows.Forms.DataGridViewImageColumn();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.taskViewer1 = new TaskManager.Controls.TaskViewer();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFlag = new System.Windows.Forms.Label();
            this.cmbFlag = new System.Windows.Forms.ComboBox();
            this.lblColorCategory = new System.Windows.Forms.Label();
            this.cmbColorCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvTasks)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvTasks
            // 
            this.gvTasks.AllowUserToAddRows = false;
            this.gvTasks.AllowUserToDeleteRows = false;
            this.gvTasks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gvTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTasks.BackgroundColor = System.Drawing.Color.White;
            this.gvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Priority,
            this.StartDate,
            this.EndDate,
            this.PercentComplete,
            this.Title,
            this.ColorCategory,
            this.TaskFlags,
            this.EditTask});
            this.gvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvTasks.GridColor = System.Drawing.Color.Black;
            this.gvTasks.Location = new System.Drawing.Point(0, 0);
            this.gvTasks.Name = "gvTasks";
            this.gvTasks.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.gvTasks.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTasks.Size = new System.Drawing.Size(603, 494);
            this.gvTasks.TabIndex = 0;
            this.gvTasks.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTasks_RowEnter);
            this.gvTasks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvTasks_CellFormatting);
            this.gvTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTasks_CellClick);
            // 
            // Priority
            // 
            this.Priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Priority.DataPropertyName = "Priority";
            this.Priority.FillWeight = 50.76142F;
            this.Priority.HeaderText = "!";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Priority.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Priority.Width = 18;
            // 
            // StartDate
            // 
            this.StartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.FillWeight = 116.4129F;
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 70;
            // 
            // EndDate
            // 
            this.EndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.FillWeight = 116.4129F;
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 70;
            // 
            // PercentComplete
            // 
            this.PercentComplete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PercentComplete.DataPropertyName = "PercentComplete";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = null;
            this.PercentComplete.DefaultCellStyle = dataGridViewCellStyle2;
            this.PercentComplete.FillWeight = 164.886F;
            this.PercentComplete.HeaderText = "%";
            this.PercentComplete.Name = "PercentComplete";
            this.PercentComplete.ReadOnly = true;
            this.PercentComplete.Width = 35;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 51.52687F;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // ColorCategory
            // 
            this.ColorCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColorCategory.DataPropertyName = "ColorCategory";
            this.ColorCategory.HeaderText = "";
            this.ColorCategory.Image = global::TaskManager.Properties.Resources.Add;
            this.ColorCategory.MinimumWidth = 18;
            this.ColorCategory.Name = "ColorCategory";
            this.ColorCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColorCategory.Width = 18;
            // 
            // TaskFlags
            // 
            this.TaskFlags.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TaskFlags.DataPropertyName = "Flag";
            this.TaskFlags.HeaderText = "";
            this.TaskFlags.MinimumWidth = 18;
            this.TaskFlags.Name = "TaskFlags";
            this.TaskFlags.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TaskFlags.Width = 18;
            // 
            // EditTask
            // 
            this.EditTask.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EditTask.HeaderText = "-";
            this.EditTask.Image = global::TaskManager.Properties.Resources.edit;
            this.EditTask.MinimumWidth = 20;
            this.EditTask.Name = "EditTask";
            this.EditTask.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditTask.ToolTipText = "Edit task";
            this.EditTask.Width = 20;
            // 
            // scMain
            // 
            this.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 38);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.gvTasks);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.taskViewer1);
            this.scMain.Size = new System.Drawing.Size(1011, 496);
            this.scMain.SplitterDistance = 605;
            this.scMain.TabIndex = 1;
            // 
            // taskViewer1
            // 
            this.taskViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskViewer1.Location = new System.Drawing.Point(0, 0);
            this.taskViewer1.Name = "taskViewer1";
            this.taskViewer1.Size = new System.Drawing.Size(400, 494);
            this.taskViewer1.TabIndex = 0;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::TaskManager.Properties.Resources.edit;
            this.dataGridViewImageColumn1.MinimumWidth = 20;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.ToolTipText = "Edit task";
            this.dataGridViewImageColumn1.Width = 257;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFlag);
            this.panel1.Controls.Add(this.cmbFlag);
            this.panel1.Controls.Add(this.lblColorCategory);
            this.panel1.Controls.Add(this.cmbColorCategory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.lblPriority);
            this.panel1.Controls.Add(this.cmbPriority);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 38);
            this.panel1.TabIndex = 0;
            // 
            // lblFlag
            // 
            this.lblFlag.AutoSize = true;
            this.lblFlag.Location = new System.Drawing.Point(797, 12);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(27, 13);
            this.lblFlag.TabIndex = 8;
            this.lblFlag.Text = "F&lag";
            // 
            // cmbFlag
            // 
            this.cmbFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlag.FormattingEnabled = true;
            this.cmbFlag.Location = new System.Drawing.Point(832, 9);
            this.cmbFlag.Name = "cmbFlag";
            this.cmbFlag.Size = new System.Drawing.Size(121, 21);
            this.cmbFlag.TabIndex = 9;
            this.cmbFlag.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
            // 
            // lblColorCategory
            // 
            this.lblColorCategory.AutoSize = true;
            this.lblColorCategory.Location = new System.Drawing.Point(580, 11);
            this.lblColorCategory.Name = "lblColorCategory";
            this.lblColorCategory.Size = new System.Drawing.Size(76, 13);
            this.lblColorCategory.TabIndex = 6;
            this.lblColorCategory.Text = "Co&lor Category";
            // 
            // cmbColorCategory
            // 
            this.cmbColorCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorCategory.FormattingEnabled = true;
            this.cmbColorCategory.Location = new System.Drawing.Point(661, 8);
            this.cmbColorCategory.Name = "cmbColorCategory";
            this.cmbColorCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbColorCategory.TabIndex = 7;
            this.cmbColorCategory.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(252, 9);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(58, 8);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(395, 12);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(38, 13);
            this.lblPriority.TabIndex = 4;
            this.lblPriority.Text = "&Priority";
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(439, 8);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 21);
            this.cmbPriority.TabIndex = 5;
            this.cmbPriority.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 534);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskForm";
            this.Text = "Task Details";
            this.Shown += new System.EventHandler(this.TaskForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gvTasks)).EndInit();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTasks;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        public TaskManager.Controls.TaskViewer taskViewer1;
        private System.Windows.Forms.DataGridViewImageColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewImageColumn ColorCategory;
        private System.Windows.Forms.DataGridViewImageColumn TaskFlags;
        private System.Windows.Forms.DataGridViewImageColumn EditTask;
        private System.Windows.Forms.Label lblColorCategory;
        private System.Windows.Forms.ComboBox cmbColorCategory;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.ComboBox cmbFlag;
    }
}