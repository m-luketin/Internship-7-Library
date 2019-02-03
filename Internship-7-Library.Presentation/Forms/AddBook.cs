using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_7_Library.Data.Enums;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class AddBook : Form
    {
        public AddBook(BookRepository bookRepo, AuthorRepository authorRepo, PublisherRepository publisherRepo)
        {
            InitializeComponent();
            _books = bookRepo;
            _authors = authorRepo;
            _publishers = publisherRepo;
            foreach (var author in _authors.GetAuthorList())
            {
                AuthorComboBox.Items.Add(author);
            }

            foreach (var publisher in _publishers.GetPublisherList())
            {
                PublisherComboBox.Items.Add(publisher);
            }

            foreach (var genre in Enum.GetValues(typeof(Genre)))
            {
                GenreComboBox.Items.Add(genre);
            }
        }

        private readonly BookRepository _books;
        private readonly AuthorRepository _authors;
        private readonly PublisherRepository _publishers;
        private readonly BorrowRepository _borrows;

        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var genre = (Genre) Enum.Parse(typeof(Genre), GenreComboBox.Text);
            _books.CreateBook(NameBox.Text, _authors.ReadAuthor(AuthorComboBox.Text), _publishers.ReadPublisher(PublisherComboBox.Text), int.Parse(PagesBox.Text), int.Parse(NumberOfBooksBox.Text), genre);
            Close();
        }
    }
}
