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
