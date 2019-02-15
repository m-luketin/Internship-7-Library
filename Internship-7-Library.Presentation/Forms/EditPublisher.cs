using System;
using System.Linq;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class EditPublisher : Form
    {
        public EditPublisher(string publisherName)
        {
            InitializeComponent();
            _oldPublisherName = publisherName;
            _publishers = new PublisherRepository();
            PublisherNameBox.Text = publisherName;
        }

        private readonly string _oldPublisherName;
        private readonly PublisherRepository _publishers;
       
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_publishers.GetPublisherList().Any(publisher => publisher.Name == PublisherNameBox.Text))
            {
                MessageBox.Show(@"Publisher already in database!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(PublisherNameBox.Text))
                {
                    MessageBox.Show(@"Inputs are empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _publishers.UpdatePublisher(_oldPublisherName, PublisherNameBox.Text);
                    Close();
                }
            }
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
