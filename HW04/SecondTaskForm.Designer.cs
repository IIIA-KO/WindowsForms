namespace HW4
{
    partial class SecondTaskForm
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
            this.ALabel = new System.Windows.Forms.Label();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.XminTextBox = new System.Windows.Forms.TextBox();
            this.XminLabel = new System.Windows.Forms.Label();
            this.XmaxTextBox = new System.Windows.Forms.TextBox();
            this.XmaxLabel = new System.Windows.Forms.Label();
            this.StepTextBox = new System.Windows.Forms.TextBox();
            this.StepLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ALabel
            // 
            this.ALabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ALabel.AutoSize = true;
            this.ALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ALabel.Location = new System.Drawing.Point(12, 109);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(100, 20);
            this.ALabel.TabIndex = 0;
            this.ALabel.Text = "Значення a:";
            // 
            // ATextBox
            // 
            this.ATextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ATextBox.Location = new System.Drawing.Point(145, 103);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(115, 26);
            this.ATextBox.TabIndex = 1;
            // 
            // XminTextBox
            // 
            this.XminTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.XminTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XminTextBox.Location = new System.Drawing.Point(145, 161);
            this.XminTextBox.Name = "XminTextBox";
            this.XminTextBox.Size = new System.Drawing.Size(115, 26);
            this.XminTextBox.TabIndex = 3;
            // 
            // XminLabel
            // 
            this.XminLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.XminLabel.AutoSize = true;
            this.XminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XminLabel.Location = new System.Drawing.Point(12, 164);
            this.XminLabel.Name = "XminLabel";
            this.XminLabel.Size = new System.Drawing.Size(127, 20);
            this.XminLabel.TabIndex = 2;
            this.XminLabel.Text = "Значення Xmin:";
            // 
            // XmaxTextBox
            // 
            this.XmaxTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.XmaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XmaxTextBox.Location = new System.Drawing.Point(145, 214);
            this.XmaxTextBox.Name = "XmaxTextBox";
            this.XmaxTextBox.Size = new System.Drawing.Size(115, 26);
            this.XmaxTextBox.TabIndex = 5;
            // 
            // XmaxLabel
            // 
            this.XmaxLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.XmaxLabel.AutoSize = true;
            this.XmaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XmaxLabel.Location = new System.Drawing.Point(12, 220);
            this.XmaxLabel.Name = "XmaxLabel";
            this.XmaxLabel.Size = new System.Drawing.Size(131, 20);
            this.XmaxLabel.TabIndex = 4;
            this.XmaxLabel.Text = "Значення Xmax:";
            // 
            // StepTextBox
            // 
            this.StepTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StepTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepTextBox.Location = new System.Drawing.Point(145, 281);
            this.StepTextBox.Name = "StepTextBox";
            this.StepTextBox.Size = new System.Drawing.Size(115, 26);
            this.StepTextBox.TabIndex = 7;
            // 
            // StepLabel
            // 
            this.StepLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StepLabel.AutoSize = true;
            this.StepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepLabel.Location = new System.Drawing.Point(11, 284);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(132, 20);
            this.StepLabel.TabIndex = 6;
            this.StepLabel.Text = "Значення кроку:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Програма обрахунку y = f(x)";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(450, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(338, 404);
            this.listBox1.TabIndex = 9;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(78, 366);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(123, 49);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Обрахувати";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // SecondTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StepTextBox);
            this.Controls.Add(this.StepLabel);
            this.Controls.Add(this.XmaxTextBox);
            this.Controls.Add(this.XmaxLabel);
            this.Controls.Add(this.XminTextBox);
            this.Controls.Add(this.XminLabel);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.ALabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecondTaskForm";
            this.Text = "SecondTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox XminTextBox;
        private System.Windows.Forms.Label XminLabel;
        private System.Windows.Forms.TextBox XmaxTextBox;
        private System.Windows.Forms.Label XmaxLabel;
        private System.Windows.Forms.TextBox StepTextBox;
        private System.Windows.Forms.Label StepLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CalculateButton;
    }
}