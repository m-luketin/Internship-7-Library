using System;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class StartMenu : Form
    {
        public StartMenu(PublisherRepository publishers, AuthorRepository authors, BookRepository books, BorrowRepository borrows, StudentRepository students)
        {
            InitializeComponent();
            _publisherRepo = publishers;
            _authorRepo = authors;
            _bookRepo = books;
            _borrowRepo = borrows;
            _studentRepo = students;
        }

        private readonly PublisherRepository _publisherRepo;
        private readonly AuthorRepository _authorRepo;
        private readonly BookRepository _bookRepo;
        private readonly BorrowRepository _borrowRepo;
        private readonly StudentRepository _studentRepo;

        private void EditButton_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm(_publisherRepo, _authorRepo, _bookRepo, _borrowRepo, _studentRepo);
            editForm.ShowDialog();
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            var borrowForm = new Borrows(_publisherRepo, _authorRepo, _bookRepo, _borrowRepo, _studentRepo);
            borrowForm.ShowDialog();
        }
    }
}
