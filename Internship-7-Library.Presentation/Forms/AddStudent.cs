using System;
using System.Windows.Forms;
using Internship_7_Library.Data.Enums;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class AddStudent : Form
    {
        public AddStudent(StudentRepository studentRepo)
        {
            InitializeComponent();
            _students = studentRepo;
            foreach (var sex in Enum.GetValues(typeof(Sex)))
            {
                SexComboBox.Items.Add(sex);
            }

            foreach (var grade in Enum.GetValues(typeof(Grade)))
            {
                GradeComboBox.Items.Add(grade);
            }
            BirthDatePicker.MinDate = new DateTime(2002, 1, 1);
            BirthDatePicker.MaxDate = new DateTime(2013, 1, 1);
        }

        private readonly StudentRepository _students;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (FirstNameBox.Text != "" && LastNameBox.Text != "" && SexComboBox.Text != "" && GradeComboBox.Text != "")
            {
                _students.CreateStudent(FirstNameBox.Text, LastNameBox.Text, BirthDatePicker.Value,
                    (Sex)Enum.Parse(typeof(Sex), SexComboBox.Text), (Grade)Enum.Parse(typeof(Grade), GradeComboBox.Text));
                Close();
            }
            else
                MessageBox.Show(@"Inputs are empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FirstNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void LastNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
