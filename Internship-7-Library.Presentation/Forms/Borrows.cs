using System;
using System.Windows.Forms;

namespace Internship_7_Library.Forms
{
    public partial class Borrows : Form
    {
        public Borrows()
        {
            InitializeComponent();
        }

        private void AddBorrowButton_Click(object sender, EventArgs e)
        {
            var addBorrow = new AddBorrow();
            addBorrow.ShowDialog();
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            var returnBook = new ReturnBook();
            returnBook.ShowDialog();
        }
    }
}
