﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_7_Library.Data.Entities;
using Internship_7_Library.Data.Entities.Models;
using Internship_7_Library.Data.Enums;
using Internship_7_Library.Domain.Repositories;
using Internship_7_Library.Forms;

namespace Internship_7_Library
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

             var libraryContext = new LibraryContext();
            var publishers = new PublisherRepository(libraryContext);
            var authors = new AuthorRepository(libraryContext);
            var books = new BookRepository(libraryContext);
            var borrows = new BorrowRepository(libraryContext);
            var students = new StudentRepository(libraryContext);
            

            var startMenu = new StartMenu(publishers, authors, books, borrows, students);
            startMenu.ShowDialog();

        }
    }
}
