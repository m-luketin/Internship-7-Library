using System;
using System.Windows.Forms;

namespace Internship_7_Library.Forms
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }
        

        private void PublisherEdit_Click(object sender, EventArgs e)
        {
            var editPublishers = new Publishers();
            editPublishers.ShowDialog();
        }

        private void AuthorEdit_Click(object sender, EventArgs e)
        {
            var authorsForm = new Authors();
            authorsForm.ShowDialog();
        }

        private void BookEdit_Click(object sender, EventArgs e)
        {
            var bookForm = new Books();
            bookForm.ShowDialog();
        }

        private void StudentEdit_Click(object sender, EventArgs e)
        {
            var studentsForm = new Students();
            studentsForm.ShowDialog();
        }
    }
}
