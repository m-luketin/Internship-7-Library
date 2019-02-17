using System;
using System.Linq;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class Borrows : Form
    {
        public Borrows()
        {
            InitializeComponent();
             LoadForm();
        }

        private void LoadForm()
        {
            var students = new StudentRepository();
            var books = new BookRepository();
            var borrows = new BorrowRepository();
            var borrowedBooks = borrows.GetBorrowsList().Count(borrow => borrow.ReturnDate == null);

            BorrowsListBox.Items.Clear();
            
            var numberOfAvailableTitles = books.GetBooksList().Count(book => book.NumberOfBooks > borrows.GetBorrowsList().Count(borrow => borrow.BookId == book.BookId && borrow.ReturnDate == null));
            BorrowsListBox.Items.Add($"Available titles:   {numberOfAvailableTitles}");

            var availableTitles = books.GetBooksList().Where(book => book.NumberOfBooks > borrows.GetBorrowsList().Count(borrow => borrow.BookId == book.BookId && borrow.ReturnDate == null));
            foreach (var availableTitle in availableTitles)
            {
                var copiesLeft = availableTitle.NumberOfBooks - borrows.GetBorrowsList().Count(borrow => borrow.BookId == books.ReadBook(availableTitle.Name).BookId && borrow.ReturnDate == null);
                BorrowsListBox.Items.Add($"  - {availableTitle} ({copiesLeft})");
            }
            BorrowsListBox.Items.Add("");

            BorrowsListBox.Items.Add($"Borrowed books:    {borrowedBooks}");
            foreach (var student in students.GetStudentsList().OrderBy(student => student.LastName))
            {
                foreach (var borrow in borrows.GetBorrowsList())
                {
                    if (borrow.StudentId == students.ReadStudent($"{student.FirstName} {student.LastName}").StudentId && borrow.ReturnDate == null)
                    {
                        if (!BorrowsListBox.Items.Contains($"{student}:"))
                            BorrowsListBox.Items.Add($"{student}:");

                        foreach (var book in books.GetBooksList())
                        {
                            if (books.ReadBook(book.Name).BookId == borrow.BookId)
                                BorrowsListBox.Items.Add($"  - {book}");
                        }
                    }
                }
            }

        }

        private void AddBorrowButton_Click(object sender, EventArgs e)
        {
            var addBorrow = new AddBorrow();
            addBorrow.ShowDialog();
            LoadForm();
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            var returnBook = new ReturnBook();
            returnBook.ShowDialog();
            LoadForm();
        }
    }
}
