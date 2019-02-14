using System;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class EditAuthor : Form
    {
        public EditAuthor(string firstName, string lastName, AuthorRepository authorRepo)
        {
            InitializeComponent();
            FirstNameBox.Text = firstName;
            LastNameBox.Text = lastName;
            _firstName = firstName;
            _lastName = lastName;
            _authors = authorRepo;
        }

        private readonly AuthorRepository _authors;
        private readonly string _firstName;
        private readonly string _lastName;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (FirstNameBox.Text != "" && LastNameBox.Text != "")
            {
                _authors.UpdateAuthor($"{_firstName} {_lastName}", $"{FirstNameBox.Text} {LastNameBox.Text}");
                Close();
            }
            else
                MessageBox.Show(@"Inputs are empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FirstNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void LastNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
