using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_7_Library.Data.Entities.Models;
using Internship_7_Library.Data.Enums;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class EditStudent : Form
    {
        public EditStudent(string firstName, string lastName, StudentRepository studentRepo)
        {
            InitializeComponent();
            
            _firstName = firstName;
            _lastName = lastName;
            _students = studentRepo;

            foreach (var sex in Enum.GetValues(typeof(Sex)))
                SexComboBox.Items.Add(sex);

            foreach (var grade in Enum.GetValues(typeof(Grade)))
                GradeComboBox.Items.Add(grade);

            var oldStudent = _students.ReadStudent($"{_firstName} {_lastName}");
            FirstNameBox.Text = oldStudent.FirstName;
            LastNameBox.Text = oldStudent.LastName;
            BirthDatePicker.Value = oldStudent.BirthDate;
            SexComboBox.Text = oldStudent.Sex.ToString();
            GradeComboBox.Text = oldStudent.Grade.ToString();

            BirthDatePicker.MinDate = new DateTime(2019, 1, 1);
            BirthDatePicker.MaxDate = new DateTime(2020, 1, 1);
        }

        private readonly StudentRepository _students;
        private readonly string _firstName;
        private readonly string _lastName;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _students.UpdateStudent($"{_firstName} {_lastName}", new Student(
                FirstNameBox.Text, LastNameBox.Text, BirthDatePicker.Value, (Sex) Enum.Parse(typeof(Sex), 
                SexComboBox.Text), (Grade) Enum.Parse(typeof(Grade), GradeComboBox.Text)));

            Close();
        }

        private void FirstNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void LastNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
