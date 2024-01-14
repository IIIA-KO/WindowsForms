namespace HW4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FirstTaskButton = new System.Windows.Forms.Button();
            this.SecondTaskButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SecondTaskButton);
            this.panel1.Controls.Add(this.FirstTaskButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 561);
            this.panel1.TabIndex = 1;
            // 
            // FirstTaskButton
            // 
            this.FirstTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstTaskButton.Location = new System.Drawing.Point(12, 12);
            this.FirstTaskButton.Name = "FirstTaskButton";
            this.FirstTaskButton.Size = new System.Drawing.Size(143, 215);
            this.FirstTaskButton.TabIndex = 0;
            this.FirstTaskButton.Text = "Завдання 1";
            this.FirstTaskButton.UseVisualStyleBackColor = true;
            this.FirstTaskButton.Click += new System.EventHandler(this.FirstTaskButton_Click);
            // 
            // SecondTaskButton
            // 
            this.SecondTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondTaskButton.Location = new System.Drawing.Point(12, 334);
            this.SecondTaskButton.Name = "SecondTaskButton";
            this.SecondTaskButton.Size = new System.Drawing.Size(143, 215);
            this.SecondTaskButton.TabIndex = 1;
            this.SecondTaskButton.Text = "Завдання 2";
            this.SecondTaskButton.UseVisualStyleBackColor = true;
            this.SecondTaskButton.Click += new System.EventHandler(this.SecondTaskButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 561);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SecondTaskButton;
        private System.Windows.Forms.Button FirstTaskButton;
    }
}

