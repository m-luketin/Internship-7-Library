using System;
using System.Linq;
using System.Windows.Forms;
using Internship_7_Library.Data.Entities.Models;
using Internship_7_Library.Data.Enums;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class EditStudent : Form
    {
        public EditStudent(string firstName, string lastName)
        {
            InitializeComponent();
            
            _oldFirstName = firstName;
            _oldLastName = lastName;
            _students = new StudentRepository();

            foreach (var sex in Enum.GetValues(typeof(Sex)))
                SexComboBox.Items.Add(sex);

            foreach (var grade in Enum.GetValues(typeof(Grade)))
                GradeComboBox.Items.Add(grade);

            var oldStudent = _students.ReadStudent($"{_oldFirstName} {_oldLastName}");
            FirstNameBox.Text = oldStudent.FirstName;
            LastNameBox.Text = oldStudent.LastName;
            BirthDatePicker.Value = oldStudent.BirthDate;
            SexComboBox.Text = oldStudent.Sex.ToString();
            GradeComboBox.Text = oldStudent.Grade.ToString();

            BirthDatePicker.MinDate = new DateTime(2002, 1, 1);
            BirthDatePicker.MaxDate = new DateTime(2013, 1, 1);
        }

        private readonly StudentRepository _students;
        private readonly string _oldFirstName;
        private readonly string _oldLastName;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_students.GetStudentsList().Any(student =>
                student.FirstName == FirstNameBox.Text && student.LastName == LastNameBox.Text))
            {
                MessageBox.Show(@"Student already in database!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(FirstNameBox.Text) || string.IsNullOrWhiteSpace(LastNameBox.Text) ||
                    string.IsNullOrWhiteSpace(SexComboBox.Text) || string.IsNullOrWhiteSpace(GradeComboBox.Text))
                {
                    MessageBox.Show(@"Inputs are empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _students.UpdateStudent($"{_oldFirstName} {_oldLastName}", new Student(FirstNameBox.Text, LastNameBox.Text, BirthDatePicker.Value,
                        (Sex)Enum.Parse(typeof(Sex), SexComboBox.Text), (Grade)Enum.Parse(typeof(Grade), GradeComboBox.Text)));
                    Close();
                }
            }
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
