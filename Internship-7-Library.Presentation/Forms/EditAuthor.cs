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
            _authors.UpdateAuthor($"{_firstName} {_lastName}", $"{FirstNameBox.Text} {LastNameBox.Text}");
            Close();
        }

        private void FirstNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void LastNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
