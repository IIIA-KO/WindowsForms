using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            string fileName = "questionnaires.txt";

            List<string> questionnaire = new List<string>();
            questionnaire.Add(SurnameTextBox.Text);
            questionnaire.Add(NameTextBox.Text);
            questionnaire.Add(PatronymicTextBox.Text);
            questionnaire.Add(CountruTextBox.Text);
            questionnaire.Add(CityTextBox.Text);
            questionnaire.Add(PhoneTextBox.Text);
            questionnaire.Add(BirrthTimePicker.Value.ToShortDateString());

            questionnaire.Add(MaleRadioButton.Checked ? MaleRadioButton.Text : FemaleRadioButton.Text);

            File.AppendAllLines(fileName, questionnaire);
            MessageBox.Show("Анкету збережено");
        }
    }
}
