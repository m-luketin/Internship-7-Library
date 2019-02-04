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
    public partial class EditForm : Form
    {
        public EditForm(PublisherRepository publishers, AuthorRepository authors, BookRepository books, BorrowRepository borrows, StudentRepository students)
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

        private void PublisherEdit_Click(object sender, EventArgs e)
        {
            var editPublishers = new Publishers(_publisherRepo, _bookRepo);
            editPublishers.ShowDialog();
        }

        private void AuthorEdit_Click(object sender, EventArgs e)
        {
            var authorsForm = new Authors(_authorRepo, _bookRepo);
            authorsForm.ShowDialog();
        }

        private void BookEdit_Click(object sender, EventArgs e)
        {
            var bookForm = new Books(_bookRepo, _authorRepo, _publisherRepo, _borrowRepo);
            bookForm.ShowDialog();
        }

        private void StudentEdit_Click(object sender, EventArgs e)
        {
            var studentsForm = new Students(_studentRepo, _bookRepo, _borrowRepo);
            studentsForm.ShowDialog();
        }
    }
}
