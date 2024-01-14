namespace HW6
{
    partial class TaskTwoForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.HoursTrackBar = new System.Windows.Forms.TrackBar();
            this.MinutesTrackBar = new System.Windows.Forms.TrackBar();
            this.SecondsTrackBar = new System.Windows.Forms.TrackBar();
            this.HoursProgressBar = new System.Windows.Forms.ProgressBar();
            this.MinutesProgressBar = new System.Windows.Forms.ProgressBar();
            this.SecondsProgressBar = new System.Windows.Forms.ProgressBar();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HoursTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(59, 51);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 13);
            this.TimeLabel.TabIndex = 0;
            // 
            // HoursTrackBar
            // 
            this.HoursTrackBar.Location = new System.Drawing.Point(62, 174);
            this.HoursTrackBar.Maximum = 24;
            this.HoursTrackBar.Name = "HoursTrackBar";
            this.HoursTrackBar.Size = new System.Drawing.Size(324, 45);
            this.HoursTrackBar.TabIndex = 1;
            this.HoursTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // MinutesTrackBar
            // 
            this.MinutesTrackBar.Location = new System.Drawing.Point(62, 250);
            this.MinutesTrackBar.Maximum = 60;
            this.MinutesTrackBar.Name = "MinutesTrackBar";
            this.MinutesTrackBar.Size = new System.Drawing.Size(324, 45);
            this.MinutesTrackBar.TabIndex = 2;
            this.MinutesTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // SecondsTrackBar
            // 
            this.SecondsTrackBar.Location = new System.Drawing.Point(62, 334);
            this.SecondsTrackBar.Maximum = 60;
            this.SecondsTrackBar.Name = "SecondsTrackBar";
            this.SecondsTrackBar.Size = new System.Drawing.Size(324, 45);
            this.SecondsTrackBar.TabIndex = 3;
            this.SecondsTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // HoursProgressBar
            // 
            this.HoursProgressBar.Location = new System.Drawing.Point(62, 184);
            this.HoursProgressBar.Maximum = 24;
            this.HoursProgressBar.Name = "HoursProgressBar";
            this.HoursProgressBar.Size = new System.Drawing.Size(324, 35);
            this.HoursProgressBar.TabIndex = 4;
            // 
            // MinutesProgressBar
            // 
            this.MinutesProgressBar.Location = new System.Drawing.Point(62, 260);
            this.MinutesProgressBar.Maximum = 60;
            this.MinutesProgressBar.Name = "MinutesProgressBar";
            this.MinutesProgressBar.Size = new System.Drawing.Size(324, 35);
            this.MinutesProgressBar.TabIndex = 5;
            // 
            // SecondsProgressBar
            // 
            this.SecondsProgressBar.Location = new System.Drawing.Point(62, 344);
            this.SecondsProgressBar.Maximum = 60;
            this.SecondsProgressBar.Name = "SecondsProgressBar";
            this.SecondsProgressBar.Size = new System.Drawing.Size(324, 35);
            this.SecondsProgressBar.TabIndex = 6;
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HoursLabel.Location = new System.Drawing.Point(438, 195);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(60, 24);
            this.HoursLabel.TabIndex = 7;
            this.HoursLabel.Text = "label1";
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinutesLabel.Location = new System.Drawing.Point(438, 271);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(60, 24);
            this.MinutesLabel.TabIndex = 8;
            this.MinutesLabel.Text = "label1";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondsLabel.Location = new System.Drawing.Point(438, 355);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(60, 24);
            this.SecondsLabel.TabIndex = 9;
            this.SecondsLabel.Text = "label1";
            // 
            // TaskTwoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.SecondsProgressBar);
            this.Controls.Add(this.MinutesProgressBar);
            this.Controls.Add(this.HoursProgressBar);
            this.Controls.Add(this.SecondsTrackBar);
            this.Controls.Add(this.MinutesTrackBar);
            this.Controls.Add(this.HoursTrackBar);
            this.Controls.Add(this.TimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskTwoForm";
            this.Text = "ProgressBar Clock";
            ((System.ComponentModel.ISupportInitialize)(this.HoursTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TrackBar HoursTrackBar;
        private System.Windows.Forms.TrackBar MinutesTrackBar;
        private System.Windows.Forms.TrackBar SecondsTrackBar;
        private System.Windows.Forms.ProgressBar HoursProgressBar;
        private System.Windows.Forms.ProgressBar MinutesProgressBar;
        private System.Windows.Forms.ProgressBar SecondsProgressBar;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label SecondsLabel;
    }
}