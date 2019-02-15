using System;
using System.Linq;
using System.Windows.Forms;
using Internship_7_Library.Data.Enums;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class EditBook : Form
    {
        public EditBook(string bookName)
        {
            InitializeComponent();
            _books = new BookRepository();
            _authors = new AuthorRepository();
            _publishers = new PublisherRepository();
            _oldName = bookName;
            foreach (var author in _authors.GetAuthorList().OrderBy(author => author.LastName))
                AuthorComboBox.Items.Add(author);

            foreach (var publisher in _publishers.GetPublisherList().OrderBy(publisher => publisher.Name))
                PublisherComboBox.Items.Add(publisher);

            foreach (var genre in Enum.GetValues(typeof(Genre)))
                GenreComboBox.Items.Add(genre);

            foreach (var book in _books.GetBooksList().OrderBy(book => book.Name))
            {
                if (book.Name == bookName)
                {
                    NameBox.Text = book.Name;
                    AuthorComboBox.Text = book.Author.ToString();
                    PublisherComboBox.Text = book.Publisher.ToString();
                    PagesBox.Text = book.NumberOfPages.ToString();
                    NumberOfBooksBox.Text = book.NumberOfBooks.ToString();
                    GenreComboBox.Text = book.Genre.ToString();
                }
            }
        }

        private readonly BookRepository _books;
        private readonly AuthorRepository _authors;
        private readonly PublisherRepository _publishers;
        private readonly string _oldName;

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (_books.GetBooksList().Any(book => book.Name == NameBox.Text))
            {
                MessageBox.Show(@"Book already in database!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(NameBox.Text) || string.IsNullOrWhiteSpace(AuthorComboBox.Text) ||
                    string.IsNullOrWhiteSpace(PublisherComboBox.Text) || string.IsNullOrWhiteSpace(PagesBox.Text) ||
                    !string.IsNullOrWhiteSpace(NumberOfBooksBox.Text) || string.IsNullOrWhiteSpace(GenreComboBox.Text))
                {
                    MessageBox.Show(@"Inputs are empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var genre = (Genre)Enum.Parse(typeof(Genre), GenreComboBox.Text);
                    _books.UpdateBook(_oldName, NameBox.Text, _authors.ReadAuthor(AuthorComboBox.Text), _publishers.ReadPublisher(PublisherComboBox.Text), int.Parse(PagesBox.Text), int.Parse(NumberOfBooksBox.Text), genre);
                    Close();
                }
            }
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void PagesBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void NumberOfBooksBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
