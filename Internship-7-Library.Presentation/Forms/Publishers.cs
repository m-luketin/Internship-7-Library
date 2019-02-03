using System;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;
using Microsoft.EntityFrameworkCore.Internal;

namespace Internship_7_Library.Forms
{
    public partial class Publishers : Form
    {
        public Publishers(PublisherRepository publisherRepo, BookRepository bookRepo)
        {
            InitializeComponent();
            _publishers = publisherRepo;
            _books = bookRepo;
            foreach (var publisher in _publishers.GetPublisherList())
            {
                PublishersListBox.Items.Add(publisher.ToString());
            }
        }

        private readonly PublisherRepository _publishers;
        private readonly BookRepository _books;

        private void LoadForm(PublisherRepository publishersRepo)
        {
            PublishersListBox.Items.Clear();
            foreach (var publisher in publishersRepo.GetPublisherList())
            {
                PublishersListBox.Items.Add(publisher.ToString());
            }
        }
        private void PublishersListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (var index = 0; index < PublishersListBox.Items.Count; ++index)
                {
                    if (e.Index != index)
                        PublishersListBox.SetItemChecked(index, false);
                    else
                    {
                        foreach (var book in _books.GetBooksList())
                        {
                            if (book.ToString() == e.CurrentValue.ToString())
                                BookBox.Items.Add(book);
                        }
                    }
                }
                

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addPublisher = new AddPublisher(_publishers);
            addPublisher.ShowDialog();
            LoadForm(_publishers);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PublishersListBox.CheckedItems.Any())
            {
                _publishers.DeletePublisher(PublishersListBox.CheckedItems[0].ToString());
            }

            LoadForm(_publishers);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PublishersListBox.CheckedItems.Any())
            {
                var editForm = new EditPublisher(PublishersListBox.CheckedItems[0].ToString(), _publishers);
                editForm.ShowDialog();
                LoadForm(_publishers);
            }
            
        }
    }
}
