namespace TaskManager
{
    partial class TaskGanttChartForm
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
            this.ganttViewer1 = new TaskManager.Controls.GanttViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(972, 38);
            this.panel1.TabIndex = 1;
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
            // ganttViewer1
            // 
            this.ganttViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ganttViewer1.Location = new System.Drawing.Point(0, 38);
            this.ganttViewer1.Name = "ganttViewer1";
            this.ganttViewer1.Size = new System.Drawing.Size(972, 442);
            this.ganttViewer1.TabIndex = 0;
            this.ganttViewer1.OnTaskOpenEvent += new TaskManager.Controls.GanttViewer.OnTaskOpenDelegate(this.ganttViewer1_OnTaskOpenEvent);
            // 
            // TaskGanttChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 480);
            this.Controls.Add(this.ganttViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "TaskGanttChartForm";
            this.Text = "Gantt";
            this.Load += new System.EventHandler(this.TaskGanttChartForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TaskManager.Controls.GanttViewer ganttViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.ComboBox cmbFlag;
        private System.Windows.Forms.Label lblColorCategory;
        private System.Windows.Forms.ComboBox cmbColorCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;

    }
}