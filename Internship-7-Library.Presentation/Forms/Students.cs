using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;
using Microsoft.EntityFrameworkCore.Internal;

namespace Internship_7_Library.Forms
{
    public partial class Students : Form
    {
        public Students(StudentRepository studentRepo, BookRepository bookRepo, BorrowRepository borrowRepo)
        {
            InitializeComponent();
            _students = studentRepo;
            _borrows = borrowRepo;
            _books = bookRepo;

            foreach (var student in _students.GetStudentsList())
            {
                StudentsListBox.Items.Add(student);
            }
        }

        private readonly StudentRepository _students;
        private readonly BorrowRepository _borrows;
        private readonly BookRepository _books;

        private void LoadForm()
        {
            StudentsListBox.Items.Clear();
            foreach (var student in _students.GetStudentsList())
            {
                StudentsListBox.Items.Add(student.ToString());
            }
        }

        private void LoadBooks()
        {
            BookBox.Items.Clear();
            if (StudentsListBox.CheckedItems.Any())
            {
               
            }

        }

        private void StudentsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (var index = 0; index < StudentsListBox.Items.Count; ++index)
                {
                    if (e.Index != index)
                        StudentsListBox.SetItemChecked(index, false);
                }
            LoadBooks();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addStudent = new AddStudent(_students);
            addStudent.ShowDialog();
            LoadForm();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (StudentsListBox.CheckedItems.Any())
            {
                var name = _students.ParseStudent(StudentsListBox.CheckedItems[0].ToString());
                _students.DeleteStudent($"{name[0]} {name[1]}");
            }

            LoadForm();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var name = _students.ParseStudent(StudentsListBox.CheckedItems[0].ToString());
            
            var editStudent = new EditStudent(name[0], name[1], _students);
            editStudent.ShowDialog();
            LoadForm();
        }
    }
}
