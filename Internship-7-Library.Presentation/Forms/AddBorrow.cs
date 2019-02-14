using System;
using System.Linq;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;
using MessageBox = System.Windows.Forms.MessageBox;

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
            foreach (var student in _students.GetStudentsList().OrderBy(student => student.LastName))
            {
                StudentComboBox.Items.Add(student);
            }

            BorrowDatePicker.MinDate = new DateTime(2019, 1, 1);
            BorrowDatePicker.MaxDate = new DateTime(2020, 1, 1);
        }

        private readonly BookRepository _books;
        private readonly StudentRepository _students;
        private readonly BorrowRepository _borrows;

        private void LoadBooks()
        {
            BookComboBox.Items.Clear();

            foreach (var book in _books.GetBooksList().OrderBy(book => book.Name))
            {
                BookComboBox.Items.Add(book.Name);
            }
            foreach (var borrow in _borrows.GetBorrowsList())
                if (_students.ReadStudent(StudentComboBox.Text).StudentId == borrow.StudentId && borrow.ReturnDate == null)
                    BookComboBox.Items.Remove(borrow.Book.Name);
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (StudentComboBox.Text != "" && BookComboBox.Text != "")
            {
                var borrowingStudent = _students.ReadStudent(StudentComboBox.Text);
                var borrowedBook = _books.ReadBook(BookComboBox.Text);
                var dateOfBorrow = BorrowDatePicker.Value;

                var available = borrowedBook.NumberOfBooks;
                var alreadyRented = 0;

                foreach (var borrow in _borrows.GetBorrowsList().Where(borrow => borrow.ReturnDate == null))
                {
                    if (borrow.BookId == borrowedBook.BookId)
                        available--;
                    if (borrow.StudentId == borrowingStudent.StudentId)
                        alreadyRented++;
                }

                if (alreadyRented > 2)
                    MessageBox.Show(@"Student passed book limit!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (available < 1)
                    MessageBox.Show(@"No books available!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    _borrows.CreateBorrow(borrowingStudent, borrowedBook, dateOfBorrow);
                    Close();
                }
            }
            else
                MessageBox.Show(@"Inputs are empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void StudentComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if(StudentComboBox.Text != "")
                LoadBooks();
        }
    }
}
