using System;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class EditPublisher : Form
    {
        public EditPublisher(string publisherName)
        {
            InitializeComponent();
            _publisherName = publisherName;
            _publishers = new PublisherRepository();
            PublisherNameBox.Text = publisherName;
        }

        private readonly string _publisherName;
        private readonly PublisherRepository _publishers;
       
        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            if (PublisherNameBox.Text != "")
            {
                _publishers.UpdatePublisher(_publisherName, PublisherNameBox.Text);
                Close();
            }
            else
                MessageBox.Show(@"Inputs are empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PublisherNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
