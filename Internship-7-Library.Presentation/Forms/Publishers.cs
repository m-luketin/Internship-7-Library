using System;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;
using Microsoft.EntityFrameworkCore.Internal;

namespace Internship_7_Library.Forms
{
    public partial class Publishers : Form
    {
        public Publishers()
        {
            InitializeComponent();
            _publishers = new PublisherRepository();
            _books = new BookRepository();
            foreach (var publisher in _publishers.GetPublisherList())
            {
                PublishersListBox.Items.Add(publisher.ToString());
            }
        }

        private readonly PublisherRepository _publishers;
        private readonly BookRepository _books;

        private void LoadForm()
        {
            PublishersListBox.Items.Clear();
            foreach (var publisher in _publishers.GetPublisherList())
            {
                PublishersListBox.Items.Add(publisher.ToString());
            }
        }

        private void LoadBooks()
        {
            BookBox.Items.Clear();
            if (PublishersListBox.CheckedItems.Any())
            {
                foreach (var book in _books.GetBooksList())
                {
                    if (book.Publisher.ToString() == PublishersListBox.CheckedItems[0].ToString())
                        BookBox.Items.Add(book);
                }
            }    
        }
        private void PublishersListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (var index = 0; index < PublishersListBox.Items.Count; ++index)
                {
                    if (e.Index != index)
                        PublishersListBox.SetItemChecked(index, false);
                }
            LoadBooks();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addPublisher = new AddPublisher();
            addPublisher.ShowDialog();
            LoadForm();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PublishersListBox.CheckedItems.Any())
            {
                _publishers.DeletePublisher(PublishersListBox.CheckedItems[0].ToString());
            }

            LoadForm();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PublishersListBox.CheckedItems.Any())
            {
                var editForm = new EditPublisher(PublishersListBox.CheckedItems[0].ToString());
                editForm.ShowDialog();
                LoadForm();
            }
        }

        private void PublishersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void PublishersListBox_MouseMove(object sender, MouseEventArgs e)
        {
            LoadBooks();
        }
    }
}
