using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;
using Microsoft.EntityFrameworkCore.Internal;

namespace Internship_7_Library.Forms
{
    public partial class Authors : Form
    {
        public Authors(AuthorRepository authorRepo, BookRepository bookRepo)
        {
            InitializeComponent();
            _authors = authorRepo;
            _books = bookRepo;
            foreach (var author in _authors.GetAuthorList())
            {
                AuthorsListBox.Items.Add(author);
            }
        }

        private readonly AuthorRepository _authors;
        private readonly BookRepository _books;
        
        private void LoadForm()
        {
            AuthorsListBox.Items.Clear();
            foreach (var author in _authors.GetAuthorList())
            {
                AuthorsListBox.Items.Add(author);
            }
        }
        private void LoadBooks()
        {
            BookBox.Items.Clear();
            if (AuthorsListBox.CheckedItems.Any())
            {
                foreach (var book in _books.GetBooksList())
                {
                    if (book.Author.ToString() == AuthorsListBox.CheckedItems[0].ToString())
                        BookBox.Items.Add(book);
                }
            }

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            var addAuthor = new AddAuthor(_authors);
            addAuthor.ShowDialog();
            LoadForm();
        }

        private void AuthorsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {
                for (var index = 0; index < AuthorsListBox.Items.Count; ++index)
                {
                    if (e.Index != index)
                        AuthorsListBox.SetItemChecked(index, false);
                }
            }   
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (AuthorsListBox.CheckedItems.Any())
            {
                var name = _authors.ParseAuthor(AuthorsListBox.CheckedItems[0].ToString());
                _authors.DeleteAuthor($"{name[0]} {name[1]}");
            }

            LoadForm();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (AuthorsListBox.CheckedItems.Any())
            {
                var name = _authors.ParseAuthor(AuthorsListBox.CheckedItems[0].ToString());

                var editAuthor = new EditAuthor(name[0], name[1], _authors);
                editAuthor.ShowDialog();
            }
            
            LoadForm();
        }

        private void AuthorsListBox_MouseMove(object sender, MouseEventArgs e)
        {
            LoadBooks();
        }
    }
}
