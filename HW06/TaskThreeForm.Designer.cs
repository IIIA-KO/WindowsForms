namespace HW6
{
    partial class TaskThreeForm
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
            this.RTrackBar = new System.Windows.Forms.TrackBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GTrackBar = new System.Windows.Forms.TrackBar();
            this.BTrackBar = new System.Windows.Forms.TrackBar();
            this.RLabel = new System.Windows.Forms.Label();
            this.GLabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.GTextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // RTrackBar
            // 
            this.RTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.RTrackBar.Location = new System.Drawing.Point(94, 87);
            this.RTrackBar.Maximum = 255;
            this.RTrackBar.Name = "RTrackBar";
            this.RTrackBar.Size = new System.Drawing.Size(348, 45);
            this.RTrackBar.TabIndex = 0;
            this.RTrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // GTrackBar
            // 
            this.GTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.GTrackBar.Location = new System.Drawing.Point(94, 156);
            this.GTrackBar.Maximum = 255;
            this.GTrackBar.Name = "GTrackBar";
            this.GTrackBar.Size = new System.Drawing.Size(348, 45);
            this.GTrackBar.TabIndex = 1;
            this.GTrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // BTrackBar
            // 
            this.BTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.BTrackBar.Location = new System.Drawing.Point(94, 239);
            this.BTrackBar.Maximum = 255;
            this.BTrackBar.Name = "BTrackBar";
            this.BTrackBar.Size = new System.Drawing.Size(348, 45);
            this.BTrackBar.TabIndex = 2;
            this.BTrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RLabel.Location = new System.Drawing.Point(52, 87);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(36, 26);
            this.RLabel.TabIndex = 3;
            this.RLabel.Text = "R:";
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GLabel.Location = new System.Drawing.Point(52, 156);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(37, 26);
            this.GLabel.TabIndex = 4;
            this.GLabel.Text = "G:";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BLabel.Location = new System.Drawing.Point(51, 239);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(35, 26);
            this.BLabel.TabIndex = 5;
            this.BLabel.Text = "B:";
            // 
            // RTextBox
            // 
            this.RTextBox.Enabled = false;
            this.RTextBox.Location = new System.Drawing.Point(448, 93);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(95, 20);
            this.RTextBox.TabIndex = 6;
            // 
            // GTextBox
            // 
            this.GTextBox.Enabled = false;
            this.GTextBox.Location = new System.Drawing.Point(448, 162);
            this.GTextBox.Name = "GTextBox";
            this.GTextBox.Size = new System.Drawing.Size(95, 20);
            this.GTextBox.TabIndex = 7;
            // 
            // BTextBox
            // 
            this.BTextBox.Enabled = false;
            this.BTextBox.Location = new System.Drawing.Point(448, 245);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(95, 20);
            this.BTextBox.TabIndex = 8;
            // 
            // TaskThreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(641, 410);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.GTextBox);
            this.Controls.Add(this.RTextBox);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.GLabel);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.BTrackBar);
            this.Controls.Add(this.GTrackBar);
            this.Controls.Add(this.RTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TaskThreeForm";
            this.Text = "TaskThreeForm";
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar RTrackBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar GTrackBar;
        private System.Windows.Forms.TrackBar BTrackBar;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.TextBox GTextBox;
        private System.Windows.Forms.TextBox BTextBox;
    }
}