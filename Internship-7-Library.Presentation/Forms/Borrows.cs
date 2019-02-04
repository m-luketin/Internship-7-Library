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
        public Borrows(PublisherRepository publishers, AuthorRepository authors, BookRepository books, BorrowRepository borrows, StudentRepository students)
        {
            InitializeComponent();


        }

        private void AddBorrowButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
