using System;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
            _books = new BookRepository();
            _students = new StudentRepository();
            _borrows = new BorrowRepository();
            foreach (var student in _students.GetStudentsList())
            {
                StudentComboBox.Items.Add(student);
            }

            ReturnDatePicker.MinDate = new DateTime(2018, 1, 1);
            ReturnDatePicker.MaxDate = new DateTime(2020, 1, 1);
        }

        private readonly BookRepository _books;
        private readonly StudentRepository _students;
        private readonly BorrowRepository _borrows;

        private void LoadBooks()
        {
            BookComboBox.Items.Clear();
                foreach (var borrow in _borrows.GetBorrowsList())
                    if (_students.ReadStudent(StudentComboBox.Text).StudentId == borrow.StudentId && !borrow.ReturnDate.HasValue)
                        BookComboBox.Items.Add(borrow.Book.Name);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _borrows.ReturnBorrow(_students.ReadStudent(StudentComboBox.Text).StudentId,
                                  _books.ReadBook(BookComboBox.Text).BookId,
                                   ReturnDatePicker.Value);
            Close();
        }

        private void StudentComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if(StudentComboBox.Text != "")
                LoadBooks();
        }
    }
}
