using System;
using System.Linq;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class EditAuthor : Form
    {
        public EditAuthor(string firstName, string lastName)
        {
            InitializeComponent();
            FirstNameBox.Text = firstName;
            LastNameBox.Text = lastName;
            _oldFirstName = firstName;
            _oldLastName = lastName;
            _authors = new AuthorRepository();
        }

        private readonly AuthorRepository _authors;
        private readonly string _oldFirstName;
        private readonly string _oldLastName;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_authors.GetAuthorList().Any(author => author.FirstName == FirstNameBox.Text) &&
                _authors.GetAuthorList().Any(author => author.LastName == LastNameBox.Text))
            {
                MessageBox.Show(@"Author already in database!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(FirstNameBox.Text) || string.IsNullOrWhiteSpace(LastNameBox.Text))
                {
                    MessageBox.Show(@"Inputs are empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _authors.UpdateAuthor($"{_oldFirstName} {_oldLastName}", $"{FirstNameBox.Text} {LastNameBox.Text}" );
                    Close();
                }
            }
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
