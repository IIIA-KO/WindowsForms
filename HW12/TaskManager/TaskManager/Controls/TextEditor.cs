using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskManager.Controls
{
    public partial class TextEditor : UserControl
    {

        #region Data Members

        private bool _richMode = false;
        private bool _showToolBar = false;
        
        #endregion

        #region Constructor

        /// <summary>
        /// constructor
        /// </summary>
        public TextEditor()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public bool RichMode
        {
            get
            {
                return _richMode;
            }
            set
            {
                _richMode = value;
                SetMode();
            }
        }

        /// <summary>
        /// get/set show tool bar 
        /// </summary>
        public bool ShowToolBar
        {
            get 
            { 
                return _showToolBar; 
            }
            set 
            { 
                _showToolBar = value;
                SetMode();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return richTextBox1.ReadOnly; 
            }
            set
            {
                richTextBox1.ReadOnly = value;
            }
        }

        /// <summary>
        /// get/set text
        /// </summary>
        public string PlainText
        {
            get
            {
                return richTextBox1.Text;
            }
            set
            {
                richTextBox1.Text = value;
            }
        }

        /// <summary>
        /// get/set ritch text 
        /// </summary>
        public string RtfText
        {
            get
            {

                return richTextBox1.Rtf;
            }
            set
            {
                richTextBox1.Rtf = value;
            }
        }

        /// <summary>
        /// get text
        /// </summary>
        public override string Text
        {
            get
            {
                return (RichMode) ? RtfText : PlainText;
            }
        }

        #endregion

        #region Private

        /// <summary>
        /// initialize text editor
        /// </summary>
        private void InitializeTextEditor()
        {

            // Font list
            //PopulateFontList();

            // Font Size
            PopulateFontSizeList();

            SetMode();
        }

        /// <summary>
        /// set tool bar mode
        /// </summary>
        private void SetMode()
        {

            toolStrip1.Visible = (RichMode && ShowToolBar);
        }

        /// <summary>
        /// populate font drop down list
        /// </summary>
        private void PopulateFontList()
        {
            tsFontSize.Items.Clear();


            foreach (FontFamily font in FontFamily.Families)
            {
                tsFontSize.Items.Add(font.Name);
            }

            tsFontSize.Text = richTextBox1.SelectionFont.Name;
        }

        /// <summary>
        /// populate font size list
        /// </summary>
        private void PopulateFontSizeList()
        {
            int[] sizeList = { 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            tsFontSize.Items.Clear();

            //for (int i = 8; i <= 48; i++)
            foreach (int i in sizeList)
            {
                tsFontSize.Items.Add(i.ToString());
            }

            tsFontSize.Text = ((int)richTextBox1.SelectionFont.Size).ToString();


        }

        /// <summary>
        /// toggle font style
        /// </summary>
        /// <param name="fontStyle">font style</param>
        private void ToggleStyle(FontStyle fontStyle)
        {
            FontStyle selectedStyle = richTextBox1.SelectionFont.Style;



            int n = (int)(selectedStyle & fontStyle);
            if (n > 0)
            {
                selectedStyle = selectedStyle & GetStyleExcluding(fontStyle);
            }
            else
            {
                selectedStyle = selectedStyle | fontStyle;
            }


            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, selectedStyle);
        }

        /// <summary>
        /// get font style excluding font style passed in parameter.
        /// </summary>
        /// <param name="fontStyle">font style for excluding</param>
        /// <returns>font style</returns>
        private FontStyle GetStyleExcluding(FontStyle fontStyle)
        {

            FontStyle styleToReturn = FontStyle.Regular;
            foreach (FontStyle style in Enum.GetValues(typeof(FontStyle)))
            {
                if (style != fontStyle)
                {
                    styleToReturn = styleToReturn | style;
                }
            }

            return styleToReturn;
        }

        #endregion

        #region Events

        private void TextEditor_Load(object sender, EventArgs e)
        {
            InitializeTextEditor();
        }

        #region Tool Box Event

        private void tsBold_Click(object sender, EventArgs e)
        {

            ToggleStyle(FontStyle.Bold);

        }

        private void tsUnderLine_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Underline);
        }

        private void tsItalic_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Italic);

        }

        private void tsStrikeOut_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Strikeout);
        }

        private void tsForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void tsBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog1.Color;
            }
        }

        private void tsOrderList_Click(object sender, EventArgs e)
        {

        }

        private void tsUnOrderList_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void tsFontSize_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, Convert.ToInt32(tsFontSize.Text), richTextBox1.SelectionFont.Style);
        }


        #endregion


        #endregion

    }
}
