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
    public partial class AddAuthor : Form
    {
        public AddAuthor(AuthorRepository authorRepo)
        {
            InitializeComponent();
            _authors = authorRepo;
        }

        private readonly AuthorRepository _authors;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var flag = _authors.CreateAuthor(FirstNameBox.Text, LastNameBox.Text);

            if (flag)
                Close();
            else
            {
                var errorMessage = new ErrorMessage();
                errorMessage.Show();
            }
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
