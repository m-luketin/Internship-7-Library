﻿using System.Collections.Generic;
using Internship_7_Library.Data.Enums;

namespace Internship_7_Library.Data.Entities.Models
{
    public class Book
    {
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public Genre Genre { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<Borrow> Borrows { get; set; }
    }
}