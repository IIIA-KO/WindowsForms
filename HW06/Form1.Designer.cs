namespace HW6
{
    partial class Form1
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
            this.TaskButton1 = new System.Windows.Forms.Button();
            this.TaskButton2 = new System.Windows.Forms.Button();
            this.TaskButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskButton1
            // 
            this.TaskButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TaskButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskButton1.Location = new System.Drawing.Point(234, 40);
            this.TaskButton1.Name = "TaskButton1";
            this.TaskButton1.Size = new System.Drawing.Size(182, 87);
            this.TaskButton1.TabIndex = 0;
            this.TaskButton1.Text = "Завдання 1";
            this.TaskButton1.UseVisualStyleBackColor = true;
            this.TaskButton1.Click += new System.EventHandler(this.TaskButton1_Click);
            // 
            // TaskButton2
            // 
            this.TaskButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TaskButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskButton2.Location = new System.Drawing.Point(234, 172);
            this.TaskButton2.Name = "TaskButton2";
            this.TaskButton2.Size = new System.Drawing.Size(182, 87);
            this.TaskButton2.TabIndex = 1;
            this.TaskButton2.Text = "Завдання 2";
            this.TaskButton2.UseVisualStyleBackColor = true;
            this.TaskButton2.Click += new System.EventHandler(this.TaskButton2_Click);
            // 
            // TaskButton3
            // 
            this.TaskButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TaskButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskButton3.Location = new System.Drawing.Point(234, 313);
            this.TaskButton3.Name = "TaskButton3";
            this.TaskButton3.Size = new System.Drawing.Size(182, 87);
            this.TaskButton3.TabIndex = 2;
            this.TaskButton3.Text = "Завдання 3";
            this.TaskButton3.UseVisualStyleBackColor = true;
            this.TaskButton3.Click += new System.EventHandler(this.TaskButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.TaskButton3);
            this.Controls.Add(this.TaskButton2);
            this.Controls.Add(this.TaskButton1);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TaskButton1;
        private System.Windows.Forms.Button TaskButton2;
        private System.Windows.Forms.Button TaskButton3;
    }
}

