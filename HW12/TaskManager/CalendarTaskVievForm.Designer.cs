namespace TaskManager
{
    partial class CalendarTaskVievForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProjectsListBox = new System.Windows.Forms.ListBox();
            this.TasksListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.ProjectsListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TasksListBox);
            this.splitContainer1.Size = new System.Drawing.Size(804, 451);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 3;
            // 
            // ProjectsListBox
            // 
            this.ProjectsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsListBox.FormattingEnabled = true;
            this.ProjectsListBox.Location = new System.Drawing.Point(0, 0);
            this.ProjectsListBox.Name = "ProjectsListBox";
            this.ProjectsListBox.ScrollAlwaysVisible = true;
            this.ProjectsListBox.Size = new System.Drawing.Size(267, 451);
            this.ProjectsListBox.TabIndex = 0;
            this.ProjectsListBox.SelectedIndexChanged += new System.EventHandler(this.ProjectsListBox_SelectedIndexChanged);
            // 
            // TasksListBox
            // 
            this.TasksListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksListBox.FormattingEnabled = true;
            this.TasksListBox.Location = new System.Drawing.Point(0, 0);
            this.TasksListBox.Name = "TasksListBox";
            this.TasksListBox.ScrollAlwaysVisible = true;
            this.TasksListBox.Size = new System.Drawing.Size(533, 451);
            this.TasksListBox.TabIndex = 0;
            // 
            // CalendarTaskVievForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(820, 490);
            this.Name = "CalendarTaskVievForm";
            this.Text = "CalendarTaskVievForm";
            this.Load += new System.EventHandler(this.CalendarTaskVievForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox ProjectsListBox;
        private System.Windows.Forms.ListBox TasksListBox;
    }
}