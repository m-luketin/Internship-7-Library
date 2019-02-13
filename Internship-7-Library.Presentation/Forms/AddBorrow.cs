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

namespace Internship_7_Library.Forms
{
    public partial class AddBorrow : Form
    {
        public AddBorrow()
        {
            InitializeComponent();
            _books = new BookRepository();
            _students = new StudentRepository();
            _borrows = new BorrowRepository();
            foreach (var student in _students.GetStudentsList())
            {
                StudentComboBox.Items.Add(student);
            }

            foreach (var book in _books.GetBooksList())
            {
                BookComboBox.Items.Add(book);
            }
        }

        private readonly BookRepository _books;
        private readonly StudentRepository _students;
        private readonly BorrowRepository _borrows;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var borrowingStudent = _students.ReadStudent(StudentComboBox.Text);
            var borrowedBook = _books.ReadBook(BookComboBox.Text);
            var dateOfBorrow = BorrowDatePicker.Value;

            _borrows.CreateBorrow(borrowingStudent, borrowedBook, dateOfBorrow);
            Close();
        }
    }
}
