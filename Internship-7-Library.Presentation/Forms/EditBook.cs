﻿using System;
using System.Windows.Forms;
using Internship_7_Library.Data.Entities.Models;
using Internship_7_Library.Data.Enums;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class EditBook : Form
    {
        public EditBook(string bookName, BookRepository bookRepo, AuthorRepository authorRepo, PublisherRepository publisherRepo)
        {
            InitializeComponent();
            _books = bookRepo;
            _authors = authorRepo;
            _publishers = publisherRepo;
            _oldName = bookName;
            foreach (var author in _authors.GetAuthorList())
                AuthorComboBox.Items.Add(author);

            foreach (var publisher in _publishers.GetPublisherList())
                PublisherComboBox.Items.Add(publisher);

            foreach (var genre in Enum.GetValues(typeof(Genre)))
                GenreComboBox.Items.Add(genre);

            foreach (var book in _books.GetBooksList())
            {
                if (book.Name == bookName)
                {
                    NameBox.Text = book.Name;
                    AuthorComboBox.Text = book.Author.ToString();
                    PublisherComboBox.Text = book.Publisher.ToString();
                    PagesBox.Text = book.NumberOfPages.ToString();
                    NumberOfBooksBox.Text = book.NumberOfBooks.ToString();
                    GenreComboBox.Text = book.Genre.ToString();
                }
            }
        }

        private readonly BookRepository _books;
        private readonly AuthorRepository _authors;
        private readonly PublisherRepository _publishers;
        private readonly string _oldName;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _books.UpdateBook(_oldName, NameBox.Text, _authors.ReadAuthor(AuthorComboBox.Text), _publishers.ReadPublisher(PublisherComboBox.Text), int.Parse(PagesBox.Text), int.Parse(NumberOfBooksBox.Text), (Genre)Enum.Parse(typeof(Genre), GenreComboBox.Text));
            Close();
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
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