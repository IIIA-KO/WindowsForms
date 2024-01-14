namespace TaskManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.FindTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переглянутиПрикріпленийФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задачіНаМісяцьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задачіНаТижденьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задачіНаДеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditTaskToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditProjectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CreateTaskToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CreateProjectToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteTaskToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteProjectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SavePDFButton = new System.Windows.Forms.ToolStripButton();
            this.FindToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProjectsListBox = new System.Windows.Forms.ListBox();
            this.TasksListBox = new System.Windows.Forms.ListBox();
            this.видалитиПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTaskToolStripMenuItem,
            this.CreateProjectToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.toolStripSeparator5,
            this.редагуватиЗадачуToolStripMenuItem,
            this.редагуватиПроектToolStripMenuItem,
            this.toolStripSeparator6,
            this.FindTaskToolStripMenuItem,
            this.переглянутиПрикріпленийФайлToolStripMenuItem,
            this.CalendarToolStripMenuItem,
            this.зберегтиPDFToolStripMenuItem,
            this.toolStripSeparator8,
            this.видалитиЗадачуToolStripMenuItem,
            this.видалитиПроектToolStripMenuItem,
            this.toolStripSeparator7,
            this.ExitToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.менюToolStripMenuItem.Text = "Файл";
            // 
            // CreateTaskToolStripMenuItem
            // 
            this.CreateTaskToolStripMenuItem.Name = "CreateTaskToolStripMenuItem";
            this.CreateTaskToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.CreateTaskToolStripMenuItem.Text = "Створити задачу";
            this.CreateTaskToolStripMenuItem.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // CreateProjectToolStripMenuItem
            // 
            this.CreateProjectToolStripMenuItem.Name = "CreateProjectToolStripMenuItem";
            this.CreateProjectToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.CreateProjectToolStripMenuItem.Text = "Створити проект";
            this.CreateProjectToolStripMenuItem.Click += new System.EventHandler(this.CreateProjectToolStripButton1_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.SaveToolStripMenuItem.Text = "Зберегти";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(255, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(255, 6);
            // 
            // FindTaskToolStripMenuItem
            // 
            this.FindTaskToolStripMenuItem.Name = "FindTaskToolStripMenuItem";
            this.FindTaskToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.FindTaskToolStripMenuItem.Text = "Шукати задачу";
            // 
            // переглянутиПрикріпленийФайлToolStripMenuItem
            // 
            this.переглянутиПрикріпленийФайлToolStripMenuItem.Name = "переглянутиПрикріпленийФайлToolStripMenuItem";
            this.переглянутиПрикріпленийФайлToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.переглянутиПрикріпленийФайлToolStripMenuItem.Text = "Переглянути прикріплений файл";
            this.переглянутиПрикріпленийФайлToolStripMenuItem.Click += new System.EventHandler(this.переглянутиПрикріпленийФайлToolStripMenuItem_Click);
            // 
            // CalendarToolStripMenuItem
            // 
            this.CalendarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задачіНаМісяцьToolStripMenuItem,
            this.задачіНаТижденьToolStripMenuItem,
            this.задачіНаДеньToolStripMenuItem});
            this.CalendarToolStripMenuItem.Name = "CalendarToolStripMenuItem";
            this.CalendarToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.CalendarToolStripMenuItem.Text = "Календар";
            // 
            // задачіНаМісяцьToolStripMenuItem
            // 
            this.задачіНаМісяцьToolStripMenuItem.Name = "задачіНаМісяцьToolStripMenuItem";
            this.задачіНаМісяцьToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.задачіНаМісяцьToolStripMenuItem.Text = "Задачі на місяць";
            this.задачіНаМісяцьToolStripMenuItem.Click += new System.EventHandler(this.задачіНаМісяцьToolStripMenuItem_Click);
            // 
            // задачіНаТижденьToolStripMenuItem
            // 
            this.задачіНаТижденьToolStripMenuItem.Name = "задачіНаТижденьToolStripMenuItem";
            this.задачіНаТижденьToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.задачіНаТижденьToolStripMenuItem.Text = "Задачі на тиждень";
            this.задачіНаТижденьToolStripMenuItem.Click += new System.EventHandler(this.задачіНаТижденьToolStripMenuItem_Click);
            // 
            // задачіНаДеньToolStripMenuItem
            // 
            this.задачіНаДеньToolStripMenuItem.Name = "задачіНаДеньToolStripMenuItem";
            this.задачіНаДеньToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.задачіНаДеньToolStripMenuItem.Text = "Задачі на день";
            this.задачіНаДеньToolStripMenuItem.Click += new System.EventHandler(this.задачіНаДеньToolStripMenuItem_Click);
            // 
            // зберегтиPDFToolStripMenuItem
            // 
            this.зберегтиPDFToolStripMenuItem.Name = "зберегтиPDFToolStripMenuItem";
            this.зберегтиPDFToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.зберегтиPDFToolStripMenuItem.Text = "Зберегти PDF";
            this.зберегтиPDFToolStripMenuItem.Click += new System.EventHandler(this.SavePDFButton_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(255, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(255, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.ExitToolStripMenuItem.Text = "Вихід";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.EditTaskToolStripButton,
            this.EditProjectToolStripButton,
            this.toolStripSeparator1,
            this.CreateTaskToolStripButton,
            this.CreateProjectToolStripButton1,
            this.toolStripSeparator3,
            this.DeleteTaskToolStripButton,
            this.DeleteProjectToolStripButton,
            this.toolStripSeparator4,
            this.SavePDFButton,
            this.FindToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(267, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // EditTaskToolStripButton
            // 
            this.EditTaskToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditTaskToolStripButton.Image = global::TaskManager.Properties.Resources._352547_edit_mode_icon;
            this.EditTaskToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditTaskToolStripButton.Name = "EditTaskToolStripButton";
            this.EditTaskToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.EditTaskToolStripButton.Text = "toolStripButton1";
            this.EditTaskToolStripButton.Click += new System.EventHandler(this.EditTaskToolStripButton_Click);
            // 
            // EditProjectToolStripButton
            // 
            this.EditProjectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditProjectToolStripButton.Image = global::TaskManager.Properties.Resources.writing;
            this.EditProjectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditProjectToolStripButton.Name = "EditProjectToolStripButton";
            this.EditProjectToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.EditProjectToolStripButton.Text = "toolStripButton1";
            this.EditProjectToolStripButton.Click += new System.EventHandler(this.EditProjectToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CreateTaskToolStripButton
            // 
            this.CreateTaskToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateTaskToolStripButton.Image = global::TaskManager.Properties.Resources.plus;
            this.CreateTaskToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateTaskToolStripButton.Name = "CreateTaskToolStripButton";
            this.CreateTaskToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CreateTaskToolStripButton.Text = "toolStripButton2";
            this.CreateTaskToolStripButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // CreateProjectToolStripButton1
            // 
            this.CreateProjectToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateProjectToolStripButton1.Image = global::TaskManager.Properties.Resources._3669292_playlist_add_ic_icon;
            this.CreateProjectToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateProjectToolStripButton1.Name = "CreateProjectToolStripButton1";
            this.CreateProjectToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.CreateProjectToolStripButton1.Text = "toolStripButton1";
            this.CreateProjectToolStripButton1.Click += new System.EventHandler(this.CreateProjectToolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // DeleteTaskToolStripButton
            // 
            this.DeleteTaskToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteTaskToolStripButton.Image = global::TaskManager.Properties.Resources._3669361_delete_ic_icon;
            this.DeleteTaskToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteTaskToolStripButton.Name = "DeleteTaskToolStripButton";
            this.DeleteTaskToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteTaskToolStripButton.Text = "toolStripButton1";
            this.DeleteTaskToolStripButton.Click += new System.EventHandler(this.DeleteTaskToolStripButton_Click);
            // 
            // DeleteProjectToolStripButton
            // 
            this.DeleteProjectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteProjectToolStripButton.Image = global::TaskManager.Properties.Resources._5875985_action_all_bin_delete_garbage_icon;
            this.DeleteProjectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteProjectToolStripButton.Name = "DeleteProjectToolStripButton";
            this.DeleteProjectToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteProjectToolStripButton.Text = "toolStripButton2";
            this.DeleteProjectToolStripButton.Click += new System.EventHandler(this.DeleteProjectToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // SavePDFButton
            // 
            this.SavePDFButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SavePDFButton.Image = global::TaskManager.Properties.Resources.free_icon_pdf_482216;
            this.SavePDFButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SavePDFButton.Name = "SavePDFButton";
            this.SavePDFButton.Size = new System.Drawing.Size(23, 22);
            this.SavePDFButton.Text = "toolStripButton2";
            this.SavePDFButton.Click += new System.EventHandler(this.SavePDFButton_Click);
            // 
            // FindToolStripButton
            // 
            this.FindToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.FindToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FindToolStripButton.Image = global::TaskManager.Properties.Resources._4781817_brows_browsing_find_search_seo_icon;
            this.FindToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindToolStripButton.Name = "FindToolStripButton";
            this.FindToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FindToolStripButton.Text = "toolStripButton1";
            this.FindToolStripButton.Click += new System.EventHandler(this.FindToolStripButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ProjectsListBox);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TasksListBox);
            this.splitContainer1.Size = new System.Drawing.Size(804, 427);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 2;
            // 
            // ProjectsListBox
            // 
            this.ProjectsListBox.AllowDrop = true;
            this.ProjectsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsListBox.FormattingEnabled = true;
            this.ProjectsListBox.Location = new System.Drawing.Point(0, 25);
            this.ProjectsListBox.Name = "ProjectsListBox";
            this.ProjectsListBox.ScrollAlwaysVisible = true;
            this.ProjectsListBox.Size = new System.Drawing.Size(267, 402);
            this.ProjectsListBox.TabIndex = 0;
            this.ProjectsListBox.SelectedIndexChanged += new System.EventHandler(this.ProjectsListBox_SelectedIndexChanged);
            this.ProjectsListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ProjectsListBox_DragEnter);
            this.ProjectsListBox.DragLeave += new System.EventHandler(this.ProjectsListBox_DragLeave);
            // 
            // TasksListBox
            // 
            this.TasksListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksListBox.FormattingEnabled = true;
            this.TasksListBox.Location = new System.Drawing.Point(0, 0);
            this.TasksListBox.Name = "TasksListBox";
            this.TasksListBox.ScrollAlwaysVisible = true;
            this.TasksListBox.Size = new System.Drawing.Size(533, 427);
            this.TasksListBox.TabIndex = 0;
            this.TasksListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TasksListBox_MouseMove);
            // 
            // видалитиПроектToolStripMenuItem
            // 
            this.видалитиПроектToolStripMenuItem.Name = "видалитиПроектToolStripMenuItem";
            this.видалитиПроектToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.видалитиПроектToolStripMenuItem.Text = "Видалити проект";
            // 
            // видалитиЗадачуToolStripMenuItem
            // 
            this.видалитиЗадачуToolStripMenuItem.Name = "видалитиЗадачуToolStripMenuItem";
            this.видалитиЗадачуToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.видалитиЗадачуToolStripMenuItem.Text = "Видалити задачу";
            this.видалитиЗадачуToolStripMenuItem.Click += new System.EventHandler(this.DeleteTaskToolStripButton_Click);
            // 
            // редагуватиПроектToolStripMenuItem
            // 
            this.редагуватиПроектToolStripMenuItem.Name = "редагуватиПроектToolStripMenuItem";
            this.редагуватиПроектToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.редагуватиПроектToolStripMenuItem.Text = "Редагувати проект";
            // 
            // редагуватиЗадачуToolStripMenuItem
            // 
            this.редагуватиЗадачуToolStripMenuItem.Name = "редагуватиЗадачуToolStripMenuItem";
            this.редагуватиЗадачуToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.редагуватиЗадачуToolStripMenuItem.Text = "Редагувати задачу";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(820, 490);
            this.Name = "MainForm";
            this.Text = "To-Do List";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задачіНаМісяцьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задачіНаТижденьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задачіНаДеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox ProjectsListBox;
        private System.Windows.Forms.ToolStripButton FindToolStripButton;
        private System.Windows.Forms.ToolStripButton CreateTaskToolStripButton;
        private System.Windows.Forms.ToolStripButton CreateProjectToolStripButton1;
        private System.Windows.Forms.ToolStripButton EditTaskToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem зберегтиPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton SavePDFButton;
        private System.Windows.Forms.ToolStripButton DeleteTaskToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteProjectToolStripButton;
        private System.Windows.Forms.ToolStripButton EditProjectToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ListBox TasksListBox;
        private System.Windows.Forms.ToolStripMenuItem переглянутиПрикріпленийФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиЗадачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиЗадачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиПроектToolStripMenuItem;
    }
}

