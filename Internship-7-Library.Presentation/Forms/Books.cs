using System;
using System.Linq;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;
using Microsoft.EntityFrameworkCore.Internal;

namespace Internship_7_Library.Forms
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            LoadForm();
        }

        private BookRepository _books;
        private BorrowRepository _borrows;
        private StudentRepository _students;
        private void LoadForm()
        {
            BooksListBox.Items.Clear();

            _books = new BookRepository();
            _borrows = new BorrowRepository();
            _students = new StudentRepository();
            foreach (var book in _books.GetBooksList().OrderBy(book => book.Name))
            {
                BooksListBox.Items.Add(book.ToString());
            }
        }

        private void LoadInfo()
        {
            InfoBox.Items.Clear();
            if (BooksListBox.CheckedItems.Any())
            {
                var rented = 0;
                foreach (var borrow in _borrows.GetBorrowsList())
                    if (BooksListBox.CheckedItems[0].ToString() == borrow.Book.Name && borrow.ReturnDate == null)
                        rented++;

                foreach (var book in _books.GetBooksList())
                {
                    if (book.Name == BooksListBox.CheckedItems[0].ToString())
                    {
                        InfoBox.Items.Add($"Author:                   {book.Author}");
                        InfoBox.Items.Add($"Publisher:               {book.Publisher}");
                        InfoBox.Items.Add($"Number of pages:  {book.NumberOfPages.ToString()}");
                        InfoBox.Items.Add($"Number of copies: {book.NumberOfBooks.ToString()}");
                        InfoBox.Items.Add($"Genre:                   {book.Genre.ToString()}");
                        InfoBox.Items.Add("");
                        InfoBox.Items.Add($"Currently available:      {book.NumberOfBooks - rented}");
                        InfoBox.Items.Add($"Currently rented by:      {rented}");
                        
                    }   
                }
                foreach(var borrow in _borrows.GetBorrowsList())
                    if (_books.ReadBook(BooksListBox.CheckedItems[0].ToString()).BookId == borrow.BookId && borrow.ReturnDate == null)
                        InfoBox.Items.Add($"{_students.ReadStudentById(borrow.StudentId)}");
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            var addBook = new AddBook();
            addBook.ShowDialog();
            LoadForm();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (BooksListBox.CheckedItems.Any())
            {
                var flag = true;
                foreach (var borrow in _borrows.GetBorrowsList())
                    if (_books.ReadBook(BooksListBox.CheckedItems[0].ToString()).BookId == borrow.BookId && borrow.ReturnDate == null)
                        flag = false;
                if (!flag)
                    MessageBox.Show(@"Cant delete currently borrowed book!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    var result = MessageBox.Show(@"Are you sure?", @"Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _books.DeleteBook(BooksListBox.CheckedItems[0].ToString());
                        LoadForm();
                        LoadInfo();
                    }
                } 
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (BooksListBox.CheckedItems.Any())
            {
                var editBook = new EditBook(BooksListBox.CheckedItems[0].ToString());
                editBook.ShowDialog();
            }
            LoadForm();
        }

        private void BooksListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (var index = 0; index < BooksListBox.Items.Count; ++index)
                {
                    if (e.Index != index)
                        BooksListBox.SetItemChecked(index, false);
                }
            }
        }

        private void BooksListBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (BooksListBox.CheckedItems.Any())
            {
                LoadInfo();
            }
        }
    }
}
