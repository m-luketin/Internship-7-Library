﻿using System;
using System.Linq;
using System.Windows.Forms;
using Internship_7_Library.Data.Enums;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class AddBook : Form
    {
        public AddBook(BookRepository bookRepo, AuthorRepository authorRepo, PublisherRepository publisherRepo)
        {
            InitializeComponent();
            _books = bookRepo;
            _authors = authorRepo;
            _publishers = publisherRepo;
            foreach (var author in _authors.GetAuthorList())
            {
                AuthorComboBox.Items.Add(author);
            }

            foreach (var publisher in _publishers.GetPublisherList().OrderBy(publisher => publisher.Name))
            {
                PublisherComboBox.Items.Add(publisher);
            }

            foreach (var genre in Enum.GetValues(typeof(Genre)))
            {
                GenreComboBox.Items.Add(genre);
            }
        }

        private readonly BookRepository _books;
        private readonly AuthorRepository _authors;
        private readonly PublisherRepository _publishers;
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text != "" && AuthorComboBox.Text != "" && PublisherComboBox.Text != "" &&
                PagesBox.Text != "" && NumberOfBooksBox.Text != "" && GenreComboBox.Text != "")
            {
                var genre = (Genre)Enum.Parse(typeof(Genre), GenreComboBox.Text);
                _books.CreateBook(NameBox.Text, _authors.ReadAuthor(AuthorComboBox.Text), _publishers.ReadPublisher(PublisherComboBox.Text), int.Parse(PagesBox.Text), int.Parse(NumberOfBooksBox.Text), genre);
                Close();
            }
            else
                MessageBox.Show(@"Inputs are empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void PagesBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void NumberOfBooksBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
