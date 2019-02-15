using System;
using System.Linq;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;
using Microsoft.EntityFrameworkCore.Internal;

namespace Internship_7_Library.Forms
{
    public partial class Authors : Form
    {
        public Authors()
        {
            InitializeComponent();
            _authors = new AuthorRepository();
            _books = new BookRepository();
            foreach (var author in _authors.GetAuthorList().OrderBy(author => author.LastName))
            {
                AuthorsListBox.Items.Add(author);
            }
        }

        private readonly AuthorRepository _authors;
        private readonly BookRepository _books;
        
        private void LoadForm()
        {
            AuthorsListBox.Items.Clear();
            foreach (var author in _authors.GetAuthorList().OrderBy(author => author.LastName))
            {
                AuthorsListBox.Items.Add(author);
            }
        }
        private void LoadBooks()
        {
            BookBox.Items.Clear();
            BookBox.Items.Add("Books released");
            BookBox.Items.Add("");

            if (AuthorsListBox.CheckedItems.Any())
            {
                foreach (var book in _books.GetBooksList())
                {
                    if (book.Author.ToString() == AuthorsListBox.CheckedItems[0].ToString())
                    {
                        BookBox.Items.Add($" {book}");
                        BookBox.Items.Add($" {book.Publisher.Name}");
                        BookBox.Items.Add("");
                    } 
                }
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            var addAuthor = new AddAuthor();
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
                var flag = true;
                foreach (var book in _books.GetBooksList())
                    if (AuthorsListBox.CheckedItems[0].ToString() == $"{book.Author.FirstName} {book.Author.LastName}")
                        flag = false;

                if (!flag)
                    MessageBox.Show(@"Author is assigned to a book!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    var result = MessageBox.Show(@"Are you sure?", @"Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _authors.DeleteAuthor(AuthorsListBox.CheckedItems[0].ToString());
                        LoadForm();
                        LoadBooks();
                    }
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (AuthorsListBox.CheckedItems.Any())
            {
                var name = _authors.ParseAuthor(AuthorsListBox.CheckedItems[0].ToString());

                var editAuthor = new EditAuthor(name[0], name[1]);
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
