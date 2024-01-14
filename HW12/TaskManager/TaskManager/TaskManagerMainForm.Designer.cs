namespace TaskManager
{
    partial class TaskManagerMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagerMainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolAddNewTask = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolTaskList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmtaskGantt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuToolAddNewResource = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolResource = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuToolAddNewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuToolSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbTask = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbViewResources = new System.Windows.Forms.ToolStripButton();
            this.tsbViewCategory = new System.Windows.Forms.ToolStripButton();
            this.tsbSetting = new System.Windows.Forms.ToolStripButton();
            this.tsbAddNewTask = new System.Windows.Forms.ToolStripButton();
            this.tsbAddResource = new System.Windows.Forms.ToolStripButton();
            this.tsbAddCategory = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenu,
            this.toolsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(831, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClose});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(37, 20);
            this.viewMenu.Text = "&File";
            // 
            // tsmClose
            // 
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(103, 22);
            this.tsmClose.Text = "&Close";
            this.tsmClose.Click += new System.EventHandler(this.tsmClose_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolAddNewTask,
            this.mnuToolTaskList,
            this.tsmtaskGantt,
            this.toolStripMenuItem1,
            this.mnuToolAddNewResource,
            this.mnuToolResource,
            this.toolStripMenuItem2,
            this.mnuToolAddNewCategory,
            this.categoryListToolStripMenuItem,
            this.toolStripSeparator2,
            this.mnuToolSetting});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(90, 20);
            this.toolsMenu.Text = "&Management";
            // 
            // mnuToolAddNewTask
            // 
            this.mnuToolAddNewTask.Image = global::TaskManager.Properties.Resources.AddTask;
            this.mnuToolAddNewTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuToolAddNewTask.Name = "mnuToolAddNewTask";
            this.mnuToolAddNewTask.Size = new System.Drawing.Size(198, 48);
            this.mnuToolAddNewTask.Text = "Add &New Task";
            this.mnuToolAddNewTask.Click += new System.EventHandler(this.mnuToolAddNewTask_Click);
            // 
            // mnuToolTaskList
            // 
            this.mnuToolTaskList.Image = global::TaskManager.Properties.Resources.Task;
            this.mnuToolTaskList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuToolTaskList.Name = "mnuToolTaskList";
            this.mnuToolTaskList.Size = new System.Drawing.Size(198, 48);
            this.mnuToolTaskList.Text = "&Task List";
            this.mnuToolTaskList.Click += new System.EventHandler(this.mnuToolTaskList_Click);
            // 
            // tsmtaskGantt
            // 
            this.tsmtaskGantt.Image = global::TaskManager.Properties.Resources.GanttChart;
            this.tsmtaskGantt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmtaskGantt.Name = "tsmtaskGantt";
            this.tsmtaskGantt.Size = new System.Drawing.Size(198, 48);
            this.tsmtaskGantt.Text = "&Gantt Chart";
            this.tsmtaskGantt.Click += new System.EventHandler(this.tsmtaskGantt_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
            // 
            // mnuToolAddNewResource
            // 
            this.mnuToolAddNewResource.Image = global::TaskManager.Properties.Resources.AddResource;
            this.mnuToolAddNewResource.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuToolAddNewResource.Name = "mnuToolAddNewResource";
            this.mnuToolAddNewResource.Size = new System.Drawing.Size(198, 48);
            this.mnuToolAddNewResource.Text = "Add New &Resource";
            this.mnuToolAddNewResource.Click += new System.EventHandler(this.mnuToolAddNewResource_Click);
            // 
            // mnuToolResource
            // 
            this.mnuToolResource.Image = global::TaskManager.Properties.Resources.Resource;
            this.mnuToolResource.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuToolResource.Name = "mnuToolResource";
            this.mnuToolResource.Size = new System.Drawing.Size(198, 48);
            this.mnuToolResource.Text = "Reso&urce List";
            this.mnuToolResource.Click += new System.EventHandler(this.mnuToolResource_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(195, 6);
            // 
            // mnuToolAddNewCategory
            // 
            this.mnuToolAddNewCategory.Image = global::TaskManager.Properties.Resources.AddCategory;
            this.mnuToolAddNewCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuToolAddNewCategory.Name = "mnuToolAddNewCategory";
            this.mnuToolAddNewCategory.Size = new System.Drawing.Size(198, 48);
            this.mnuToolAddNewCategory.Text = "Add New &Category";
            this.mnuToolAddNewCategory.Click += new System.EventHandler(this.mnuToolAddNewCategory_Click);
            // 
            // categoryListToolStripMenuItem
            // 
            this.categoryListToolStripMenuItem.Image = global::TaskManager.Properties.Resources.Category;
            this.categoryListToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.categoryListToolStripMenuItem.Name = "categoryListToolStripMenuItem";
            this.categoryListToolStripMenuItem.Size = new System.Drawing.Size(198, 48);
            this.categoryListToolStripMenuItem.Text = "Category &List";
            this.categoryListToolStripMenuItem.Click += new System.EventHandler(this.categoryListToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // mnuToolSetting
            // 
            this.mnuToolSetting.Image = global::TaskManager.Properties.Resources.TaskSetting;
            this.mnuToolSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuToolSetting.Name = "mnuToolSetting";
            this.mnuToolSetting.Size = new System.Drawing.Size(198, 48);
            this.mnuToolSetting.Text = "&Setting";
            this.mnuToolSetting.Click += new System.EventHandler(this.mnuToolSetting_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbTask,
            this.toolStripButton1,
            this.tsbViewResources,
            this.tsbViewCategory,
            this.tsbSetting,
            this.toolStripSeparator1,
            this.tsbAddNewTask,
            this.tsbAddResource,
            this.tsbAddCategory});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(831, 48);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // tsbTask
            // 
            this.tsbTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTask.Image = global::TaskManager.Properties.Resources.Task;
            this.tsbTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTask.Name = "tsbTask";
            this.tsbTask.Size = new System.Drawing.Size(35, 45);
            this.tsbTask.Text = "toolStripButton1";
            this.tsbTask.ToolTipText = "View All Tasks";
            this.tsbTask.Click += new System.EventHandler(this.tsbTask_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TaskManager.Properties.Resources.GanttChart;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 45);
            this.toolStripButton1.Text = "tsbGanttChart";
            this.toolStripButton1.ToolTipText = "Gantt View of Tasks";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbViewResources
            // 
            this.tsbViewResources.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewResources.Image = global::TaskManager.Properties.Resources.Resource;
            this.tsbViewResources.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbViewResources.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewResources.Name = "tsbViewResources";
            this.tsbViewResources.Size = new System.Drawing.Size(35, 45);
            this.tsbViewResources.Text = "View All Resources";
            this.tsbViewResources.Click += new System.EventHandler(this.tsbViewResources_Click);
            // 
            // tsbViewCategory
            // 
            this.tsbViewCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewCategory.Image = global::TaskManager.Properties.Resources.Category;
            this.tsbViewCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbViewCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewCategory.Name = "tsbViewCategory";
            this.tsbViewCategory.Size = new System.Drawing.Size(35, 45);
            this.tsbViewCategory.Text = "toolStripButton1";
            this.tsbViewCategory.ToolTipText = "View All Categories ";
            this.tsbViewCategory.Click += new System.EventHandler(this.tsbViewCategory_Click);
            // 
            // tsbSetting
            // 
            this.tsbSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSetting.Image = global::TaskManager.Properties.Resources.TaskSetting;
            this.tsbSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSetting.Name = "tsbSetting";
            this.tsbSetting.Size = new System.Drawing.Size(44, 45);
            this.tsbSetting.Text = "Task Manager Setting";
            this.tsbSetting.Click += new System.EventHandler(this.tsbSetting_Click);
            // 
            // tsbAddNewTask
            // 
            this.tsbAddNewTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddNewTask.Image = global::TaskManager.Properties.Resources.AddTask;
            this.tsbAddNewTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddNewTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNewTask.Name = "tsbAddNewTask";
            this.tsbAddNewTask.Size = new System.Drawing.Size(35, 45);
            this.tsbAddNewTask.Text = "toolStripButton2";
            this.tsbAddNewTask.ToolTipText = "Add New Task";
            this.tsbAddNewTask.Click += new System.EventHandler(this.tsbAddNewTask_Click);
            // 
            // tsbAddResource
            // 
            this.tsbAddResource.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddResource.Image = global::TaskManager.Properties.Resources.AddResource;
            this.tsbAddResource.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddResource.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddResource.Name = "tsbAddResource";
            this.tsbAddResource.Size = new System.Drawing.Size(35, 45);
            this.tsbAddResource.Text = "Add Resource";
            this.tsbAddResource.ToolTipText = "Add New Resource";
            this.tsbAddResource.Click += new System.EventHandler(this.tsbAddResource_Click);
            // 
            // tsbAddCategory
            // 
            this.tsbAddCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddCategory.Image = global::TaskManager.Properties.Resources.AddCategory;
            this.tsbAddCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddCategory.Name = "tsbAddCategory";
            this.tsbAddCategory.Size = new System.Drawing.Size(35, 45);
            this.tsbAddCategory.Text = "toolStripButton1";
            this.tsbAddCategory.ToolTipText = "Add New Category";
            this.tsbAddCategory.Click += new System.EventHandler(this.tsbAddCategory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 453);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Task Manager 1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuToolAddNewResource;
        private System.Windows.Forms.ToolStripMenuItem mnuToolResource;
        private System.Windows.Forms.ToolStripMenuItem mnuToolAddNewTask;
        private System.Windows.Forms.ToolStripMenuItem mnuToolTaskList;
        private System.Windows.Forms.ToolStripMenuItem mnuToolAddNewCategory;
        private System.Windows.Forms.ToolStripMenuItem categoryListToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbViewResources;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbAddResource;
        private System.Windows.Forms.ToolStripButton tsbTask;
        private System.Windows.Forms.ToolStripButton tsbAddNewTask;
        private System.Windows.Forms.ToolStripButton tsbViewCategory;
        private System.Windows.Forms.ToolStripButton tsbAddCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuToolSetting;
        private System.Windows.Forms.ToolStripButton tsbSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.ToolStripMenuItem tsmtaskGantt;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}



