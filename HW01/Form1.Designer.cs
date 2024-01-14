namespace HW1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.SystemColors.Info;
            this.NoButton.Location = new System.Drawing.Point(375, 285);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(150, 75);
            this.NoButton.TabIndex = 0;
            this.NoButton.Text = "Ні";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(53, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Чи бажаєте ви отримати прибавку до запрлати?";
            this.label1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.SystemColors.Info;
            this.YesButton.Location = new System.Drawing.Point(118, 285);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(150, 75);
            this.YesButton.TabIndex = 2;
            this.YesButton.Text = "Так";
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.MouseEnter += new System.EventHandler(this.YesButton_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 411);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Si minus minus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YesButton;
    }
}

