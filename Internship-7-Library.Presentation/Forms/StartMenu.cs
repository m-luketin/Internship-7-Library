using System;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm();
            editForm.ShowDialog();
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            var borrowForm = new Borrows();
            borrowForm.ShowDialog();
        }
    }
}
