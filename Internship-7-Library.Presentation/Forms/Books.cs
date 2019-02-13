using System;
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
            _books = new BookRepository();
            _authors = new AuthorRepository();
            _publishers = new PublisherRepository();
            _borrows = new BorrowRepository();
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

        private void LoadInfo()
        {
            InfoBox.Items.Clear();
            if (BooksListBox.CheckedItems.Any())
            {
                foreach (var book in _books.GetBooksList())
                {
                    if (book.Name == BooksListBox.CheckedItems[0].ToString())
                    {
                        InfoBox.Items.Add($"Author:                   {book.Author}");
                        InfoBox.Items.Add($"Publisher:               {book.Publisher}");
                        InfoBox.Items.Add($"Number of pages:  {book.NumberOfPages.ToString()}");
                        InfoBox.Items.Add($"Number of copies: {book.NumberOfBooks.ToString()}");
                        InfoBox.Items.Add($"Genre:                   {book.Genre.ToString()}");
                    }   
                }
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
            LoadInfo();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (BooksListBox.CheckedItems.Any())
            {
                var editBook = new EditBook(BooksListBox.CheckedItems[0].ToString(), _books, _authors, _publishers);
                editBook.ShowDialog();
            }
            LoadForm();
            LoadInfo();
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
            LoadInfo();
        }
    }
}
