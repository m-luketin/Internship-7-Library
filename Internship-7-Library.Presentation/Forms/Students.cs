﻿using System;
using System.Linq;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;
using Microsoft.EntityFrameworkCore.Internal;

namespace Internship_7_Library.Forms
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            _students = new StudentRepository();
            _borrows = new BorrowRepository();

            foreach (var student in _students.GetStudentsList().OrderBy(student => student.LastName))
            {
                StudentsListBox.Items.Add(student);
            }
        }

        private readonly StudentRepository _students;
        private readonly BorrowRepository _borrows;

        private void LoadForm()
        {
            StudentsListBox.Items.Clear();
            foreach (var student in _students.GetStudentsList().OrderBy(student => student.LastName))
            {
                StudentsListBox.Items.Add(student.ToString());
            }
        }

        private void LoadInfo()
        {
            InfoBox.Items.Clear();
            if (StudentsListBox.CheckedItems.Any())
            {
                foreach (var student in _students.GetStudentsList())
                {
                    if (student.ToString() == StudentsListBox.CheckedItems[0].ToString())
                    {
                        InfoBox.Items.Add($"First name:   {student.FirstName}");
                        InfoBox.Items.Add($"Last name:   {student.LastName}");
                        InfoBox.Items.Add($"Birth date:    {student.BirthDate:dd/MM/yyyy}");
                        InfoBox.Items.Add($"Sex:             {student.Sex}");
                        InfoBox.Items.Add($"Grade:         {student.Grade}");
                    }
                }

                InfoBox.Items.Add("");
                var noneFlag = true;
                InfoBox.Items.Add("Un-returned books:");

                foreach (var borrow in _borrows.GetBorrowsList())
                {

                    if ($"{borrow.Student.FirstName} {borrow.Student.LastName}" == StudentsListBox.CheckedItems[0].ToString() && borrow.ReturnDate == null)
                    {
                        InfoBox.Items.Add(borrow.Book.Name);
                        noneFlag = false;
                    }
                }
                if (noneFlag)
                    InfoBox.Items.Add("None");

                InfoBox.Items.Add("");
                noneFlag = true;
                InfoBox.Items.Add("Previously borrowed books:");

                foreach (var borrow in _borrows.GetBorrowsList())
                {
                    if ($"{borrow.Student.FirstName} {borrow.Student.LastName}" == StudentsListBox.CheckedItems[0].ToString() && borrow.ReturnDate.HasValue)
                    {
                        InfoBox.Items.Add(borrow.Book.Name);
                        noneFlag = false;
                    }
                }
                if (noneFlag)
                    InfoBox.Items.Add("None");
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
            LoadInfo();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addStudent = new AddStudent();
            addStudent.ShowDialog();
            LoadForm();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (StudentsListBox.CheckedItems.Any())
            {
                var flag = true;
                foreach (var borrow in _borrows.GetBorrowsList())
                    if (_students.ReadStudent(StudentsListBox.CheckedItems[0].ToString()).StudentId == borrow.StudentId && borrow.ReturnDate == null)
                        flag = false;

                if (!flag)
                    MessageBox.Show(@"Student has un-returned books!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    var result = MessageBox.Show(@"Are you sure?", @"Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        foreach (var borrow in _borrows.GetBorrowsList())
                        {
                            if (_students.ReadStudent(StudentsListBox.CheckedItems[0].ToString()).StudentId ==
                                borrow.StudentId)
                                _borrows.DeleteBorrow(borrow.BorrowId);
                        }
                        _students.DeleteStudent(StudentsListBox.CheckedItems[0].ToString());
                        LoadForm();
                        LoadInfo();
                    }
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (StudentsListBox.CheckedItems.Any())
            {
                var name = _students.ParseStudent(StudentsListBox.CheckedItems[0].ToString());

                var editStudent = new EditStudent(name[0], name[1]);
                editStudent.ShowDialog();
                LoadForm();
            }
            
        }

        private void StudentsListBox_MouseMove(object sender, MouseEventArgs e)
        {
            LoadInfo();
        }
    }
}
