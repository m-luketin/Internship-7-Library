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

        private PublisherRepository _publisherRepo;
        private AuthorRepository _authorRepo;
        private BookRepository _bookRepo;
        private BorrowRepository _borrowRepo;
        private StudentRepository _studentRepo;

        private void EditButton_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm(_publisherRepo, _authorRepo, _bookRepo, _borrowRepo, _studentRepo);
            editForm.ShowDialog();
        }
    }
}
