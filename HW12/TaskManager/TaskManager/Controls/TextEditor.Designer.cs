namespace TaskManager.Controls
{
    partial class TextEditor
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsBold = new System.Windows.Forms.ToolStripButton();
            this.tsItalic = new System.Windows.Forms.ToolStripButton();
            this.tsUnderLine = new System.Windows.Forms.ToolStripButton();
            this.tsStrikeOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsForeColor = new System.Windows.Forms.ToolStripButton();
            this.tsBackColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsOrderList = new System.Windows.Forms.ToolStripButton();
            this.tsUnOrderList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(422, 317);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFontSize,
            this.tsBold,
            this.tsItalic,
            this.tsUnderLine,
            this.tsStrikeOut,
            this.toolStripSeparator1,
            this.tsForeColor,
            this.tsBackColor,
            this.toolStripSeparator2,
            this.tsOrderList,
            this.tsUnOrderList,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(422, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsFontSize
            // 
            this.tsFontSize.AutoSize = false;
            this.tsFontSize.DropDownHeight = 75;
            this.tsFontSize.DropDownWidth = 45;
            this.tsFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tsFontSize.IntegralHeight = false;
            this.tsFontSize.Name = "tsFontSize";
            this.tsFontSize.Size = new System.Drawing.Size(35, 23);
            this.tsFontSize.TextChanged += new System.EventHandler(this.tsFontSize_TextChanged);
            // 
            // tsBold
            // 
            this.tsBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBold.Image = global::TaskManager.Properties.Resources.bold;
            this.tsBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBold.Name = "tsBold";
            this.tsBold.Size = new System.Drawing.Size(23, 22);
            this.tsBold.Text = "toolStripButton1";
            this.tsBold.Click += new System.EventHandler(this.tsBold_Click);
            // 
            // tsItalic
            // 
            this.tsItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsItalic.Image = global::TaskManager.Properties.Resources.italic;
            this.tsItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsItalic.Name = "tsItalic";
            this.tsItalic.Size = new System.Drawing.Size(23, 22);
            this.tsItalic.Text = "toolStripButton1";
            this.tsItalic.Click += new System.EventHandler(this.tsItalic_Click);
            // 
            // tsUnderLine
            // 
            this.tsUnderLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUnderLine.Image = global::TaskManager.Properties.Resources.underscore;
            this.tsUnderLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUnderLine.Name = "tsUnderLine";
            this.tsUnderLine.Size = new System.Drawing.Size(23, 22);
            this.tsUnderLine.Text = "toolStripButton1";
            this.tsUnderLine.Click += new System.EventHandler(this.tsUnderLine_Click);
            // 
            // tsStrikeOut
            // 
            this.tsStrikeOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsStrikeOut.Image = global::TaskManager.Properties.Resources.bold;
            this.tsStrikeOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStrikeOut.Name = "tsStrikeOut";
            this.tsStrikeOut.Size = new System.Drawing.Size(23, 22);
            this.tsStrikeOut.Text = "toolStripButton1";
            this.tsStrikeOut.Click += new System.EventHandler(this.tsStrikeOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsForeColor
            // 
            this.tsForeColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsForeColor.Image = global::TaskManager.Properties.Resources.color;
            this.tsForeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsForeColor.Name = "tsForeColor";
            this.tsForeColor.Size = new System.Drawing.Size(23, 22);
            this.tsForeColor.Text = "toolStripButton1";
            this.tsForeColor.Click += new System.EventHandler(this.tsForeColor_Click);
            // 
            // tsBackColor
            // 
            this.tsBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBackColor.Image = global::TaskManager.Properties.Resources.backcolor;
            this.tsBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBackColor.Name = "tsBackColor";
            this.tsBackColor.Size = new System.Drawing.Size(23, 22);
            this.tsBackColor.Text = "toolStripButton2";
            this.tsBackColor.Click += new System.EventHandler(this.tsBackColor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsOrderList
            // 
            this.tsOrderList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOrderList.Image = global::TaskManager.Properties.Resources.ol;
            this.tsOrderList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOrderList.Name = "tsOrderList";
            this.tsOrderList.Size = new System.Drawing.Size(23, 22);
            this.tsOrderList.Text = "toolStripButton1";
            this.tsOrderList.Click += new System.EventHandler(this.tsOrderList_Click);
            // 
            // tsUnOrderList
            // 
            this.tsUnOrderList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUnOrderList.Image = global::TaskManager.Properties.Resources.uol;
            this.tsUnOrderList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUnOrderList.Name = "tsUnOrderList";
            this.tsUnOrderList.Size = new System.Drawing.Size(23, 22);
            this.tsUnOrderList.Text = "toolStripButton2";
            this.tsUnOrderList.Click += new System.EventHandler(this.tsUnOrderList_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TextEditor";
            this.Size = new System.Drawing.Size(422, 342);
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBold;
        private System.Windows.Forms.ToolStripButton tsItalic;
        private System.Windows.Forms.ToolStripButton tsUnderLine;
        private System.Windows.Forms.ToolStripButton tsStrikeOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsForeColor;
        private System.Windows.Forms.ToolStripButton tsBackColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsOrderList;
        private System.Windows.Forms.ToolStripButton tsUnOrderList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox tsFontSize;
    }
}
