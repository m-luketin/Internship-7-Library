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
        }

        private readonly StudentRepository _students;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _students.CreateStudent(FirstNameBox.Text, LastNameBox.Text, BirthDatePicker.Value,
                (Sex) Enum.Parse(typeof(Sex), SexComboBox.Text), (Grade) Enum.Parse(typeof(Grade), GradeComboBox.Text));
            Close();
        }
    }
}
