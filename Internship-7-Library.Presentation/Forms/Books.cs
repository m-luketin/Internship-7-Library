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
    public partial class Books : Form
    {
        public Books(BookRepository bookRepo, AuthorRepository authorRepo, PublisherRepository publisherRepo, BorrowRepository borrowRepo)
        {
            InitializeComponent();
            _books = bookRepo;
            _authors = authorRepo;
            _publishers = publisherRepo;
            _borrows = borrowRepo;
            foreach (var book in _books.GetBooksList())
            {
                BooksListBox.Items.Add(book.ToString());
            }
        }

        private readonly BookRepository _books;
        private readonly AuthorRepository _authors;
        private readonly PublisherRepository _publishers;
        private readonly BorrowRepository _borrows;

        private void LoadForm()
        {
            BooksListBox.Items.Clear();
            foreach (var book in _books.GetBooksList())
            {
                BooksListBox.Items.Add(book.ToString());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addBook = new AddBook(_books, _authors, _publishers);
            addBook.ShowDialog();
            LoadForm();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (BooksListBox.CheckedItems.Any())
            {
                _books.DeleteBook(BooksListBox.CheckedItems[0].ToString());
            }

            LoadForm();
        }
    }
}
