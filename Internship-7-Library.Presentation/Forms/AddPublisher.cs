using System;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class AddPublisher : Form
    {
        public AddPublisher()
        {
            InitializeComponent();
            _publishers = new PublisherRepository();
        }

        private readonly PublisherRepository _publishers;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (PublisherNameBox.Text != "")
            {
                _publishers.CreatePublisher(PublisherNameBox.Text);
                Close();
            }
            else
                MessageBox.Show(@"Inputs are empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PublisherNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
