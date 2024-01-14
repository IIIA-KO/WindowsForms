namespace TaskManager.Controls
{
    partial class GanttViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gvTitle = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskPriority = new System.Windows.Forms.DataGridViewImageColumn();
            this.TaskColorCategory = new System.Windows.Forms.DataGridViewImageColumn();
            this.TaskFlag = new System.Windows.Forms.DataGridViewImageColumn();
            this.gvGantt = new TaskManager.Controls.GanttChart();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGantt)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gvTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gvGantt);
            this.splitContainer1.Size = new System.Drawing.Size(600, 505);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // gvTitle
            // 
            this.gvTitle.AllowUserToAddRows = false;
            this.gvTitle.AllowUserToDeleteRows = false;
            this.gvTitle.AllowUserToResizeColumns = false;
            this.gvTitle.AllowUserToResizeRows = false;
            this.gvTitle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTitle.BackgroundColor = System.Drawing.Color.White;
            this.gvTitle.ColumnHeadersHeight = 50;
            this.gvTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvTitle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.TaskPriority,
            this.TaskColorCategory,
            this.TaskFlag});
            this.gvTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTitle.GridColor = System.Drawing.Color.Black;
            this.gvTitle.Location = new System.Drawing.Point(0, 0);
            this.gvTitle.MultiSelect = false;
            this.gvTitle.Name = "gvTitle";
            this.gvTitle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvTitle.RowHeadersVisible = false;
            this.gvTitle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTitle.Size = new System.Drawing.Size(200, 505);
            this.gvTitle.TabIndex = 0;
            this.gvTitle.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gvTitle_Scroll);
            this.gvTitle.DoubleClick += new System.EventHandler(this.gvTitle_DoubleClick);
            this.gvTitle.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvTitle_CellFormatting);
            this.gvTitle.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gvTitle_CellPainting);
            // 
            // Task
            // 
            this.Task.DataPropertyName = "Title";
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            // 
            // TaskPriority
            // 
            this.TaskPriority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TaskPriority.DataPropertyName = "Priority";
            this.TaskPriority.HeaderText = "!";
            this.TaskPriority.MinimumWidth = 20;
            this.TaskPriority.Name = "TaskPriority";
            this.TaskPriority.Width = 20;
            // 
            // TaskColorCategory
            // 
            this.TaskColorCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TaskColorCategory.DataPropertyName = "ColorCategory";
            this.TaskColorCategory.HeaderText = "";
            this.TaskColorCategory.MinimumWidth = 20;
            this.TaskColorCategory.Name = "TaskColorCategory";
            this.TaskColorCategory.Width = 20;
            // 
            // TaskFlag
            // 
            this.TaskFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TaskFlag.DataPropertyName = "Flag";
            this.TaskFlag.HeaderText = "";
            this.TaskFlag.MinimumWidth = 20;
            this.TaskFlag.Name = "TaskFlag";
            this.TaskFlag.Width = 20;
            // 
            // gvGantt
            // 
            this.gvGantt.AllowUserToAddRows = false;
            this.gvGantt.AllowUserToDeleteRows = false;
            this.gvGantt.AllowUserToResizeColumns = false;
            this.gvGantt.AllowUserToResizeRows = false;
            this.gvGantt.BackgroundColor = System.Drawing.Color.White;
            this.gvGantt.ColumnHeadersHeight = 50;
            this.gvGantt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvGantt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGantt.GridColor = System.Drawing.Color.Black;
            this.gvGantt.Location = new System.Drawing.Point(0, 0);
            this.gvGantt.Name = "gvGantt";
            this.gvGantt.ReadOnly = true;
            this.gvGantt.RowHeadersVisible = false;
            this.gvGantt.Size = new System.Drawing.Size(396, 505);
            this.gvGantt.TabIndex = 0;
            this.gvGantt.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gvGantt_Scroll);
            this.gvGantt.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.gvGantt_CellToolTipTextNeeded);
            this.gvGantt.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvGantt_DataBindingComplete);
            // 
            // GanttViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "GanttViewer";
            this.Size = new System.Drawing.Size(600, 505);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGantt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gvTitle;
        private GanttChart gvGantt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewImageColumn TaskPriority;
        private System.Windows.Forms.DataGridViewImageColumn TaskColorCategory;
        private System.Windows.Forms.DataGridViewImageColumn TaskFlag;
    }
}
